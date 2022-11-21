/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Cdr.Banking.Business.Entities
{
    /// <summary>
    /// Represents the Transaction Status entity.
    /// </summary>
    public partial class TransactionStatus : ReferenceDataBaseEx<Guid, TransactionStatus>
    {
        /// <summary>
        /// An implicit cast from a <see cref="IReferenceData.Code"> to a <see cref="TransactionStatus"/>.
        /// </summary>
        /// <param name="code">The <b>Code</b>.</param>
        /// <returns>The corresponding <see cref="TransactionStatus"/>.</returns>
        public static implicit operator TransactionStatus?(string? code) => ConvertFromCode(code);
    }

    /// <summary>
    /// Represents the <see cref="TransactionStatus"/> collection.
    /// </summary>
    public partial class TransactionStatusCollection : ReferenceDataCollectionBase<Guid, TransactionStatus, TransactionStatusCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatusCollection"/> class.
        /// </summary>
        public TransactionStatusCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatusCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public TransactionStatusCollection(IEnumerable<TransactionStatus> items) => AddRange(items);
    }
}

#pragma warning restore
#nullable restore