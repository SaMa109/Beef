/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Cdr.Banking.Business.DataSvc
{
    /// <summary>
    /// Provides the <see cref="Account"/> data repository services.
    /// </summary>
    public partial class AccountDataSvc : IAccountDataSvc
    {
        private readonly IAccountData _data;
        private readonly IRequestCache _cache;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDataSvc"/> class.
        /// </summary>
        /// <param name="data">The <see cref="IAccountData"/>.</param>
        /// <param name="cache">The <see cref="IRequestCache"/>.</param>
        public AccountDataSvc(IAccountData data, IRequestCache cache)
            { _data = data ?? throw new ArgumentNullException(nameof(data)); _cache = cache ?? throw new ArgumentNullException(nameof(cache)); AccountDataSvcCtor(); }

        partial void AccountDataSvcCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Get all accounts.
        /// </summary>
        /// <param name="args">The Args (see <see cref="Entities.AccountArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>The <see cref="AccountCollectionResult"/>.</returns>
        public Task<AccountCollectionResult> GetAccountsAsync(AccountArgs? args, PagingArgs? paging) => _data.GetAccountsAsync(args, paging);

        /// <summary>
        /// Get <see cref="AccountDetail"/>.
        /// </summary>
        /// <param name="accountId">The <see cref="Account"/> identifier.</param>
        /// <returns>The selected <see cref="AccountDetail"/> where found.</returns>
        public Task<AccountDetail?> GetDetailAsync(string? accountId) => _cache.GetOrAddAsync(accountId, () => _data.GetDetailAsync(accountId));

        /// <summary>
        /// Get <see cref="Account"/> <see cref="Balance"/>.
        /// </summary>
        /// <param name="accountId">The <see cref="Account"/> identifier.</param>
        /// <returns>The selected <see cref="Balance"/> where found.</returns>
        public Task<Balance?> GetBalanceAsync(string? accountId) => _cache.GetOrAddAsync(accountId, () => _data.GetBalanceAsync(accountId));
    }
}

#pragma warning restore
#nullable restore