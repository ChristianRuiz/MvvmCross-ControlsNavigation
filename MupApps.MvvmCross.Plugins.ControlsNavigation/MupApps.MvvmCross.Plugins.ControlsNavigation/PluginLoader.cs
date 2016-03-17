// PluginLoader.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace MupApps.MvvmCross.Plugins.TabletNavigation
{
    public class PluginLoader : IMvxPluginLoader
    {
        public void EnsureLoaded()
        {
            var manager = Mvx.Resolve<IMvxPluginManager>();
            manager.EnsurePlatformAdaptionLoaded<PluginLoader>();
        }
    }
}
