using System;
using System.Reactive;
using Splat;

namespace ReactiveUI.HostBuilder
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.hosting.ihost?view=aspnetcore-2.2
    /// </summary>
    public interface IApplication
    {
        /// <summary>
        /// Gets the dependency resolver.
        /// </summary>
        /// <value>The dependency resolver.</value>
        IDependencyResolver DependencyResolver { get; }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        /// <returns>An observable sequence notifying completion.</returns>
        IObservable<Unit> Start();

        /// <summary>
        /// Stops this instance.
        /// </summary>
        /// <returns>An observable sequence notifying completion.</returns>
        IObservable<Unit> Stop();
    }
}
