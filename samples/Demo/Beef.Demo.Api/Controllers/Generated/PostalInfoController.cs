/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Api.Controllers
{
    /// <summary>
    /// Provides the <see cref="PostalInfo"/> Web API functionality.
    /// </summary>
    [Route("api/v1/postal")]
    [Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
    public partial class PostalInfoController : ControllerBase
    {
        private readonly WebApi _webApi;
        private readonly IPostalInfoManager _manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="PostalInfoController"/> class.
        /// </summary>
        /// <param name="webApi">The <see cref="WebApi"/>.</param>
        /// <param name="manager">The <see cref="IPostalInfoManager"/>.</param>
        public PostalInfoController(WebApi webApi, IPostalInfoManager manager)
            { _webApi = webApi ?? throw new ArgumentNullException(nameof(webApi)); _manager = manager ?? throw new ArgumentNullException(nameof(manager)); PostalInfoControllerCtor(); }

        partial void PostalInfoControllerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        /// <returns>The selected <see cref="PostalInfo"/> where found.</returns>
        [HttpGet("{country}/{state}/{city}")]
        [ProducesResponseType(typeof(Common.Entities.PostalInfo), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public Task<IActionResult> GetPostCodes(string? country, string? state, string? city) =>
            _webApi.GetAsync<PostalInfo?>(Request, p => _manager.GetPostCodesAsync(country, state, city));

        /// <summary>
        /// Creates a new <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        /// <returns>The created <see cref="PostalInfo"/>.</returns>
        [HttpPost("{country}/{state}/{city}")]
        [AcceptsBody(typeof(Common.Entities.PostalInfo))]
        [ProducesResponseType(typeof(Common.Entities.PostalInfo), (int)HttpStatusCode.Created)]
        public Task<IActionResult> CreatePostCodes(string? country, string? state, string? city) =>
            _webApi.PostAsync<PostalInfo, PostalInfo>(Request, p => _manager.CreatePostCodesAsync(p.Value!, country, state, city), statusCode: HttpStatusCode.Created);

        /// <summary>
        /// Updates an existing <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        /// <returns>The updated <see cref="PostalInfo"/>.</returns>
        [HttpPut("{country}/{state}/{city}")]
        [AcceptsBody(typeof(Common.Entities.PostalInfo))]
        [ProducesResponseType(typeof(Common.Entities.PostalInfo), (int)HttpStatusCode.OK)]
        public Task<IActionResult> UpdatePostCodes(string? country, string? state, string? city) =>
            _webApi.PutAsync<PostalInfo>(Request, get: _ => _manager.GetPostCodesAsync(country, state, city), put: p => _manager.UpdatePostCodesAsync(p.Value!, country, state, city), simulatedConcurrency: true);

        /// <summary>
        /// Patches an existing <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        /// <returns>The patched <see cref="PostalInfo"/>.</returns>
        [HttpPatch("{country}/{state}/{city}")]
        [AcceptsBody(typeof(Common.Entities.PostalInfo), HttpConsts.MergePatchMediaTypeName)]
        [ProducesResponseType(typeof(Common.Entities.PostalInfo), (int)HttpStatusCode.OK)]
        public Task<IActionResult> PatchPostCodes(string? country, string? state, string? city) =>
            _webApi.PatchAsync<PostalInfo>(Request, get: _ => _manager.GetPostCodesAsync(country, state, city), put: p => _manager.UpdatePostCodesAsync(p.Value!, country, state, city), simulatedConcurrency: true);

        /// <summary>
        /// Deletes the specified <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        [HttpDelete("{country}/{state}/{city}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> DeletePostCodes(string? country, string? state, string? city) =>
            _webApi.DeleteAsync(Request, p => _manager.DeletePostCodesAsync(country, state, city));
    }
}

#pragma warning restore
#nullable restore