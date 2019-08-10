// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Text;
using Splat;

namespace Splat
{
    public static class IApplicationBuilderExtensions
    {
        public static IApplicationBuilder WithLogging(this IApplicationBuilder hostBuilder, IFullLogger fullLogger)
        {
            return hostBuilder;
        }

        public static IApplicationBuilder WithDependencyResolver(this IApplicationBuilder hostBuilder, IDependencyResolver dependencyResolver)
        {
            hostBuilder.SetDependencyRegistrar(dependencyResolver);
            return hostBuilder;
        }
    }
}
