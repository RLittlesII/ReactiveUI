using System.Collections.Generic;

namespace ReactiveUI.HostBuilder
{
    public interface IConfigurationBuilder
    {
        IEnumerable<IConfigurationSource> Sources { get; }

        void Add(IConfigurationSource configurationSource);

        IConfiguration Build();
    }
}