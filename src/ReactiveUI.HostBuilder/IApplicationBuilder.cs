using System;

namespace ReactiveUI.HostBuilder
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.hosting.ihostbuilder?view=aspnetcore-2.2
    /// </summary>
    public interface IApplicationBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns>The application instance.</returns>
        IApplication Build();

        IApplicationBuilder ConfigureAppConfiguration(Action<IConfigurationBuilder> configurationBuilder);

        IApplicationBuilder ConfigureContainer(IContainerRegistry containerRegistry);

        IApplicationBuilder ConfigureServices(Action<IDepednencyRegistrar> serviceCollection);
    }
}
