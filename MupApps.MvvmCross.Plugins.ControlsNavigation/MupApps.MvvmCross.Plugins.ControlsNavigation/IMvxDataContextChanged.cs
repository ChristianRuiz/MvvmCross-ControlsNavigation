// IMvxDataContextChanged.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation
{
    public interface IMvxDataContextChanged
    {
        event EventHandler DataContextChanged;
    }
}
