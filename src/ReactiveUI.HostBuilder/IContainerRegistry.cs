using Splat;

namespace ReactiveUI.HostBuilder
{
    public interface IContainerRegistry
    {
        IDependencyResolver Build();
    }
}