/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace My.Hr.Business.Data
{
    /// <summary>
    /// Provides the <see cref="EmployeeBase"/> data access.
    /// </summary>
    public partial class EmployeeBaseData
    {

        /// <summary>
        /// Provides the <see cref="EmployeeBase"/> property and database column mapping.
        /// </summary>
        public partial class DbMapper : DatabaseMapper<EmployeeBase, DbMapper>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DbMapper"/> class.
            /// </summary>
            public DbMapper()
            {
                Property(s => s.Id, "EmployeeId").SetPrimaryKey(true);
                Property(s => s.Email);
                Property(s => s.FirstName);
                Property(s => s.LastName);
                Property(s => s.GenderSid, "GenderCode");
                Property(s => s.Birthday);
                Property(s => s.StartDate);
                Property(s => s.Termination).SetMapper(TerminationDetailData.DbMapper.Default!);
                Property(s => s.PhoneNo);
                DbMapperCtor();
            }
            
            partial void DbMapperCtor(); // Enables the DbMapper constructor to be extended.
        }

        /// <summary>
        /// Provides the <see cref="EmployeeBase"/> and Entity Framework <see cref="EfModel.Employee"/> <i>AutoMapper</i> mapping.
        /// </summary>
        public partial class EfMapperProfile : AutoMapper.Profile
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="EfMapperProfile"/> class.
            /// </summary>
            public EfMapperProfile()
            {
                var s2d = CreateMap<EmployeeBase, EfModel.Employee>();
                s2d.ForMember(d => d.EmployeeId, o => o.MapFrom(s => s.Id));
                s2d.ForMember(d => d.Email, o => o.MapFrom(s => s.Email));
                s2d.ForMember(d => d.FirstName, o => o.MapFrom(s => s.FirstName));
                s2d.ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName));
                s2d.ForMember(d => d.GenderCode, o => o.MapFrom(s => s.GenderSid));
                s2d.ForMember(d => d.Birthday, o => o.MapFrom(s => s.Birthday));
                s2d.ForMember(d => d.StartDate, o => o.MapFrom(s => s.StartDate));
                s2d.ForMember(d => d.PhoneNo, o => o.MapFrom(s => s.PhoneNo));

                var d2s = CreateMap<EfModel.Employee, EmployeeBase>();
                d2s.ForMember(s => s.Id, o => o.MapFrom(d => d.EmployeeId));
                d2s.ForMember(s => s.Email, o => o.MapFrom(d => d.Email));
                d2s.ForMember(s => s.FirstName, o => o.MapFrom(d => d.FirstName));
                d2s.ForMember(s => s.LastName, o => o.MapFrom(d => d.LastName));
                d2s.ForMember(s => s.GenderSid, o => o.MapFrom(d => d.GenderCode));
                d2s.ForMember(s => s.Birthday, o => o.MapFrom(d => d.Birthday));
                d2s.ForMember(s => s.StartDate, o => o.MapFrom(d => d.StartDate));
                d2s.ForMember(s => s.PhoneNo, o => o.MapFrom(d => d.PhoneNo));

                EfMapperProfileCtor(s2d, d2s);
            }

            partial void EfMapperProfileCtor(AutoMapper.IMappingExpression<EmployeeBase, EfModel.Employee> s2d, AutoMapper.IMappingExpression<EfModel.Employee, EmployeeBase> d2s); // Enables the constructor to be extended.
        }
    }
}

#pragma warning restore
#nullable restore