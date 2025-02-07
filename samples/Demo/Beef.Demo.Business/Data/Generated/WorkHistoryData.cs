/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Data
{
    /// <summary>
    /// Provides the <see cref="WorkHistory"/> data access.
    /// </summary>
    public partial class WorkHistoryData
    {

        /// <summary>
        /// Provides the <see cref="WorkHistory"/> property and database column mapping.
        /// </summary>
        public partial class DbMapper : DatabaseMapper<WorkHistory, DbMapper>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DbMapper"/> class.
            /// </summary>
            public DbMapper()
            {
                Property(s => s.PersonId);
                Property(s => s.Name).SetPrimaryKey(false);
                Property(s => s.StartDate);
                Property(s => s.EndDate);
                DbMapperCtor();
            }
            
            partial void DbMapperCtor(); // Enables the DbMapper constructor to be extended.
        }
    }
}

#pragma warning restore
#nullable restore