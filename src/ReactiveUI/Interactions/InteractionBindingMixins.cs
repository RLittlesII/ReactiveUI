using System;
using System.Linq.Expressions;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using Splat;

namespace ReactiveUI
{
    public interface IInteractionBinderImplementation : IEnableLogger
    {
        /// <summary>
        /// Binds the interaction.
        /// </summary>
        /// <typeparam name="TView">The type of the view.</typeparam>
        /// <typeparam name="TViewModel">The type of the view model.</typeparam>
        /// <typeparam name="TProp">The type of the property.</typeparam>
        /// <typeparam name="TInput">The type of the input.</typeparam>
        /// <typeparam name="TOutput">The type of the output.</typeparam>
        /// <param name="view">The view.</param>
        /// <param name="viewModel">The view model.</param>
        /// <param name="handler">The handler.</param>
        /// <returns>
        /// A reactive binding.
        /// </returns>
        IReactiveBinding<TView, TViewModel, TProp> BindInteraction<TView, TViewModel, TProp, TInput, TOutput>(
            TView view,
            TViewModel viewModel,
            Expression<Func<InteractionContext<TInput, TOutput>, Task>> handler)
            where TViewModel : class
            where TView : class, IViewFor<TViewModel>
            where TProp : Interaction<TInput, TOutput>;
    }

    public static class InteractionBindingMixins
    {
        private static readonly IInteractionBinderImplementation binderImplementation;

        static InteractionBindingMixins()
        {
            RxApp.EnsureInitialized();
            binderImplementation = default(IInteractionBinderImplementation);
        }

        /// <summary>
        /// Binds the interaction.
        /// </summary>
        /// <typeparam name="TView">The type of the view.</typeparam>
        /// <typeparam name="TViewModel">The type of the view model.</typeparam>
        /// <typeparam name="TProp">The type of the property.</typeparam>
        /// <typeparam name="TInput">The type of the input.</typeparam>
        /// <typeparam name="TOutput">The type of the output.</typeparam>
        /// <param name="view">The view.</param>
        /// <param name="viewModel">The view model.</param>
        /// <param name="handler">The handler.</param>
        /// <returns></returns>
        public static IReactiveBinding<TView, TViewModel, TProp> BindInteraction<TView, TViewModel, TProp, TInput, TOutput>(
            this TView view,
            TViewModel viewModel,
            Expression<Func<InteractionContext<TInput, TOutput>, Task>> handler)
            where TViewModel : class
            where TView : class, IViewFor<TViewModel>
            where TProp : Interaction<TInput, TOutput>
        {
            return new ReactiveBinding<TView, TViewModel, TProp>(view,
                                                                 viewModel,
                                                                 handler,
                                                                 null,
                                                                 source,
                                                                 BindingDirection.OneWay,
                                                                 Disposable.Create(() => { }));
        }

        public static IReactiveBinding<TView, TViewModel, TProp> BindInteraction<TView, TViewModel, TProp, TInput, TOutput, T>(
            this TView view,
            TViewModel viewModel,
            Expression<Func<InteractionContext<TInput, TOutput>, IObservable<T>>> handler)
            where TViewModel : class
            where TView : class, IViewFor<TViewModel>
            where TProp : Interaction<TInput, TOutput>
        {
            return new ReactiveBinding<TView, TViewModel, TProp>(
                                                                 view,
                                                                 viewModel,
                                                                 handler,
                                                                 vmExpression,
                                                                 source,
                                                                 BindingDirection.OneWay,
                                                                 bindingDisposable);
        }
    }
}
