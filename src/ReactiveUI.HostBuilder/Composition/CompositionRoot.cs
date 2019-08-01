using System;
using System.Collections.Generic;
using System.Text;
using Splat;

namespace ReactiveUI.HostBuilder.Composition
{
    public sealed class CompositionRoot : ICompositionRoot
    {
        private readonly ICompositionBuilder _compositionBuilder;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositionRoot" /> class.
        /// </summary>
        /// <param name="compositionBuilder">The composition builder.</param>
        public CompositionRoot(ICompositionBuilder compositionBuilder)
        {
            _compositionBuilder = compositionBuilder;

            // Should this be newed or passed?
            Root = new ModernDependencyResolver();
        }

        /// <inheritdoc />
        public IDependencyResolver Root { get; }
    }
}
