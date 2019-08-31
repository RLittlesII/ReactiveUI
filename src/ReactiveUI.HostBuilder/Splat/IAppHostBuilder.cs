// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUI.HostBuilder.Splat
{
    public interface IAppHostBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns>An app host.</returns>
        IAppHost Build();

        IApplicationBuilder ConfigureAppConfiguration(Action<IConfigurationBuilder> configurationBuilder);

        IApplicationBuilder ConfigureContainer(IContainerRegistry containerRegistry);

        IApplicationBuilder ConfigureServices(Action<IDependencyRegistrar> serviceCollection);
    }

    public interface IAppHost
    {
    }
}
