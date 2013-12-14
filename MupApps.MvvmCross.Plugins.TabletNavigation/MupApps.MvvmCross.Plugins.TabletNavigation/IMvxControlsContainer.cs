using System;
using System.Collections.Generic;
using System.Linq;
namespace MupApps.MvvmCross.Plugins.TabletNavigation
{
    public interface IMvxControlsContainer : IMvxControlFinder
    {
        void Add(IMvxControl control);

        void Remove(IMvxControl control);

        void ClearAll();
    }
}
