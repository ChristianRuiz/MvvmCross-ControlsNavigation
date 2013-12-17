// IMvxControl.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

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

        EmptyControlBehaviours EmptyControlBehaviour { get; set; }

        void ChangeVisibility(bool visible);

        void ChangeEnabled(bool enabled);
    }
}
