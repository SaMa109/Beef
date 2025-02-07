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
    /// Represents the <see cref="Robot"/> arguments entity.
    /// </summary>
    public partial class RobotArgs
    {
        /// <summary>
        /// Gets or sets the Model number.
        /// </summary>
        [JsonPropertyName("model-no")]
        public string? ModelNo { get; set; }

        /// <summary>
        /// Gets or sets the Unique serial number.
        /// </summary>
        [JsonPropertyName("serial-no")]
        public string? SerialNo { get; set; }

        /// <summary>
        /// Gets or sets the Power Sources.
        /// </summary>
        [JsonPropertyName("power-sources")]
        public List<string?>? PowerSources { get; set; }
    }
}

#pragma warning restore
#nullable restore