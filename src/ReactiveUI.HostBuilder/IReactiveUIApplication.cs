// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Reactive.Concurrency;
using Splat;

namespace ReactiveUI.HostBuilder
{
    /// <summary>
    /// Interface defining a <see cref="RxApp"/> instance.
    /// </summary>
    /// <seealso cref="IApplication" />
    public interface IReactiveUIApplication : IApplication
    {
        /// <summary>
        /// Gets the main thread scheduler.
        /// </summary>
        /// <value>The main thread scheduler.</value>
        IScheduler MainThreadScheduler { get; }

        /// <summary>
        /// Gets the taskpool scheduler.
        /// </summary>
        /// <value>The taskpool scheduler.</value>
        IScheduler TaskpoolScheduler { get; }

        /// <summary>
        /// Gets the default exception handler.
        /// </summary>
        /// <value>The default exception handler.</value>
        IObserver<Exception> DefaultExceptionHandler { get; }

        /// <summary>
        /// Gets the suspension host.
        /// </summary>
        /// <value>The suspension host.</value>
        ISuspensionHost SuspensionHost { get; }
    }
}
