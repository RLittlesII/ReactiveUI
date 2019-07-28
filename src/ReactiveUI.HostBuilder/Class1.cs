using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace ReactiveUI.HostBuilder
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.hosting.ihostbuilder?view=aspnetcore-2.2
    /// </summary>
    public interface IHostBuilder
    {
        IHost Build();

        IHostBuilder ConfigureAppConfiguration(Action<IConfigurationBuilder> configurationBuilder);

        IHostBuilder ConfigureContainer(IContainerRegistry containerRegistry);

        IHostBuilder ConfigureServices(Action<IDepednencyRegistrar> serviceCollection);
    }

    public interface IDepednencyRegistrar
    {
    }

    public interface IContainerRegistry
    {
    }

    public interface IConfigurationBuilder
    {
        IEnumerable<IConfigurationSource> Sources { get; }

        void Add(IConfigurationSource configurationSource);

        IConfiguration Build();
    }

    public interface IConfiguration
    {
    }

    public interface IConfigurationSource
    {

    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.hosting.ihost?view=aspnetcore-2.2
    /// </summary>
    public interface IHost
    {
        IScheduler MainThreadScheduler { get; }

        IScheduler TaskpoolScheduler { get; }

        IObserver<Exception> DefaultExceptionHandler { get; }

        ISuspensionHost SuspensionHost { get; }
    }

    public static class IHostExtensions
    {
        public static IObservable<Unit> Start(this IHostBuilder hostBuilder)
        {
            return Observable.Return(Unit.Default);
        }

        public static IObservable<Unit> Stop(this IHostBuilder hostBuilder)
        {
            return Observable.Return(Unit.Default);
        }
    }
}
