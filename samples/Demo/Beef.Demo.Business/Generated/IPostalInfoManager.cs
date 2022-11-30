/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business
{
    /// <summary>
    /// Defines the <see cref="PostalInfo"/> business functionality.
    /// </summary>
    public partial interface IPostalInfoManager
    {
        /// <summary>
        /// Gets the specified <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        /// <returns>The selected <see cref="PostalInfo"/> where found.</returns>
        Task<PostalInfo?> GetPostCodesAsync(RefDataNamespace.Country? country, string? state, string? city);

        /// <summary>
        /// Creates a new <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="value">The <see cref="PostalInfo"/>.</param>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        /// <returns>The created <see cref="PostalInfo"/>.</returns>
        Task<PostalInfo> CreatePostCodesAsync(PostalInfo value, RefDataNamespace.Country? country, string? state, string? city);

        /// <summary>
        /// Updates an existing <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="value">The <see cref="PostalInfo"/>.</param>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        /// <returns>The updated <see cref="PostalInfo"/>.</returns>
        Task<PostalInfo> UpdatePostCodesAsync(PostalInfo value, RefDataNamespace.Country? country, string? state, string? city);

        /// <summary>
        /// Deletes the specified <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        Task DeletePostCodesAsync(RefDataNamespace.Country? country, string? state, string? city);
    }
}

#pragma warning restore
#nullable restore