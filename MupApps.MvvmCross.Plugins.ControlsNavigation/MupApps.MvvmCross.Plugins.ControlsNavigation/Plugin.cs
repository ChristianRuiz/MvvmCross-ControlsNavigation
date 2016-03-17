// Plugin.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation
{
    public class Plugin : IMvxPlugin
    {
        public virtual void Load()
        {
            var container = new MvxControlsContainer();
            Mvx.RegisterSingleton<IMvxControlsContainer>(container);
            Mvx.RegisterSingleton<IMvxControlFinder>(container);
        }
    }
}
