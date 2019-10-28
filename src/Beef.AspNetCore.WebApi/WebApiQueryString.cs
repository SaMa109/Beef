﻿// Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

using Beef.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Beef.AspNetCore.WebApi
{
    /// <summary>
    /// Provides capabilities for working with the query string.
    /// </summary>
    public static class WebApiQueryString
    {
        /// <summary>
        /// Gets or sets the list of possible <see cref="PagingArgs.Page"/> query string names.
        /// </summary>
        public static IEnumerable<string> PagingArgsPageQueryStringNames { get; set; } = new string[] { "$page", "$pageNumber" };

        /// <summary>
        /// Gets or sets the list of possible <see cref="PagingArgs.Skip"/> query string names.
        /// </summary>
        public static IEnumerable<string> PagingArgsSkipQueryStringNames { get; set; } = new string[] { "$skip" };

        /// <summary>
        /// Gets or sets the list of possible <see cref="PagingArgs.Take"/> query string names.
        /// </summary>
        public static IEnumerable<string> PagingArgsTakeQueryStringNames { get; set; } = new string[] { "$take", "$top", "$size", "$pageSize" };

        /// <summary>
        /// Gets or sets the list of possible <see cref="PagingArgs.Take"/> query string names.
        /// </summary>
        public static IEnumerable<string> PagingArgsCountQueryStringNames { get; set; } = new string[] { "$count", "$totalCount" };

        /// <summary>
        /// Gets or sets the list of possible <see cref="PagingArgs.IncludeFields"/> query string names.
        /// </summary>
        public static IEnumerable<string> IncludeFieldsStringNames { get; set; } = new string[] { "$fields", "$includeFields", "$include" };

        /// <summary>
        /// Gets or sets the list of possible <see cref="PagingArgs.ExcludeFields"/> query string names.
        /// </summary>
        public static IEnumerable<string> ExcludeFieldsStringNames { get; set; } = new string[] { "$excludeFields", "$exclude" };

        /// <summary>
        /// Creates the <see cref="PagingArgs"/> from the query string.
        /// </summary>
        /// <param name="controller">The <see cref="ControllerBase"/> that has the request url.</param>
        /// <returns>The <see cref="PagingArgs"/>.</returns>
        /// <remarks>Will return the <see cref="ExecutionContext"/> <see cref="ExecutionContext.PagingArgs"/> where already set; otherwise, will update it once value inferred.</remarks>
        public static PagingArgs CreatePagingArgs(this ControllerBase controller)
        {
            if (ExecutionContext.HasCurrent && ExecutionContext.Current.PagingArgs != null)
                return ExecutionContext.Current.PagingArgs;

            var q = controller.HttpContext.Request.Query;
            PagingArgs pa;

            if (q == null || q.Count == 0)
                pa = new PagingArgs();
            else
            {
                long? skip = ParseLongValue(GetNamedQueryString(controller, PagingArgsSkipQueryStringNames));
                long? take = ParseLongValue(GetNamedQueryString(controller, PagingArgsTakeQueryStringNames));
                long? page = skip.HasValue ? null : ParseLongValue(GetNamedQueryString(controller, PagingArgsPageQueryStringNames));

                if (skip == null && page == null)
                    pa = (take.HasValue) ? PagingArgs.CreateSkipAndTake(0, take) : new PagingArgs();
                else
                    pa = (skip.HasValue) ? PagingArgs.CreateSkipAndTake(skip.Value, take) : PagingArgs.CreatePageAndSize(page.Value, take);

                pa.IsGetCount = ParseBoolValue(GetNamedQueryString(controller, PagingArgsCountQueryStringNames));

                var fields = GetNamedQueryString(controller, IncludeFieldsStringNames);
                if (!string.IsNullOrEmpty(fields))
                    pa.IncludeFields.AddRange(fields.Split(',', StringSplitOptions.RemoveEmptyEntries));

                fields = GetNamedQueryString(controller, ExcludeFieldsStringNames);
                if (!string.IsNullOrEmpty(fields))
                    pa.ExcludeFields.AddRange(fields.Split(',', StringSplitOptions.RemoveEmptyEntries));
            }

            if (ExecutionContext.HasCurrent && ExecutionContext.Current.PagingArgs == null)
                ExecutionContext.Current.PagingArgs = pa;

            return pa;
        }

        /// <summary>
        /// Gets the value for the named query string.
        /// </summary>
        private static string GetNamedQueryString(ControllerBase controller, IEnumerable<string> names)
        {
            var q = controller.HttpContext.Request.Query.Where(x => names.Contains(x.Key, StringComparer.InvariantCultureIgnoreCase)).ToArray();
            return (q.Length != 1 || q[0].Value.Count != 1) ? null : q[0].Value[0];
        }

        /// <summary>
        /// Parses the value as a <see cref="long"/>.
        /// </summary>
        private static long? ParseLongValue(string value)
        {
            if (value == null)
                return null;

            if (!long.TryParse(value, out long val))
                return null;

            return val;
        }

        /// <summary>
        /// Parses the value as a <see cref="bool"/>.
        /// </summary>
        private static bool ParseBoolValue(string value)
        {
            if (value == null)
                return false;

            if (!bool.TryParse(value, out bool val))
                return false;

            return val;
        }

        /// <summary>
        /// Gets the reference data selection from the query string.
        /// </summary>
        /// <param name="controller">The <see cref="ControllerBase"/> that has the request url.</param>
        /// <returns>The resulting selection.</returns>
        public static IEnumerable<KeyValuePair<string, StringValues>> GetReferenceDataSelection(this ControllerBase controller)
        {
            Check.NotNull(controller, nameof(controller));

            var dict = new Dictionary<string, KeyValuePair<string, StringValues>>();
            if (controller.HttpContext.Request.Query.Count() == 0)
            {
                ExecutionContext.Current.Messages.AddInfo("Query string is required to filter selection; e.g. api/v1/demo/ref?entity=codeX,codeY&entity2=codeZ&entity3");
                return dict.Values;
            }

            foreach (var q in controller.HttpContext.Request.Query.Where(x => !string.IsNullOrEmpty(x.Key)))
            {
                if (string.Compare(q.Key, "names", true) == 0)
                {
                    foreach (var v in q.Value.Where(x => !string.IsNullOrEmpty(x)))
                    {
                        if (!dict.ContainsKey(v))
                        {
                            dict.Add(v, new KeyValuePair<string, StringValues>(v, new StringValues()));
                        }
                    }
                }
                else
                {
                    dict[q.Key] = new KeyValuePair<string, StringValues>(q.Key, q.Value);
                }
            }

            return dict.Values;
        }
    }
}