// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUI.HostBuilder.Composition
{
    /// <summary>
    /// Builds the application composition.
    /// </summary>
    public interface ICompositionBuilder
    {
        /// <summary>
        /// Registers custom command binders.
        /// </summary>
        /// <returns>
        /// The composition builder.
        /// </returns>
        ICompositionBuilder RegisterCommandBinders();

        /// <summary>
        /// Registers application dependencies.
        /// </summary>
        /// <returns>The composition builder.</returns>
        ICompositionBuilder RegisterDependencies();

        /// <summary>
        /// Registers Views to View Models.
        /// </summary>
        /// <returns>The composition builder.</returns>
        ICompositionBuilder RegisterViews();

        /// <summary>
        /// Registers Views to View Models.
        /// </summary>
        /// <returns>The composition builder.</returns>
        ICompositionBuilder RegisterViewModels();

        /// <summary>
        /// Build the <see cref="IContainer"/>.
        /// </summary>
        /// <returns>The container.</returns>
        ICompositionRoot Build();
    }
}
