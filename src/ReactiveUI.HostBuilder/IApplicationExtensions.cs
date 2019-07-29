using System;
using System.Reactive;
using System.Reactive.Linq;

namespace ReactiveUI.HostBuilder
{
    public static class IApplicationExtensions
    {
        /// <summary>
        /// Runs the specified application.
        /// </summary>
        /// <param name="application">The application.</param>
        /// <returns>An observable sequence notifying completion.</returns>
        public static IObservable<Unit> Run(this IApplication application)
        {
            return Observable.Return(Unit.Default);
        }

        /// <summary>
        /// Waits for shutdown.
        /// </summary>
        /// <param name="application">The application.</param>
        /// <returns>An observable sequence notifying completion.</returns>
        public static IObservable<Unit> WaitForShutdown(this IApplication application)
        {
            return Observable.Return(Unit.Default);
        }
    }
}
