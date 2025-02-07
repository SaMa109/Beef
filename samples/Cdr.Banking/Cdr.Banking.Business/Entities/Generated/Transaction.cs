/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Cdr.Banking.Business.Entities
{
    /// <summary>
    /// Represents the Transaction entity.
    /// </summary>
    public partial class Transaction : EntityBase, IIdentifier<string>
    {
        private string? _id;
        private string? _accountId;
        private bool _isDetailAvailable;
        private string? _typeSid;
        private string? _statusSid;
        private string? _description;
        private DateTime _postingDateTime;
        private DateTime _executionDateTime;
        private decimal _amount;
        private string? _currency;
        private string? _reference;
        private string? _merchantName;
        private string? _merchantCategoryCode;
        private string? _billerCode;
        private string? _billerName;
        private string? _apcaNumber;

        /// <summary>
        /// Gets or sets the <see cref="Account"/> identifier.
        /// </summary>
        [JsonPropertyName("transactionId")]
        public string? Id { get => _id; set => SetValue(ref _id, value); }

        /// <summary>
        /// Gets or sets the Account Id.
        /// </summary>
        public string? AccountId { get => _accountId; set => SetValue(ref _accountId, value); }

        /// <summary>
        /// Indicates whether Is Detail Available.
        /// </summary>
        public bool IsDetailAvailable { get => _isDetailAvailable; set => SetValue(ref _isDetailAvailable, value); }

        /// <summary>
        /// Gets or sets the <see cref="Type"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonPropertyName("type")]
        public string? TypeSid { get => _typeSid; set => SetValue(ref _typeSid, value, propertyName: nameof(Type)); }

        /// <summary>
        /// Gets or sets the Type (see <see cref="RefDataNamespace.TransactionType"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [JsonIgnore]
        public RefDataNamespace.TransactionType? Type { get => _typeSid; set => SetValue(ref _typeSid, value); }

        /// <summary>
        /// Gets or sets the <see cref="Status"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonPropertyName("status")]
        public string? StatusSid { get => _statusSid; set => SetValue(ref _statusSid, value, propertyName: nameof(Status)); }

        /// <summary>
        /// Gets or sets the Status (see <see cref="RefDataNamespace.TransactionStatus"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [JsonIgnore]
        public RefDataNamespace.TransactionStatus? Status { get => _statusSid; set => SetValue(ref _statusSid, value); }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string? Description { get => _description; set => SetValue(ref _description, value); }

        /// <summary>
        /// Gets or sets the Posting Date Time.
        /// </summary>
        public DateTime PostingDateTime { get => _postingDateTime; set => SetValue(ref _postingDateTime, value); }

        /// <summary>
        /// Gets or sets the Execution Date Time.
        /// </summary>
        public DateTime ExecutionDateTime { get => _executionDateTime; set => SetValue(ref _executionDateTime, value); }

        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        public decimal Amount { get => _amount; set => SetValue(ref _amount, value); }

        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        public string? Currency { get => _currency; set => SetValue(ref _currency, value); }

        /// <summary>
        /// Gets or sets the Reference.
        /// </summary>
        public string? Reference { get => _reference; set => SetValue(ref _reference, value); }

        /// <summary>
        /// Gets or sets the Merchant Name.
        /// </summary>
        public string? MerchantName { get => _merchantName; set => SetValue(ref _merchantName, value); }

        /// <summary>
        /// Gets or sets the Merchant Category Code.
        /// </summary>
        public string? MerchantCategoryCode { get => _merchantCategoryCode; set => SetValue(ref _merchantCategoryCode, value); }

        /// <summary>
        /// Gets or sets the Biller Code.
        /// </summary>
        public string? BillerCode { get => _billerCode; set => SetValue(ref _billerCode, value); }

        /// <summary>
        /// Gets or sets the Biller Name.
        /// </summary>
        public string? BillerName { get => _billerName; set => SetValue(ref _billerName, value); }

        /// <summary>
        /// Gets or sets the Apca Number.
        /// </summary>
        public string? ApcaNumber { get => _apcaNumber; set => SetValue(ref _apcaNumber, value); }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(nameof(Id), Id, v => Id = v);
            yield return CreateProperty(nameof(AccountId), AccountId, v => AccountId = v);
            yield return CreateProperty(nameof(IsDetailAvailable), IsDetailAvailable, v => IsDetailAvailable = v);
            yield return CreateProperty(nameof(TypeSid), TypeSid, v => TypeSid = v);
            yield return CreateProperty(nameof(StatusSid), StatusSid, v => StatusSid = v);
            yield return CreateProperty(nameof(Description), Description, v => Description = v);
            yield return CreateProperty(nameof(PostingDateTime), PostingDateTime, v => PostingDateTime = v);
            yield return CreateProperty(nameof(ExecutionDateTime), ExecutionDateTime, v => ExecutionDateTime = v);
            yield return CreateProperty(nameof(Amount), Amount, v => Amount = v);
            yield return CreateProperty(nameof(Currency), Currency, v => Currency = v);
            yield return CreateProperty(nameof(Reference), Reference, v => Reference = v);
            yield return CreateProperty(nameof(MerchantName), MerchantName, v => MerchantName = v);
            yield return CreateProperty(nameof(MerchantCategoryCode), MerchantCategoryCode, v => MerchantCategoryCode = v);
            yield return CreateProperty(nameof(BillerCode), BillerCode, v => BillerCode = v);
            yield return CreateProperty(nameof(BillerName), BillerName, v => BillerName = v);
            yield return CreateProperty(nameof(ApcaNumber), ApcaNumber, v => ApcaNumber = v);
        }
    }

    /// <summary>
    /// Represents the <see cref="Transaction"/> collection.
    /// </summary>
    public partial class TransactionCollection : EntityBaseCollection<Transaction, TransactionCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCollection"/> class.
        /// </summary>
        public TransactionCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public TransactionCollection(IEnumerable<Transaction> items) => AddRange(items);
    }

    /// <summary>
    /// Represents the <see cref="Transaction"/> collection result.
    /// </summary>
    public class TransactionCollectionResult : EntityCollectionResult<TransactionCollection, Transaction, TransactionCollectionResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCollectionResult"/> class.
        /// </summary>
        public TransactionCollectionResult() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCollectionResult"/> class with <paramref name="paging"/>.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public TransactionCollectionResult(PagingArgs? paging) : base(paging) { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCollectionResult"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        /// <param name="paging">The optional <see cref="PagingArgs"/>.</param>
        public TransactionCollectionResult(IEnumerable<Transaction> items, PagingArgs? paging = null) : base(paging) => Items.AddRange(items);
    }
}

#pragma warning restore
#nullable restore