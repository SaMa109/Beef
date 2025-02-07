/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace My.Hr.Business.Data.EfModel
{
    /// <summary>
    /// Represents the Entity Framework (EF) model for database object '[Hr].[PerformanceReview]'.
    /// </summary>
    public partial class PerformanceReview
    {
        /// <summary>
        /// Gets or sets the 'PerformanceReviewId' column value.
        /// </summary>
        public Guid PerformanceReviewId { get; set; }

        /// <summary>
        /// Gets or sets the 'EmployeeId' column value.
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the 'Date' column value.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets the 'PerformanceOutcomeCode' column value.
        /// </summary>
        public string? PerformanceOutcomeCode { get; set; }

        /// <summary>
        /// Gets or sets the 'Reviewer' column value.
        /// </summary>
        public string? Reviewer { get; set; }

        /// <summary>
        /// Gets or sets the 'Notes' column value.
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the 'RowVersion' column value.
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Gets or sets the 'CreatedBy' column value.
        /// </summary>
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the 'CreatedDate' column value.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the 'UpdatedBy' column value.
        /// </summary>
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the 'UpdatedDate' column value.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Adds the table/model configuration to the <see cref="ModelBuilder"/>.
        /// </summary>
        /// <param name="modelBuilder">The <see cref="ModelBuilder"/>.</param>
        public static void AddToModel(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Entity<PerformanceReview>(entity =>
            {
                entity.ToTable("PerformanceReview", "Hr");
                entity.HasKey(nameof(PerformanceReviewId));
                entity.Property(p => p.PerformanceReviewId).HasColumnName("PerformanceReviewId").HasColumnType("UNIQUEIDENTIFIER");
                entity.Property(p => p.EmployeeId).HasColumnName("EmployeeId").HasColumnType("UNIQUEIDENTIFIER");
                entity.Property(p => p.Date).HasColumnName("Date").HasColumnType("DATETIME2");
                entity.Property(p => p.PerformanceOutcomeCode).HasColumnName("PerformanceOutcomeCode").HasColumnType("NVARCHAR(50)");
                entity.Property(p => p.Reviewer).HasColumnName("Reviewer").HasColumnType("NVARCHAR(100)");
                entity.Property(p => p.Notes).HasColumnName("Notes").HasColumnType("NVARCHAR(4000)");
                entity.Property(p => p.RowVersion).HasColumnName("RowVersion").HasColumnType("TIMESTAMP").IsRowVersion();
                entity.Property(p => p.CreatedBy).HasColumnName("CreatedBy").HasColumnType("NVARCHAR(250)").ValueGeneratedOnUpdate();
                entity.Property(p => p.CreatedDate).HasColumnName("CreatedDate").HasColumnType("DATETIME2").ValueGeneratedOnUpdate();
                entity.Property(p => p.UpdatedBy).HasColumnName("UpdatedBy").HasColumnType("NVARCHAR(250)").ValueGeneratedOnAdd();
                entity.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate").HasColumnType("DATETIME2").ValueGeneratedOnAdd();
                AddToModel(entity);
            });
        }
        
        /// <summary>
        /// Enables further configuration of the underlying <see cref="EntityTypeBuilder"/> when configuring the <see cref="ModelBuilder"/>.
        /// </summary>
        static partial void AddToModel(EntityTypeBuilder<PerformanceReview> entity);
    }
}

#pragma warning restore
#nullable restore