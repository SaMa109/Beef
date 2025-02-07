/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business
{
    /// <summary>
    /// Provides the <b>Config</b> business functionality.
    /// </summary>
    public partial class ConfigManager : IConfigManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigManager"/> class.
        /// </summary>
        public ConfigManager()
            { ConfigManagerCtor(); }

        partial void ConfigManagerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Get Env Vars.
        /// </summary>
        /// <returns>A resultant <see cref="System.Collections.IDictionary"/>.</returns>
        public Task<System.Collections.IDictionary> GetEnvVarsAsync() => ManagerInvoker.Current.InvokeAsync(this, async _ =>
        {
            return Cleaner.Clean(await GetEnvVarsOnImplementationAsync().ConfigureAwait(false));
        }, InvokerArgs.Unspecified);
    }
}

#pragma warning restore
#nullable restore