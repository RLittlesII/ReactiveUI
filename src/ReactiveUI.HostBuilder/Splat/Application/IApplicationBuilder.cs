// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using ReactiveUI;
using Splat;

namespace Splat
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.hosting.ihostbuilder?view=aspnetcore-2.2
    /// </summary>
    public interface IApplicationBuilder
    {
        /// <summary>
        /// Gets the dependency registrar.
        /// </summary>
        /// <value>The dependency registrar.</value>
        IDependencyRegistrar DependencyRegistrar { get; }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns>The application instance.</returns>
        IApplication Build();

        IApplicationBuilder ConfigureAppConfiguration(Action<IConfigurationBuilder> configurationBuilder);

        IApplicationBuilder ConfigureContainer(IContainerRegistry containerRegistry);

        IApplicationBuilder ConfigureServices(Action<IDependencyRegistrar> serviceCollection);
    }

    public static class IApplicationBuilderMixins
    {
        /// <summary>
        /// Registers the platform.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="platformOperations">The platform operations.</param>
        /// <returns>The application builder.</returns>
        public static IApplicationBuilder RegisterPlatform(
            this IApplicationBuilder builder,
            Func<IPlatformOperations> platformOperations)
        {
            builder.DependencyRegistrar.RegisterConstant(platformOperations, typeof(IPlatformOperations));
            return builder;
        }
    }
}
