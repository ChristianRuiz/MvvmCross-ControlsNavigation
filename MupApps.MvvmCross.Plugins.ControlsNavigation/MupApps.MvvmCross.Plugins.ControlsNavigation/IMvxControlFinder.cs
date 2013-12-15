using System;
using Cirrious.MvvmCross.ViewModels;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation
{
    public interface IMvxControlFinder
    {
        IMvxControl GetControl(Type viewModelType);

        IMvxControl GetControl(IMvxViewModel viewModelType);
    }
}
