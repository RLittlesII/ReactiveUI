using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reactive.Linq;

namespace ReactiveUI
{
    internal static class ViewModelMixins
    {
        [SuppressMessage("Microsoft.Performance", "CA1801", Justification = "TViewModel used to help generic calling.")]
        internal static IObservable<object> WhenViewModelChanged<TView, TViewModel>(this TView view, Expression expression)
            where TView : class, IViewFor
            where TViewModel : class =>
            view.WhenAnyValue(x => x.ViewModel)
                .Where(x => x is TViewModel)
                .Select(x => ((TViewModel)x!).WhenAnyDynamic(expression, y => y.Value))
                .Switch();
    }
}
