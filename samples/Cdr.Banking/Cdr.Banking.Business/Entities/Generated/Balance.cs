/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Cdr.Banking.Business.Entities
{
    /// <summary>
    /// Represents the Balance entity.
    /// </summary>
    public partial class Balance : EntityBase<Balance>, IIdentifier<string>
    {
        private string? _id;
        private decimal _currentBalance;
        private decimal _availableBalance;
        private decimal _creditLimit;
        private decimal _amortisedLimit;
        private string? _currency;
        private BalancePurseCollection? _purses;

        /// <summary>
        /// Gets or sets the <see cref="Account"/> identifier.
        /// </summary>
        [JsonPropertyName("accountId")]
        public string? Id { get => _id; set => SetValue(ref _id, value); }

        /// <summary>
        /// Gets or sets the Current Balance.
        /// </summary>
        public decimal CurrentBalance { get => _currentBalance; set => SetValue(ref _currentBalance, value); }

        /// <summary>
        /// Gets or sets the Available Balance.
        /// </summary>
        public decimal AvailableBalance { get => _availableBalance; set => SetValue(ref _availableBalance, value); }

        /// <summary>
        /// Gets or sets the Credit Limit.
        /// </summary>
        public decimal CreditLimit { get => _creditLimit; set => SetValue(ref _creditLimit, value); }

        /// <summary>
        /// Gets or sets the Amortised Limit.
        /// </summary>
        public decimal AmortisedLimit { get => _amortisedLimit; set => SetValue(ref _amortisedLimit, value); }

        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        public string? Currency { get => _currency; set => SetValue(ref _currency, value); }

        /// <summary>
        /// Gets or sets the Purses.
        /// </summary>
        public BalancePurseCollection? Purses { get => _purses; set => SetValue(ref _purses, value); }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(Id, v => Id = v);
            yield return CreateProperty(CurrentBalance, v => CurrentBalance = v);
            yield return CreateProperty(AvailableBalance, v => AvailableBalance = v);
            yield return CreateProperty(CreditLimit, v => CreditLimit = v);
            yield return CreateProperty(AmortisedLimit, v => AmortisedLimit = v);
            yield return CreateProperty(Currency, v => Currency = v);
            yield return CreateProperty(Purses, v => Purses = v);
        }
    }
}

#pragma warning restore
#nullable restore