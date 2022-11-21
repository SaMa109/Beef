/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Entities
{
    /// <summary>
    /// Represents the US State entity.
    /// </summary>
    public partial class USState : ReferenceDataBaseEx<Guid, USState>
    {
        /// <summary>
        /// An implicit cast from a <see cref="IReferenceData.Code"> to a <see cref="USState"/>.
        /// </summary>
        /// <param name="code">The <b>Code</b>.</param>
        /// <returns>The corresponding <see cref="USState"/>.</returns>
        public static implicit operator USState?(string? code) => ConvertFromCode(code);
    }

    /// <summary>
    /// Represents the <see cref="USState"/> collection.
    /// </summary>
    public partial class USStateCollection : ReferenceDataCollectionBase<Guid, USState, USStateCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="USStateCollection"/> class.
        /// </summary>
        public USStateCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="USStateCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public USStateCollection(IEnumerable<USState> items) => AddRange(items);
    }
}

#pragma warning restore
#nullable restore