/*
 * This file is automatically generated; any changes will be lost.
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CoreEx.Configuration;
using CoreEx.Entities;
using CoreEx.Http;
using CoreEx.Json;
using Microsoft.Extensions.Logging;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Agents
{
    /// <summary>
    /// Defines the <see cref="Gender"/> HTTP agent.
    /// </summary>
    public partial interface IGenderAgent
    {
        /// <summary>
        /// Gets the specified <see cref="Gender"/>.
        /// </summary>
        /// <param name="id">The <see cref="Gender"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        Task<HttpResult<Gender?>> GetAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="Gender"/>.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/>.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        Task<HttpResult<Gender>> CreateAsync(Gender value, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing <see cref="Gender"/>.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/>.</param>
        /// <param name="id">The <see cref="Gender"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        Task<HttpResult<Gender>> UpdateAsync(Gender value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Provides the <see cref="Gender"/> HTTP agent.
    /// </summary>
    public partial class GenderAgent : TypedHttpClientBase<GenderAgent>, IGenderAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenderAgent"/> class.
        /// </summary>
        /// <param name="client">The underlying <see cref="HttpClient"/>.</param>
        /// <param name="jsonSerializer">The <see cref="IJsonSerializer"/>.</param>
        /// <param name="executionContext">The <see cref="CoreEx.ExecutionContext"/>.</param>
        /// <param name="settings">The <see cref="SettingsBase"/>.</param>
        /// <param name="logger">The <see cref="ILogger"/>.</param>
        public GenderAgent(HttpClient client, IJsonSerializer jsonSerializer, CoreEx.ExecutionContext executionContext, SettingsBase settings, ILogger<GenderAgent> logger) 
            : base(client, jsonSerializer, executionContext, settings, logger) { }

        /// <summary>
        /// Gets the specified <see cref="Gender"/>.
        /// </summary>
        /// <param name="id">The <see cref="Gender"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        public Task<HttpResult<Gender?>> GetAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => GetAsync<Gender?>("api/v1/demo/ref/genders/{id}", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<Guid>("id", id)), cancellationToken: cancellationToken);

        /// <summary>
        /// Creates a new <see cref="Gender"/>.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/>.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        public Task<HttpResult<Gender>> CreateAsync(Gender value, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => PostAsync<Gender, Gender>("api/v1/demo/ref/genders", value, requestOptions: requestOptions, cancellationToken: cancellationToken);

        /// <summary>
        /// Updates an existing <see cref="Gender"/>.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/>.</param>
        /// <param name="id">The <see cref="Gender"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        public Task<HttpResult<Gender>> UpdateAsync(Gender value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => PutAsync<Gender, Gender>("api/v1/demo/ref/genders/{id}", value, requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<Guid>("id", id)), cancellationToken: cancellationToken);
    }
}

#pragma warning restore
#nullable restore