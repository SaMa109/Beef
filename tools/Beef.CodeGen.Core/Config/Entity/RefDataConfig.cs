﻿// Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

using OnRamp.Config;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beef.CodeGen.Config.Entity
{
    /// <summary>
    /// Provides Reference Data specific properties.
    /// </summary>
    public class RefDataConfig : ConfigBase<CodeGenConfig, CodeGenConfig>
    {
        /// <summary>
        /// Indicates whether auto-implementing 'Database'.
        /// </summary>
        public bool UsesDatabase => Parent!.RefDataEntities?.Any(x => x.AutoImplement == "Database") ?? false;

        /// <summary>
        /// Indicates whether auto-implementing 'EntityFramework'.
        /// </summary>
        public bool UsesEntityFramework => Parent!.RefDataEntities?.Any(x => x.AutoImplement == "EntityFramework") ?? false;

        /// <summary>
        /// Indicates whether auto-implementing 'Cosmos'.
        /// </summary>
        public bool UsesCosmos => Parent!.RefDataEntities?.Any(x => x.AutoImplement == "Cosmos") ?? false;

        /// <summary>
        /// Indicates whether auto-implementing 'OData'.
        /// </summary>
        public bool UsesOData => Parent!.RefDataEntities?.Any(x => x.AutoImplement == "OData") ?? false;

        /// <summary>
        /// Gets the Data constructor parameters.
        /// </summary>
        public List<ParameterConfig> DataCtorParameters { get; } = new List<ParameterConfig>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected override async Task PrepareAsync()
        {
            var oc = new OperationConfig { Name = "<internal>" };
            await oc.PrepareAsync(Root!, new EntityConfig { Name = "RefData" }).ConfigureAwait(false);

            // Data constructors.
            if (UsesDatabase)
                DataCtorParameters.Add(new ParameterConfig { Name = "Db", Type = Root!.DatabaseName, Text = $"{{{{{Root!.DatabaseName}}}}}" });

            if (UsesEntityFramework)
                DataCtorParameters.Add(new ParameterConfig { Name = "Ef", Type = Root!.EntityFrameworkName, Text = $"{{{{{Root!.EntityFrameworkName}}}}}" });

            if (UsesCosmos)
                DataCtorParameters.Add(new ParameterConfig { Name = "Cosmos", Type = Root!.CosmosName, Text = $"{{{{{Root!.CosmosName}}}}}" });

            if (UsesOData)
                DataCtorParameters.Add(new ParameterConfig { Name = "OData", Type = Root!.ODataName, Text = $"{{{{{Root!.ODataName}}}}}" });

            EntityConfig.AddConfiguredParameters(Root!.RefDataDataCtorParams, DataCtorParameters);

            foreach (var ctor in DataCtorParameters)
            {
                await ctor.PrepareAsync(Root!, oc).ConfigureAwait(false);
            }
        }
    }
}