/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Entities
{
    /// <summary>
    /// Represents the Address entity.
    /// </summary>
    public partial class Address : EntityBase
    {
        private string? _street;
        private string? _city;

        /// <summary>
        /// Gets or sets the Street.
        /// </summary>
        public string? Street { get => _street; set => SetValue(ref _street, value); }

        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        public string? City { get => _city; set => SetValue(ref _city, value); }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(nameof(Street), Street, v => Street = v);
            yield return CreateProperty(nameof(City), City, v => City = v);
        }
    }

    /// <summary>
    /// Represents the <see cref="Address"/> collection.
    /// </summary>
    public partial class AddressCollection : EntityBaseCollection<Address, AddressCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressCollection"/> class.
        /// </summary>
        public AddressCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public AddressCollection(IEnumerable<Address> items) => AddRange(items);
    }
}

#pragma warning restore
#nullable restore