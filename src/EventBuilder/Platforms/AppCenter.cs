using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventBuilder.NuGet;
using NuGet.Frameworks;
using NuGet.Packaging.Core;
using NuGet.Versioning;
using Serilog;

namespace EventBuilder.Platforms
{
    /// <inheritdoc />
    /// <summary>
    /// Microsoft AppCenter platform.
    /// </summary>
    /// <seealso cref="T:EventBuilder.Platforms.BasePlatform" />
    public class AppCenter : BasePlatform
    {
        private readonly PackageIdentity[] _packageNames = new[]
        {
            new PackageIdentity("Microsoft.AppCenter", new NuGetVersion("1.12.0")),
            new PackageIdentity("Microsoft.AppCenter.Analytics", new NuGetVersion("1.12.0")),
            new PackageIdentity("Microsoft.AppCenter.Crashes", new NuGetVersion("1.12.0"))
        };

        /// <inheritdoc />
        public override AutoPlatform Platform => AutoPlatform.AppCenter;

        /// <inheritdoc />
        public override async Task Extract()
        {
            var packageUnzipPath =
                await NuGetPackageHelper.InstallPackages(_packageNames, Platform).ConfigureAwait(false);

            Log.Debug($"Package unzip path is {packageUnzipPath}");

            Assemblies.Add(Directory.GetFiles(packageUnzipPath, "Microsoft.AppCenter.dll", SearchOption.AllDirectories).First(x => x.Contains("netstandard1.0")));
            Assemblies.Add(Directory.GetFiles(packageUnzipPath, "Microsoft.AppCenter.Analytics.dll", SearchOption.AllDirectories).First(x => x.Contains("netstandard1.0")));
            Assemblies.Add(Directory.GetFiles(packageUnzipPath, "Microsoft.AppCenter.Crashes.dll", SearchOption.AllDirectories).First(x => x.Contains("netstandard1.0")));

            foreach (var directory in Directory.GetDirectories(packageUnzipPath, "*.*", SearchOption.AllDirectories))
            {
                CecilSearchDirectories.Add(directory);
            }
        }
    }
}
