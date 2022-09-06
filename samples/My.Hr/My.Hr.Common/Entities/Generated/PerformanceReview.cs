/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using CoreEx.Entities;

namespace My.Hr.Common.Entities
{
    /// <summary>
    /// Represents the Performance Review entity.
    /// </summary>
    public partial class PerformanceReview : IIdentifier<Guid>, IETag, IChangeLog
    {
        /// <summary>
        /// Gets or sets the <see cref="Employee"/> identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Employee.Id"/> (value is immutable).
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets the corresponding <see cref="Outcome"/> text (read-only where selected).
        /// </summary>
        public string? OutcomeText { get; set ; }

        /// <summary>
        /// Gets or sets the Outcome.
        /// </summary>
        public string? Outcome { get; set; }

        /// <summary>
        /// Gets or sets the Reviewer.
        /// </summary>
        public string? Reviewer { get; set; }

        /// <summary>
        /// Gets or sets the Notes.
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the ETag.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? ETag { get; set; }

        /// <summary>
        /// Gets or sets the Change Log.
        /// </summary>
        public ChangeLog? ChangeLog { get; set; }
    }

    /// <summary>
    /// Represents the <see cref="PerformanceReview"/> collection.
    /// </summary>
    public partial class PerformanceReviewCollection : List<PerformanceReview> { }

    /// <summary>
    /// Represents the <see cref="PerformanceReview"/> collection result.
    /// </summary>
    public class PerformanceReviewCollectionResult : CollectionResult<PerformanceReviewCollection, PerformanceReview>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceReviewCollectionResult"/> class.
        /// </summary>
        public PerformanceReviewCollectionResult() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceReviewCollectionResult"/> class with <paramref name="paging"/>.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public PerformanceReviewCollectionResult(PagingArgs? paging) : base(paging) { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceReviewCollectionResult"/> class with a <paramref name="collection"/> of items to add.
        /// </summary>
        /// <param name="collection">A collection containing items to add.</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public PerformanceReviewCollectionResult(IEnumerable<PerformanceReview> collection, PagingArgs? paging = null) : base(paging) => Collection.AddRange(collection);
    }
}

#pragma warning restore
#nullable restore