namespace ReactiveUI
{
    public interface IInteractionBinderImplementation : IEnableLogger
    {
        IReactiveBinding<TView, TViewModel, TRegistration> BindInteraction<TView, TViewModel, TRegistration, TOut>()
            where TViewModel : class
            where TView : class, IViewFor<TViewModel>
            where TRegistration : Expression<Func<InteractionContext<TInput, TOutput>, Task<TOut>>>;
        
        IReactiveBinding<TView, TViewModel, TRegistration> BindInteraction<TView, TViewModel, TRegistration, TOut>()
            where TViewModel : class
            where TView : class, IViewFor<TViewModel>
            where TRegistration : Expression<Func<InteractionContext<TInput, TOutput>, IObservable<TOut>>>;
    }
    
    public class InteractionBindingMixins
    {
        private static readonly IInteractionBinderImplementation binderImplementation;

        static InteractionBindingMixins()
        {
            RxApp.EnsureInitialized();
            binderImplementation = default(IInteractionBinderImplementation);
        }

        public static IReactiveBinding<TView, TViewModel, TOut> BindInteraction<TViewModel, TView, TProp, TOut>(
            this TView view,
            TViewModel viewModel,
            Expression<Func<InteractionContext<TInput, TOutput>, Task>> handler)
        {
            return binderImplementation.BindInteraction<TView, TViewModel, TProp>(view, viewModel, handler);

            return new ReactiveBinding<TView, TViewModel, TProp>(
                                                                 view,
                                                                 viewModel,
                                                                 handler,
                                                                 vmExpression,
                                                                 source,
                                                                 BindingDirection.OneWay,
                                                                 bindingDisposable);
        }
        
        public static IReactiveBinding<TView, TViewModel, TOut> BindInteraction<TViewModel, TView, TProp, TOut>(
            this TView view,
            TViewModel viewModel,
            Expression<Func<InteractionContext<TInput, TOutput>, IObservable>> handler)
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
