// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Linq.Expressions;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Splat;

namespace ReactiveUI
{
    /// <summary>
    /// This class provides extension methods for the ReactiveUI ineraction handler registration.
    /// </summary>
    public static class InteractionBindingMixins
    {
        static InteractionBindingMixins()
        {
            RxApp.EnsureInitialized();
        }

        /// <summary>
        /// Binds the interaction by allowing the registration to the handler to happen in a <see cref="IReactiveBinding{TView, TViewModel, TValue}"/>.
        /// </summary>
        /// <typeparam name="TView">The type of the view.</typeparam>
        /// <typeparam name="TViewModel">The type of the view model.</typeparam>
        /// <typeparam name="TProp">The type of the property.</typeparam>
        /// <typeparam name="TInput">The type of the input.</typeparam>
        /// <typeparam name="TOutput">The type of the output.</typeparam>
        /// <param name="view">The view.</param>
        /// <param name="viewModel">The view model.</param>
        /// <param name="handler">The handler.</param>
        /// <returns>A reactive binding.</returns>
        public static IReactiveBinding<TView, TViewModel, TProp> BindInteraction<TView, TViewModel, TProp, TInput, TOutput>(
            this TView view,
            TViewModel viewModel,
            Expression<Func<InteractionContext<TInput, TOutput>, Task>> handler)
            where TViewModel : class
            where TView : class, IViewFor<TViewModel>
            where TProp : Interaction<TInput, TOutput>
        {
            var source = Reflection.ViewModelWhenAnyValue(viewModel, view, handler).Cast<TProp>();
            return new ReactiveBinding<TView, TViewModel, TProp>(
                                                                 view,
                                                                 viewModel,
                                                                 handler,
                                                                 null,
                                                                 source,
                                                                 BindingDirection.OneWay,
                                                                 Disposable.Create(() => { }));
        }
    }
}
