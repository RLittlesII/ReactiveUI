using System;
using System.Collections.Generic;
using System.Text;
using Splat;

namespace ReactiveUI.HostBuilder.Splat.Composition
{
    /// <summary>
    /// Extensions for interacting with the dependency registration process.
    /// </summary>
    internal static class IDependencyResolverExtensions
    {
        internal static IDependencyResolver RegisterPlatform<TPlatformOperation>(
            this IDependencyResolver dependencyRegistrar)
            where TPlatformOperation : IPlatformOperations
        {
            dependencyRegistrar.Register<IPlatformOperations>(() => default);
            return dependencyRegistrar;
        }

        internal static IDependencyResolver BindingTypeConverter<TPlatformOperation>(
            this IDependencyResolver dependencyRegistrar)
            where TPlatformOperation : IPlatformOperations
        {
            dependencyRegistrar.Register<IPlatformOperations>(() => default);
            return dependencyRegistrar;
        }

        internal static IDependencyResolver CreatesObservableForProperty<TPlatformOperation>(
            this IDependencyResolver dependencyRegistrar)
            where TPlatformOperation : IPlatformOperations
        {
            dependencyRegistrar.Register<IPlatformOperations>(() => default);
            return dependencyRegistrar;
        }

        internal static IDependencyResolver CreatesCommandBinding<TPlatformOperation>(
            this IDependencyResolver dependencyRegistrar)
            where TPlatformOperation : IPlatformOperations
        {
            dependencyRegistrar.Register<IPlatformOperations>(() => default);
            return dependencyRegistrar;
        }

        internal static IDependencyResolver SuspensionDriver<TPlatformOperation>(
            this IDependencyResolver dependencyRegistrar)
            where TPlatformOperation : IPlatformOperations
        {
            dependencyRegistrar.Register<IPlatformOperations>(() => default);
            return dependencyRegistrar;
        }
    }
}
