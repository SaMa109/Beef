/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Entities
{
    /// <summary>
    /// Represents the Company entity.
    /// </summary>
    public partial class Company : ReferenceDataBaseEx<Guid, Company>
    {

        /// <summary>
        /// Gets or sets the External Code.
        /// </summary>
        public string? ExternalCode
        {
            get => GetMapping<string?>(nameof(ExternalCode));
            set { var __externalCode = ExternalCode; SetValue(ref __externalCode, value); SetMapping(nameof(ExternalCode), __externalCode!); }
        }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            foreach (var pv in base.GetPropertyValues())
                yield return pv;

            yield return CreateProperty(nameof(ExternalCode), ExternalCode, v => ExternalCode = v);
        }

        /// <summary>
        /// An implicit cast from a <see cref="IReferenceData.Code"> to a <see cref="Company"/>.
        /// </summary>
        /// <param name="code">The <b>Code</b>.</param>
        /// <returns>The corresponding <see cref="Company"/>.</returns>
        public static implicit operator Company?(string? code) => ConvertFromCode(code);
    }

    /// <summary>
    /// Represents the <see cref="Company"/> collection.
    /// </summary>
    public partial class CompanyCollection : ReferenceDataCollectionBase<Guid, Company, CompanyCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyCollection"/> class.
        /// </summary>
        public CompanyCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public CompanyCollection(IEnumerable<Company> items) => AddRange(items);
    }
}

#pragma warning restore
#nullable restore