/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace My.Hr.Business.Entities
{
    /// <summary>
    /// Represents the Address entity.
    /// </summary>
    public partial class Address : EntityBase<Address>
    {
        private string? _street1;
        private string? _street2;
        private string? _city;
        private string? _stateSid;
        private string? _stateText;
        private string? _postCode;

        /// <summary>
        /// Gets or sets the Street1.
        /// </summary>
        public string? Street1 { get => _street1; set => SetValue(ref _street1, value); }

        /// <summary>
        /// Gets or sets the Street2.
        /// </summary>
        public string? Street2 { get => _street2; set => SetValue(ref _street2, value); }

        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        public string? City { get => _city; set => SetValue(ref _city, value); }

        /// <summary>
        /// Gets or sets the <see cref="State"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonPropertyName("state")]
        public string? StateSid { get => _stateSid; set => SetValue(ref _stateSid, value); }

        /// <summary>
        /// Gets the corresponding <see cref="State"/> text (read-only where selected).
        /// </summary>
        public string? StateText => RefDataNamespace.USState.GetRefDataText(_stateSid);

        /// <summary>
        /// Gets or sets the State (see <see cref="RefDataNamespace.USState"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [JsonIgnore]
        public RefDataNamespace.USState? State { get => _stateSid; set => SetValue(ref _stateSid, value); }

        /// <summary>
        /// Gets or sets the Post Code.
        /// </summary>
        public string? PostCode { get => _postCode; set => SetValue(ref _postCode, value); }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(Street1, v => Street1 = v);
            yield return CreateProperty(Street2, v => Street2 = v);
            yield return CreateProperty(City, v => City = v);
            yield return CreateProperty(StateSid, v => StateSid = v);
            yield return CreateProperty(PostCode, v => PostCode = v);
        }
    }
}

#pragma warning restore
#nullable restore