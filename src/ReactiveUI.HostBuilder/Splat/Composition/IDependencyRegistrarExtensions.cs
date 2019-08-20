using System;
using System.Collections.Generic;
using System.Text;
using Splat;

namespace ReactiveUI.HostBuilder.Splat.Composition
{
    internal static class IDependencyRegistrarExtensions
    {
        internal static IDependencyRegistrar RegisterPlatform<TPlatformOperation>(
            this IDependencyRegistrar dependencyRegistrar)
            where TPlatformOperation : IPlatformOperations
        {
            dependencyRegistrar.Register<IPlatformOperations>(() => default);
            return dependencyRegistrar;
        }

        internal static IDependencyRegistrar BindingTypeConverter<TPlatformOperation>(
            this IDependencyRegistrar dependencyRegistrar)
            where TPlatformOperation : IPlatformOperations
        {
            dependencyRegistrar.Register<IPlatformOperations>(() => default);
            return dependencyRegistrar;
        }

        internal static IDependencyRegistrar CreatesObservableForProperty<TPlatformOperation>(
            this IDependencyRegistrar dependencyRegistrar)
            where TPlatformOperation : IPlatformOperations
        {
            dependencyRegistrar.Register<IPlatformOperations>(() => default);
            return dependencyRegistrar;
        }

        internal static IDependencyRegistrar CreatesCommandBinding<TPlatformOperation>(
            this IDependencyRegistrar dependencyRegistrar)
            where TPlatformOperation : IPlatformOperations
        {
            dependencyRegistrar.Register<IPlatformOperations>(() => default);
            return dependencyRegistrar;
        }

        internal static IDependencyRegistrar SuspensionDriver<TPlatformOperation>(
            this IDependencyRegistrar dependencyRegistrar)
            where TPlatformOperation : IPlatformOperations
        {
            dependencyRegistrar.Register<IPlatformOperations>(() => default);
            return dependencyRegistrar;
        }
    }
}
