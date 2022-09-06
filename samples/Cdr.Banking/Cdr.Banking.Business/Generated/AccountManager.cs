/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Cdr.Banking.Business
{
    /// <summary>
    /// Provides the <see cref="Account"/> business functionality.
    /// </summary>
    public partial class AccountManager : IAccountManager
    {
        private readonly IAccountDataSvc _dataService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        /// <param name="dataService">The <see cref="IAccountDataSvc"/>.</param>
        public AccountManager(IAccountDataSvc dataService)
            { _dataService = dataService ?? throw new ArgumentNullException(nameof(dataService)); AccountManagerCtor(); }

        partial void AccountManagerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Get all accounts.
        /// </summary>
        /// <param name="args">The Args (see <see cref="Entities.AccountArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>The <see cref="AccountCollectionResult"/>.</returns>
        public Task<AccountCollectionResult> GetAccountsAsync(AccountArgs? args, PagingArgs? paging) => ManagerInvoker.Current.InvokeAsync(this, async _ =>
        {
            Cleaner.CleanUp(args);
            (await args.Validate(nameof(args)).Entity().With<IValidatorEx<AccountArgs>>().ValidateAsync().ConfigureAwait(false)).ThrowOnError();
            return Cleaner.Clean(await _dataService.GetAccountsAsync(args, paging).ConfigureAwait(false));
        }, BusinessInvokerArgs.Read);

        /// <summary>
        /// Get <see cref="AccountDetail"/>.
        /// </summary>
        /// <param name="accountId">The <see cref="Account"/> identifier.</param>
        /// <returns>The selected <see cref="AccountDetail"/> where found.</returns>
        public Task<AccountDetail?> GetDetailAsync(string? accountId) => ManagerInvoker.Current.InvokeAsync(this, async _ =>
        {
            Cleaner.CleanUp(accountId);
            (await accountId.Validate(nameof(accountId)).Mandatory().ValidateAsync().ConfigureAwait(false)).ThrowOnError();
            return Cleaner.Clean(await _dataService.GetDetailAsync(accountId).ConfigureAwait(false));
        }, BusinessInvokerArgs.Read);

        /// <summary>
        /// Get <see cref="Account"/> <see cref="Balance"/>.
        /// </summary>
        /// <param name="accountId">The <see cref="Account"/> identifier.</param>
        /// <returns>The selected <see cref="Balance"/> where found.</returns>
        public Task<Balance?> GetBalanceAsync(string? accountId) => ManagerInvoker.Current.InvokeAsync(this, async _ =>
        {
            Cleaner.CleanUp(accountId);
            (await accountId.Validate(nameof(accountId)).Mandatory().ValidateAsync().ConfigureAwait(false)).ThrowOnError();
            return Cleaner.Clean(await _dataService.GetBalanceAsync(accountId).ConfigureAwait(false));
        }, BusinessInvokerArgs.Read);
    }
}

#pragma warning restore
#nullable restore