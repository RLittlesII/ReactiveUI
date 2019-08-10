using System;
using Splat;

namespace Splat
{
    public static class CompositionRootMixins
    {
        /// <summary>
        /// Composes the specified composition root.
        /// </summary>
        /// <param name="compositionRoot">The composition root.</param>
        /// <returns>The dependency resolver.</returns>
        public static IReadonlyDependencyResolver Compose(this ICompositionRoot compositionRoot)
        {
            if (compositionRoot == null)
            {
                throw new ArgumentNullException(nameof(compositionRoot));
            }

            return compositionRoot.Root as IReadonlyDependencyResolver;
        }

        public static ICompositionBuilder RegisterCommandBinders(this ICompositionRoot composition, Action<IDependencyResolver> registrar)
        {
            return composition;
        }
    }
}
