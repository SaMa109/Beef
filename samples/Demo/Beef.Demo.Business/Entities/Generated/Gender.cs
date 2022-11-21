/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Entities
{
    /// <summary>
    /// Represents the Gender entity.
    /// </summary>
    public partial class Gender : ReferenceDataBaseEx<Guid, Gender>
    {
        /// <summary>
        /// Represents a Female constant value.
        /// </summary>
        public const string Female = "F";

        /// <summary>
        /// Represents a Male constant value.
        /// </summary>
        public const string Male = "M";

        private string? _alternateName;
        private string? _countrySid;

        /// <summary>
        /// Gets or sets the Alternate Name.
        /// </summary>
        public string? AlternateName { get => _alternateName; set => SetValue(ref _alternateName, value); }

        /// <summary>
        /// Gets or sets the Trip OData Code.
        /// </summary>
        [JsonIgnore]
        public string? TripCode
        {
            get => GetMapping<string?>(nameof(TripCode));
            set { var __tripCode = TripCode; SetValue(ref __tripCode, value); SetMapping(nameof(TripCode), __tripCode!); }
        }

        /// <summary>
        /// Gets or sets the <see cref="Country"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonPropertyName("country")]
        public string? CountrySid { get => _countrySid; set => SetValue(ref _countrySid, value); }

        /// <summary>
        /// Gets or sets the Country (see <see cref="RefDataNamespace.Country"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [JsonIgnore]
        public RefDataNamespace.Country? Country { get => _countrySid; set => SetValue(ref _countrySid, value); }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            foreach (var pv in base.GetPropertyValues())
                yield return pv;

            yield return CreateProperty(nameof(AlternateName), AlternateName, v => AlternateName = v);
            yield return CreateProperty(nameof(TripCode), TripCode, v => TripCode = v);
            yield return CreateProperty(nameof(CountrySid), CountrySid, v => CountrySid = v);
        }

        /// <summary>
        /// An implicit cast from a <see cref="IReferenceData.Code"> to a <see cref="Gender"/>.
        /// </summary>
        /// <param name="code">The <b>Code</b>.</param>
        /// <returns>The corresponding <see cref="Gender"/>.</returns>
        public static implicit operator Gender?(string? code) => ConvertFromCode(code);
    }

    /// <summary>
    /// Represents the <see cref="Gender"/> collection.
    /// </summary>
    public partial class GenderCollection : ReferenceDataCollectionBase<Guid, Gender, GenderCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenderCollection"/> class.
        /// </summary>
        public GenderCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenderCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public GenderCollection(IEnumerable<Gender> items) => AddRange(items);
    }
}

#pragma warning restore
#nullable restore