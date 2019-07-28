// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Reactive.Linq;

namespace ReactiveUI
{
    /// <summary>
    /// Extension methods associated with the Interaction class.
    /// </summary>
    public static class InteractionMixins
    {
        /// <summary>
        /// Handles the interaction.
        /// </summary>
        /// <typeparam name="TSource">The source type.</typeparam>
        /// <typeparam name="TInput">The type of the input.</typeparam>
        /// <typeparam name="TOutput">The type of the output.</typeparam>
        /// <param name="this">The this.</param>
        /// <param name="interaction">The interaction.</param>
        /// <param name="input">The input.</param>
        /// <returns>An observable sequence of output.</returns>
        public static IObservable<TOutput> HandleInteraction<TSource, TInput, TOutput>(
            this IObservable<TSource> @this,
            Interaction<TInput, TOutput> interaction,
            TInput input) => interaction?.Handle(input) ?? throw new ArgumentNullException(nameof(interaction));

        /// <summary>
        /// Handles the interaction.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TInput">The type of the input.</typeparam>
        /// <typeparam name="TOutput">The type of the output.</typeparam>
        /// <param name="this">The this.</param>
        /// <param name="interaction">The interaction.</param>
        /// <returns>An observable sequence of output.</returns>
        public static IObservable<TOutput> HandleInteraction<TSource, TInput, TOutput>(
            this IObservable<TSource> @this,
            Interaction<TInput, TOutput> interaction) => interaction?.Handle(default(TInput)) ?? throw new ArgumentNullException(nameof(interaction));


        /// <summary>
        /// Handles the interaction.
        /// </summary>
        /// <typeparam name="TSource">The source type.</typeparam>
        /// <typeparam name="TInput">The type of the input.</typeparam>
        /// <typeparam name="TOutput">The type of the output.</typeparam>
        /// <param name="this">The this.</param>
        /// <param name="interaction">The interaction.</param>
        /// <param name="input">The input.</param>
        /// <returns>An observable sequence of output.</returns>
        public static IObservable<TSource> HandleInteraction<TSource, TInput, TOutput>(
            this IObservable<TSource> @this,
            Interaction<TInput, TOutput> interaction,
            TInput input) => interaction?.Handle(input) ?? throw new ArgumentNullException(nameof(interaction));

        /// <summary>
        /// Handles the interaction.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TInput">The type of the input.</typeparam>
        /// <typeparam name="TOutput">The type of the output.</typeparam>
        /// <param name="this">The this.</param>
        /// <param name="interaction">The interaction.</param>
        /// <returns>An observable sequence of output.</returns>
        public static IObservable<TSource> HandleInteraction<TSource, TInput, TOutput>(
            this IObservable<TSource> @this,
            Interaction<TInput, TOutput> interaction)
        {
            if (interaction == null)
            {
                throw new ArgumentNullException(nameof(interaction));
            }

            return @this.Do(_ => interaction.Handle(default(TInput)).Subscribe());
        }
    }
}
