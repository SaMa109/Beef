/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Cdr.Banking.Business.Entities
{
    /// <summary>
    /// Represents the Balance Purse entity.
    /// </summary>
    public partial class BalancePurse : EntityBase
    {
        private decimal _amount;
        private string? _currency;

        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        public decimal Amount { get => _amount; set => SetValue(ref _amount, value); }

        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        public string? Currency { get => _currency; set => SetValue(ref _currency, value); }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(nameof(Amount), Amount, v => Amount = v);
            yield return CreateProperty(nameof(Currency), Currency, v => Currency = v);
        }
    }

    /// <summary>
    /// Represents the <see cref="BalancePurse"/> collection.
    /// </summary>
    public partial class BalancePurseCollection : EntityBaseCollection<BalancePurse, BalancePurseCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalancePurseCollection"/> class.
        /// </summary>
        public BalancePurseCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalancePurseCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public BalancePurseCollection(IEnumerable<BalancePurse> items) => AddRange(items);
    }
}

#pragma warning restore
#nullable restore