/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.DataSvc
{
    /// <summary>
    /// Provides the <see cref="Gender"/> data repository services.
    /// </summary>
    public partial class GenderDataSvc : IGenderDataSvc
    {
        private readonly IGenderData _data;
        private readonly IEventPublisher _events;
        private readonly IRequestCache _cache;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenderDataSvc"/> class.
        /// </summary>
        /// <param name="data">The <see cref="IGenderData"/>.</param>
        /// <param name="events">The <see cref="IEventPublisher"/>.</param>
        /// <param name="cache">The <see cref="IRequestCache"/>.</param>
        public GenderDataSvc(IGenderData data, IEventPublisher events, IRequestCache cache)
            { _data = data ?? throw new ArgumentNullException(nameof(data)); _events = events ?? throw new ArgumentNullException(nameof(events)); _cache = cache ?? throw new ArgumentNullException(nameof(cache)); GenderDataSvcCtor(); }

        partial void GenderDataSvcCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="Gender"/>.
        /// </summary>
        /// <param name="id">The <see cref="Gender"/> identifier.</param>
        /// <returns>The selected <see cref="Gender"/> where found.</returns>
        public Task<Gender?> GetAsync(Guid id) => _cache.GetOrAddAsync(id, () => _data.GetAsync(id));

        /// <summary>
        /// Creates a new <see cref="Gender"/>.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/>.</param>
        /// <returns>The created <see cref="Gender"/>.</returns>
        public Task<Gender> CreateAsync(Gender value) => DataSvcInvoker.Current.InvokeAsync(this, async _ =>
        {
            var __result = await _data.CreateAsync(value ?? throw new ArgumentNullException(nameof(value))).ConfigureAwait(false);
            _events.PublishValueEvent(__result, $"Demo.Gender", "Create");
            return _cache.SetValue(__result);
        }, new InvokerArgs { EventPublisher = _events });

        /// <summary>
        /// Updates an existing <see cref="Gender"/>.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/>.</param>
        /// <returns>The updated <see cref="Gender"/>.</returns>
        public Task<Gender> UpdateAsync(Gender value) => DataSvcInvoker.Current.InvokeAsync(this, async _ =>
        {
            var __result = await _data.UpdateAsync(value ?? throw new ArgumentNullException(nameof(value))).ConfigureAwait(false);
            _events.PublishValueEvent(__result, $"Demo.Gender", "Update");
            return _cache.SetValue(__result);
        }, new InvokerArgs { EventPublisher = _events });
    }
}

#pragma warning restore
#nullable restore