/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Cdr.Banking.Business.Data.Model
{
    /// <summary>
    /// Represents the Balance model.
    /// </summary>
    public partial class Balance
    {
        /// <summary>
        /// Gets or sets the Current Balance.
        /// </summary>
        public decimal CurrentBalance { get; set; }

        /// <summary>
        /// Gets or sets the Available Balance.
        /// </summary>
        public decimal AvailableBalance { get; set; }

        /// <summary>
        /// Gets or sets the Credit Limit.
        /// </summary>
        public decimal CreditLimit { get; set; }

        /// <summary>
        /// Gets or sets the Amortised Limit.
        /// </summary>
        public decimal AmortisedLimit { get; set; }

        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        public string? Currency { get; set; }

        /// <summary>
        /// Gets or sets the Purses.
        /// </summary>
        public BalancePurseCollection? Purses { get; set; }
    }
}

#pragma warning restore
#nullable restore