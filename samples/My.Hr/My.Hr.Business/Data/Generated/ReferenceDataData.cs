/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace My.Hr.Business.Data
{
    /// <summary>
    /// Provides the <b>ReferenceData</b> data access.
    /// </summary>
    public partial class ReferenceDataData : IReferenceDataData
    {
        private readonly IEfDb _ef;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceDataData"/> class.
        /// </summary>
        /// <param name="ef">The <see cref="IEfDb"/>.</param>
        public ReferenceDataData(IEfDb ef)
            { _ef = ef ?? throw new ArgumentNullException(nameof(ef)); ReferenceDataDataCtor(); }

        partial void ReferenceDataDataCtor(); // Enables additional functionality to be added to the constructor.

        /// <inheritdoc/>
        public Task<RefDataNamespace.GenderCollection> GenderGetAllAsync()
            => DataInvoker.Current.InvokeAsync(this, _ =>_ef.Query<RefDataNamespace.Gender, EfModel.Gender>().SelectQueryAsync<RefDataNamespace.GenderCollection>(), BusinessInvokerArgs.TransactionSuppress);

        /// <inheritdoc/>
        public Task<RefDataNamespace.TerminationReasonCollection> TerminationReasonGetAllAsync()
            => DataInvoker.Current.InvokeAsync(this, _ =>_ef.Query<RefDataNamespace.TerminationReason, EfModel.TerminationReason>().SelectQueryAsync<RefDataNamespace.TerminationReasonCollection>(), BusinessInvokerArgs.TransactionSuppress);

        /// <inheritdoc/>
        public Task<RefDataNamespace.RelationshipTypeCollection> RelationshipTypeGetAllAsync()
            => DataInvoker.Current.InvokeAsync(this, _ =>_ef.Query<RefDataNamespace.RelationshipType, EfModel.RelationshipType>().SelectQueryAsync<RefDataNamespace.RelationshipTypeCollection>(), BusinessInvokerArgs.TransactionSuppress);

        /// <inheritdoc/>
        public Task<RefDataNamespace.USStateCollection> USStateGetAllAsync()
            => DataInvoker.Current.InvokeAsync(this, _ =>_ef.Query<RefDataNamespace.USState, EfModel.USState>().SelectQueryAsync<RefDataNamespace.USStateCollection>(), BusinessInvokerArgs.TransactionSuppress);

        /// <inheritdoc/>
        public Task<RefDataNamespace.PerformanceOutcomeCollection> PerformanceOutcomeGetAllAsync()
            => DataInvoker.Current.InvokeAsync(this, _ =>_ef.Query<RefDataNamespace.PerformanceOutcome, EfModel.PerformanceOutcome>().SelectQueryAsync<RefDataNamespace.PerformanceOutcomeCollection>(), BusinessInvokerArgs.TransactionSuppress);

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.Gender"/> and Entity Framework <see cref="EfModel.Gender"/> <i>AutoMapper</i> mapping.
        /// </summary>
        public partial class GenderMapperProfile : AutoMapper.Profile
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="GenderMapperProfile"/> class.
            /// </summary>
            public GenderMapperProfile()
            {
                var d2s = CreateMap<EfModel.Gender, RefDataNamespace.Gender>();
                d2s.ForMember(s => s.Id, o => o.MapFrom(d => d.GenderId));
                d2s.ForMember(s => s.ETag, o => o.ConvertUsing(AutoMapperStringToBase64Converter.Default.ToSource, d => d.RowVersion));

                GenderMapperProfileCtor(d2s);
            }

            partial void GenderMapperProfileCtor(AutoMapper.IMappingExpression<EfModel.Gender, RefDataNamespace.Gender> d2s); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.TerminationReason"/> and Entity Framework <see cref="EfModel.TerminationReason"/> <i>AutoMapper</i> mapping.
        /// </summary>
        public partial class TerminationReasonMapperProfile : AutoMapper.Profile
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="TerminationReasonMapperProfile"/> class.
            /// </summary>
            public TerminationReasonMapperProfile()
            {
                var d2s = CreateMap<EfModel.TerminationReason, RefDataNamespace.TerminationReason>();
                d2s.ForMember(s => s.Id, o => o.MapFrom(d => d.TerminationReasonId));
                d2s.ForMember(s => s.ETag, o => o.ConvertUsing(AutoMapperStringToBase64Converter.Default.ToSource, d => d.RowVersion));

                TerminationReasonMapperProfileCtor(d2s);
            }

            partial void TerminationReasonMapperProfileCtor(AutoMapper.IMappingExpression<EfModel.TerminationReason, RefDataNamespace.TerminationReason> d2s); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.RelationshipType"/> and Entity Framework <see cref="EfModel.RelationshipType"/> <i>AutoMapper</i> mapping.
        /// </summary>
        public partial class RelationshipTypeMapperProfile : AutoMapper.Profile
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="RelationshipTypeMapperProfile"/> class.
            /// </summary>
            public RelationshipTypeMapperProfile()
            {
                var d2s = CreateMap<EfModel.RelationshipType, RefDataNamespace.RelationshipType>();
                d2s.ForMember(s => s.Id, o => o.MapFrom(d => d.RelationshipTypeId));
                d2s.ForMember(s => s.ETag, o => o.ConvertUsing(AutoMapperStringToBase64Converter.Default.ToSource, d => d.RowVersion));

                RelationshipTypeMapperProfileCtor(d2s);
            }

            partial void RelationshipTypeMapperProfileCtor(AutoMapper.IMappingExpression<EfModel.RelationshipType, RefDataNamespace.RelationshipType> d2s); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.USState"/> and Entity Framework <see cref="EfModel.USState"/> <i>AutoMapper</i> mapping.
        /// </summary>
        public partial class USStateMapperProfile : AutoMapper.Profile
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="USStateMapperProfile"/> class.
            /// </summary>
            public USStateMapperProfile()
            {
                var d2s = CreateMap<EfModel.USState, RefDataNamespace.USState>();
                d2s.ForMember(s => s.Id, o => o.MapFrom(d => d.USStateId));
                d2s.ForMember(s => s.ETag, o => o.ConvertUsing(AutoMapperStringToBase64Converter.Default.ToSource, d => d.RowVersion));

                USStateMapperProfileCtor(d2s);
            }

            partial void USStateMapperProfileCtor(AutoMapper.IMappingExpression<EfModel.USState, RefDataNamespace.USState> d2s); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.PerformanceOutcome"/> and Entity Framework <see cref="EfModel.PerformanceOutcome"/> <i>AutoMapper</i> mapping.
        /// </summary>
        public partial class PerformanceOutcomeMapperProfile : AutoMapper.Profile
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="PerformanceOutcomeMapperProfile"/> class.
            /// </summary>
            public PerformanceOutcomeMapperProfile()
            {
                var d2s = CreateMap<EfModel.PerformanceOutcome, RefDataNamespace.PerformanceOutcome>();
                d2s.ForMember(s => s.Id, o => o.MapFrom(d => d.PerformanceOutcomeId));
                d2s.ForMember(s => s.ETag, o => o.ConvertUsing(AutoMapperStringToBase64Converter.Default.ToSource, d => d.RowVersion));

                PerformanceOutcomeMapperProfileCtor(d2s);
            }

            partial void PerformanceOutcomeMapperProfileCtor(AutoMapper.IMappingExpression<EfModel.PerformanceOutcome, RefDataNamespace.PerformanceOutcome> d2s); // Enables the constructor to be extended.
        }
    }
}

#pragma warning restore
#nullable restore