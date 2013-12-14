using System;
using Cirrious.MvvmCross.ViewModels;

namespace MupApps.MvvmCross.Plugins.TabletNavigation
{
    public interface IMvxControlFinder
    {
        IMvxControl GetControl(Type viewModelType);

        IMvxControl GetControl(IMvxViewModel viewModelType);
    }
}
