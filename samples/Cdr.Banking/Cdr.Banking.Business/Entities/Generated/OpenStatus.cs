/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Cdr.Banking.Business.Entities
{
    /// <summary>
    /// Represents the Open Status entity.
    /// </summary>
    public partial class OpenStatus : ReferenceDataBaseEx<Guid, OpenStatus>
    {
        /// <summary>
        /// Represents a All (both Open and Closed) constant value.
        /// </summary>
        public const string All = "ALL";


        /// <summary>
        /// An implicit cast from an <see cref="IIdentifier.Id"> to <see cref="OpenStatus"/>.
        /// </summary>
        /// <param name="id">The <see cref="IIdentifier.Id">.</param>
        /// <returns>The corresponding <see cref="OpenStatus"/>.</returns>
        public static implicit operator OpenStatus?(Guid id) => ConvertFromId(id);

        /// <summary>
        /// An implicit cast from a <see cref="IReferenceData.Code"> to <see cref="OpenStatus"/>.
        /// </summary>
        /// <param name="code">The <see cref="IReferenceData.Code">.</param>
        /// <returns>The corresponding <see cref="OpenStatus"/>.</returns>
        public static implicit operator OpenStatus?(string? code) => ConvertFromCode(code);
    }

    /// <summary>
    /// Represents the <see cref="OpenStatus"/> collection.
    /// </summary>
    public partial class OpenStatusCollection : ReferenceDataCollectionBase<Guid, OpenStatus, OpenStatusCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenStatusCollection"/> class.
        /// </summary>
        public OpenStatusCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenStatusCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public OpenStatusCollection(IEnumerable<OpenStatus> items) => AddRange(items);
    }
}

#pragma warning restore
#nullable restore