// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

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

        IApplicationBuilder ConfigureServices(Action<IDependencyRegistrar> serviceCollection);
    }
}
