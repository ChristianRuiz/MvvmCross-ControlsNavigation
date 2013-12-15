using System;
using Cirrious.CrossCore.Core;
using Cirrious.MvvmCross.ViewModels;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation
{
    public interface IMvxControl
        : IMvxDataConsumer
    {
        IMvxViewModel ViewModel { get; set; }

        void ResetControl(Type viewModelType);
    }
}
