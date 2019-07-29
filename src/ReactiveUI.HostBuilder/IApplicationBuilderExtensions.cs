using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using Splat;

namespace ReactiveUI.HostBuilder
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.hosting.ihostbuilder?view=aspnetcore-2.2
    /// </summary>
    public interface IApplicationBuilder
    {
        IReactiveUIApplication Build();

        IApplicationBuilder ConfigureAppConfiguration(Action<IConfigurationBuilder> configurationBuilder);

        IApplicationBuilder ConfigureContainer(IContainerRegistry containerRegistry);

        IApplicationBuilder ConfigureServices(Action<IDepednencyRegistrar> serviceCollection);
    }

    public static class IApplicationBuilderExtensions
    {
        public static IApplicationBuilder WithLogging(this IApplicationBuilder hostBuilder, IFullLogger fullLogger)
        {
            return hostBuilder;
        }

        public static IApplicationBuilder WithDependencyResolver(this IApplicationBuilder hostBuilder, IDependencyResolver dependencyResolver)
        {
            return hostBuilder;
        }
    }

    public interface IDepednencyRegistrar : IMutableDependencyResolver
    {
    }

    public interface IContainerRegistry
    {
        IDependencyResolver Build();
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
    /// Interface defining a <see cref="RxApp"/> instance.
    /// </summary>
    /// <seealso cref="ReactiveUI.HostBuilder.IApplication" />
    public interface IReactiveUIApplication : IApplication
    {
        IScheduler MainThreadScheduler { get; }

        IScheduler TaskpoolScheduler { get; }

        IObserver<Exception> DefaultExceptionHandler { get; }

        ISuspensionHost SuspensionHost { get; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.hosting.ihost?view=aspnetcore-2.2
    /// </summary>
    public interface IApplication
    {
        IDependencyResolver DependencyResolver { get; }

        IObservable<Unit> Start();

        IObservable<Unit> Stop();
    }

    public static class IApplicationExtensions
    {
        public static IObservable<Unit> Run(this IApplication application)
        {
            return Observable.Return(Unit.Default);
        }

        public static IObservable<Unit> WaitForShutdown(this IApplication application)
        {
            return Observable.Return(Unit.Default);
        }
    }
}
