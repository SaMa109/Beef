/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace My.Hr.Business.DataSvc
{
    /// <summary>
    /// Provides the <see cref="Employee"/> data repository services.
    /// </summary>
    public partial class EmployeeDataSvc : IEmployeeDataSvc
    {
        private readonly IEmployeeData _data;
        private readonly IRequestCache _cache;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDataSvc"/> class.
        /// </summary>
        /// <param name="data">The <see cref="IEmployeeData"/>.</param>
        /// <param name="cache">The <see cref="IRequestCache"/>.</param>
        public EmployeeDataSvc(IEmployeeData data, IRequestCache cache)
            { _data = data ?? throw new ArgumentNullException(nameof(data)); _cache = cache ?? throw new ArgumentNullException(nameof(cache)); EmployeeDataSvcCtor(); }

        partial void EmployeeDataSvcCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="Employee"/>.
        /// </summary>
        /// <param name="id">The <see cref="Employee"/> identifier.</param>
        /// <returns>The selected <see cref="Employee"/> where found.</returns>
        public Task<Employee?> GetAsync(Guid id) => _cache.GetOrAddAsync(id, () => _data.GetAsync(id));

        /// <summary>
        /// Creates a new <see cref="Employee"/>.
        /// </summary>
        /// <param name="value">The <see cref="Employee"/>.</param>
        /// <returns>The created <see cref="Employee"/>.</returns>
        public async Task<Employee> CreateAsync(Employee value)
        {
            var __result = await _data.CreateAsync(value ?? throw new ArgumentNullException(nameof(value))).ConfigureAwait(false);
            return _cache.SetValue(__result);
        }

        /// <summary>
        /// Updates an existing <see cref="Employee"/>.
        /// </summary>
        /// <param name="value">The <see cref="Employee"/>.</param>
        /// <returns>The updated <see cref="Employee"/>.</returns>
        public async Task<Employee> UpdateAsync(Employee value)
        {
            var __result = await _data.UpdateAsync(value ?? throw new ArgumentNullException(nameof(value))).ConfigureAwait(false);
            return _cache.SetValue(__result);
        }

        /// <summary>
        /// Deletes the specified <see cref="Employee"/>.
        /// </summary>
        /// <param name="id">The Id.</param>
        public async Task DeleteAsync(Guid id)
        {
            _cache.Remove<Employee>(id);
            await _data.DeleteAsync(id).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the <see cref="EmployeeBaseCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="Entities.EmployeeArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>The <see cref="EmployeeBaseCollectionResult"/>.</returns>
        public Task<EmployeeBaseCollectionResult> GetByArgsAsync(EmployeeArgs? args, PagingArgs? paging) => _data.GetByArgsAsync(args, paging);

        /// <summary>
        /// Terminates an existing <see cref="Employee"/>.
        /// </summary>
        /// <param name="value">The <see cref="TerminationDetail"/>.</param>
        /// <param name="id">The <see cref="Employee"/> identifier.</param>
        /// <returns>The updated <see cref="Employee"/>.</returns>
        public async Task<Employee> TerminateAsync(TerminationDetail value, Guid id)
        {
            var __result = await _data.TerminateAsync(value ?? throw new ArgumentNullException(nameof(value)), id).ConfigureAwait(false);
            return _cache.SetValue(__result);
        }
    }
}

#pragma warning restore
#nullable restore