/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Cdr.Banking.Business.Data
{
    /// <summary>
    /// Provides the <see cref="Transaction"/> data access.
    /// </summary>
    public partial class TransactionData : ITransactionData
    {
        private readonly ICosmos _cosmos;
        private Func<IQueryable<Model.Transaction>, string?, TransactionArgs?, IQueryable<Model.Transaction>>? _getTransactionsOnQuery;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionData"/> class.
        /// </summary>
        /// <param name="cosmos">The <see cref="ICosmos"/>.</param>
        public TransactionData(ICosmos cosmos)
            { _cosmos = cosmos ?? throw new ArgumentNullException(nameof(cosmos)); TransactionDataCtor(); }

        partial void TransactionDataCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Get transaction for account.
        /// </summary>
        /// <param name="accountId">The Account Id.</param>
        /// <param name="args">The Args (see <see cref="Entities.TransactionArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>The <see cref="TransactionCollectionResult"/>.</returns>
        public Task<TransactionCollectionResult> GetTransactionsAsync(string? accountId, TransactionArgs? args, PagingArgs? paging)
        {
            return _cosmos.Transactions.Query(new Mac.PartitionKey(accountId), q => _getTransactionsOnQuery?.Invoke(q, accountId, args) ?? q).WithPaging(paging).SelectResultAsync<TransactionCollectionResult, TransactionCollection>();
        }

        /// <summary>
        /// Provides the <see cref="Transaction"/> to Entity Framework <see cref="Model.Transaction"/> mapping.
        /// </summary>
        public partial class EntityToModelCosmosMapper : Mapper<Transaction, Model.Transaction>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="EntityToModelCosmosMapper"/> class.
            /// </summary>
            public EntityToModelCosmosMapper()
            {
                Map((s, d) => d.Id = s.Id, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
                Map((s, d) => d.AccountId = s.AccountId, OperationTypes.Any, s => s.AccountId == default, d => d.AccountId = default);
                Map((s, d) => d.IsDetailAvailable = s.IsDetailAvailable, OperationTypes.Any, s => s.IsDetailAvailable == default, d => d.IsDetailAvailable = default);
                Map((s, d) => d.Type = s.TypeSid, OperationTypes.Any, s => s.TypeSid == default, d => d.Type = default);
                Map((s, d) => d.Status = s.StatusSid, OperationTypes.Any, s => s.StatusSid == default, d => d.Status = default);
                Map((s, d) => d.Description = s.Description, OperationTypes.Any, s => s.Description == default, d => d.Description = default);
                Map((s, d) => d.PostingDateTime = s.PostingDateTime, OperationTypes.Any, s => s.PostingDateTime == default, d => d.PostingDateTime = default);
                Map((s, d) => d.ExecutionDateTime = s.ExecutionDateTime, OperationTypes.Any, s => s.ExecutionDateTime == default, d => d.ExecutionDateTime = default);
                Map((s, d) => d.Amount = s.Amount, OperationTypes.Any, s => s.Amount == default, d => d.Amount = default);
                Map((s, d) => d.Currency = s.Currency, OperationTypes.Any, s => s.Currency == default, d => d.Currency = default);
                Map((s, d) => d.Reference = s.Reference, OperationTypes.Any, s => s.Reference == default, d => d.Reference = default);
                Map((s, d) => d.MerchantName = s.MerchantName, OperationTypes.Any, s => s.MerchantName == default, d => d.MerchantName = default);
                Map((s, d) => d.MerchantCategoryCode = s.MerchantCategoryCode, OperationTypes.Any, s => s.MerchantCategoryCode == default, d => d.MerchantCategoryCode = default);
                Map((s, d) => d.BillerCode = s.BillerCode, OperationTypes.Any, s => s.BillerCode == default, d => d.BillerCode = default);
                Map((s, d) => d.BillerName = s.BillerName, OperationTypes.Any, s => s.BillerName == default, d => d.BillerName = default);
                Map((s, d) => d.ApcaNumber = s.ApcaNumber, OperationTypes.Any, s => s.ApcaNumber == default, d => d.ApcaNumber = default);
                EntityToModelCosmosMapperCtor();
            }

            partial void EntityToModelCosmosMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the Entity Framework <see cref="Model.Transaction"/> to <see cref="Transaction"/> mapping.
        /// </summary>
        public partial class ModelToEntityCosmosMapper : Mapper<Model.Transaction, Transaction>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ModelToEntityCosmosMapper"/> class.
            /// </summary>
            public ModelToEntityCosmosMapper()
            {
                Map((s, d) => d.Id = (string?)s.Id, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
                Map((s, d) => d.AccountId = (string?)s.AccountId, OperationTypes.Any, s => s.AccountId == default, d => d.AccountId = default);
                Map((s, d) => d.IsDetailAvailable = (bool)s.IsDetailAvailable, OperationTypes.Any, s => s.IsDetailAvailable == default, d => d.IsDetailAvailable = default);
                Map((s, d) => d.TypeSid = (string?)s.Type, OperationTypes.Any, s => s.Type == default, d => d.TypeSid = default);
                Map((s, d) => d.StatusSid = (string?)s.Status, OperationTypes.Any, s => s.Status == default, d => d.StatusSid = default);
                Map((s, d) => d.Description = (string?)s.Description, OperationTypes.Any, s => s.Description == default, d => d.Description = default);
                Map((s, d) => d.PostingDateTime = (DateTime)s.PostingDateTime, OperationTypes.Any, s => s.PostingDateTime == default, d => d.PostingDateTime = default);
                Map((s, d) => d.ExecutionDateTime = (DateTime)s.ExecutionDateTime, OperationTypes.Any, s => s.ExecutionDateTime == default, d => d.ExecutionDateTime = default);
                Map((s, d) => d.Amount = (decimal)s.Amount, OperationTypes.Any, s => s.Amount == default, d => d.Amount = default);
                Map((s, d) => d.Currency = (string?)s.Currency, OperationTypes.Any, s => s.Currency == default, d => d.Currency = default);
                Map((s, d) => d.Reference = (string?)s.Reference, OperationTypes.Any, s => s.Reference == default, d => d.Reference = default);
                Map((s, d) => d.MerchantName = (string?)s.MerchantName, OperationTypes.Any, s => s.MerchantName == default, d => d.MerchantName = default);
                Map((s, d) => d.MerchantCategoryCode = (string?)s.MerchantCategoryCode, OperationTypes.Any, s => s.MerchantCategoryCode == default, d => d.MerchantCategoryCode = default);
                Map((s, d) => d.BillerCode = (string?)s.BillerCode, OperationTypes.Any, s => s.BillerCode == default, d => d.BillerCode = default);
                Map((s, d) => d.BillerName = (string?)s.BillerName, OperationTypes.Any, s => s.BillerName == default, d => d.BillerName = default);
                Map((s, d) => d.ApcaNumber = (string?)s.ApcaNumber, OperationTypes.Any, s => s.ApcaNumber == default, d => d.ApcaNumber = default);
                ModelToEntityCosmosMapperCtor();
            }

            partial void ModelToEntityCosmosMapperCtor(); // Enables the constructor to be extended.
        }
    }
}

#pragma warning restore
#nullable restore