using System;

namespace ReactiveUI
{
    public static class InteractionMixins
    {
        public static IDisposable HandleInteraction<T, TInput, TOutput>(
            this IObservable<T> @this,
            Interaction<TInput, TOutput> interaction,
            TInput input) => interaction.Handle(input).Subscribe();
    }
}
