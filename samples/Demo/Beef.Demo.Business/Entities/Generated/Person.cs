/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Entities
{
    /// <summary>
    /// Represents the Person entity.
    /// </summary>
    public partial class Person : EntityBase, IIdentifier<Guid>, IPartitionKey, IETag, IChangeLogEx
    {
        private Guid _id;
        private string? _firstName;
        private string? _lastName;
        private string? _uniqueCode;
        private string? _genderSid;
        private string? _eyeColorSid;
        private DateTime _birthday;
        private Address? _address;
        private string? _etag;
        private Dictionary<string, string>? _metadata;
        private ChangeLogEx? _changeLog;

        /// <summary>
        /// Gets or sets the <see cref="Person"/> identifier.
        /// </summary>
        [System.Xml.Serialization.XmlElement("Id")]
        public Guid Id { get => _id; set => SetValue(ref _id, value); }

        /// <summary>
        /// Gets or sets the First Name.
        /// </summary>
        public string? FirstName { get => _firstName; set => SetValue(ref _firstName, value); }

        /// <summary>
        /// Gets or sets the Last Name.
        /// </summary>
        public string? LastName { get => _lastName; set => SetValue(ref _lastName, value); }

        /// <summary>
        /// Gets or sets the Unique Code.
        /// </summary>
        public string? UniqueCode { get => _uniqueCode; set => SetValue(ref _uniqueCode, value); }

        /// <summary>
        /// Gets or sets the <see cref="Gender"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonPropertyName("gender")]
        public string? GenderSid { get => _genderSid; set => SetValue(ref _genderSid, value, propertyName: nameof(Gender)); }

        /// <summary>
        /// Gets the corresponding <see cref="Gender"/> text (read-only where selected).
        /// </summary>
        public string? GenderText => RefDataNamespace.Gender.GetRefDataText(_genderSid);

        /// <summary>
        /// Gets or sets the Gender (see <see cref="RefDataNamespace.Gender"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [JsonIgnore]
        public RefDataNamespace.Gender? Gender { get => _genderSid; set => SetValue(ref _genderSid, value); }

        /// <summary>
        /// Gets or sets the <see cref="EyeColor"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonPropertyName("eyeColor")]
        public string? EyeColorSid { get => _eyeColorSid; set => SetValue(ref _eyeColorSid, value, propertyName: nameof(EyeColor)); }

        /// <summary>
        /// Gets the corresponding <see cref="EyeColor"/> text (read-only where selected).
        /// </summary>
        public string? EyeColorText => RefDataNamespace.EyeColor.GetRefDataText(_eyeColorSid);

        /// <summary>
        /// Gets or sets the Eye Color (see <see cref="RefDataNamespace.EyeColor"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [JsonIgnore]
        public RefDataNamespace.EyeColor? EyeColor { get => _eyeColorSid; set => SetValue(ref _eyeColorSid, value); }

        /// <summary>
        /// Gets or sets the Birthday.
        /// </summary>
        public DateTime Birthday { get => _birthday; set => SetValue(ref _birthday, value, transform: DateTimeTransform.DateOnly); }

        /// <summary>
        /// Gets or sets the Address (see <see cref="Business.Entities.Address"/>).
        /// </summary>
        public Address? Address { get => _address; set => SetValue(ref _address, value); }

        /// <summary>
        /// Gets or sets the ETag.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? ETag { get => _etag; set => SetValue(ref _etag, value); }

        /// <summary>
        /// Gets or sets the Metadata.
        /// </summary>
        public Dictionary<string, string>? Metadata { get => _metadata; set => SetValue(ref _metadata, value); }

        /// <summary>
        /// Gets or sets the Change Log (see <see cref="CoreEx.Entities.ChangeLog"/>).
        /// </summary>
        public ChangeLogEx? ChangeLog { get => _changeLog; set => SetValue(ref _changeLog, value); }

        /// <summary>
        /// Creates the <see cref="IPartitionKey.PartitionKey"/>.
        /// </summary>
        /// <returns>The Partition Key.</returns>
        /// <param name="eyeColor">The <see cref="EyeColor"/>.</param>
        public static string CreatePartitionKey(string? eyeColorSid) => CompositeKey.Create(eyeColorSid).ToString();

        /// <summary>
        /// Gets the Partition Key (consists of the following property(s): <see cref="EyeColor"/>).
        /// </summary>
        [JsonIgnore]
        public string PartitionKey => CreatePartitionKey(EyeColorSid);

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(nameof(Id), Id, v => Id = v);
            yield return CreateProperty(nameof(FirstName), FirstName, v => FirstName = v);
            yield return CreateProperty(nameof(LastName), LastName, v => LastName = v);
            yield return CreateProperty(nameof(UniqueCode), UniqueCode, v => UniqueCode = v);
            yield return CreateProperty(nameof(GenderSid), GenderSid, v => GenderSid = v);
            yield return CreateProperty(nameof(EyeColorSid), EyeColorSid, v => EyeColorSid = v);
            yield return CreateProperty(nameof(Birthday), Birthday, v => Birthday = v);
            yield return CreateProperty(nameof(Address), Address, v => Address = v);
            yield return CreateProperty(nameof(ETag), ETag, v => ETag = v);
            yield return CreateProperty(nameof(Metadata), Metadata, v => Metadata = v);
            yield return CreateProperty(nameof(ChangeLog), ChangeLog, v => ChangeLog = v);
        }
    }

    /// <summary>
    /// Represents the <see cref="Person"/> collection.
    /// </summary>
    public partial class PersonCollection : EntityBaseCollection<Person, PersonCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollection"/> class.
        /// </summary>
        public PersonCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public PersonCollection(IEnumerable<Person> items) => AddRange(items);
    }

    /// <summary>
    /// Represents the <see cref="Person"/> collection result.
    /// </summary>
    public class PersonCollectionResult : EntityCollectionResult<PersonCollection, Person, PersonCollectionResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollectionResult"/> class.
        /// </summary>
        public PersonCollectionResult() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollectionResult"/> class with <paramref name="paging"/>.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public PersonCollectionResult(PagingArgs? paging) : base(paging) { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollectionResult"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        /// <param name="paging">The optional <see cref="PagingArgs"/>.</param>
        public PersonCollectionResult(IEnumerable<Person> items, PagingArgs? paging = null) : base(paging) => Items.AddRange(items);
    }
}

#pragma warning restore
#nullable restore