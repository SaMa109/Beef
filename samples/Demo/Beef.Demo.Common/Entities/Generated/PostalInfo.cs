/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using CoreEx.Entities;

namespace Beef.Demo.Common.Entities
{
    /// <summary>
    /// Represents the Postal Info entity.
    /// </summary>
    public partial class PostalInfo
    {
        /// <summary>
        /// Gets the corresponding <see cref="Country"/> text (read-only where selected).
        /// </summary>
        public string? CountryText { get; set; }

        /// <summary>
        /// Gets or sets the Country.
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        public string? State { get; set; }

        /// <summary>
        /// Gets or sets the Places.
        /// </summary>
        public PlaceInfoCollection? Places { get; set; }
    }
}

#pragma warning restore
#nullable restore