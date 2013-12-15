using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Core;
using Cirrious.CrossCore.Plugins;

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
