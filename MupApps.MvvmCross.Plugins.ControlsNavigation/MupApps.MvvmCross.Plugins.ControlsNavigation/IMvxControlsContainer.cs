// IMvxControlsContainer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation
{
    public interface IMvxControlsContainer : IMvxControlFinder
    {
        void Add(IMvxControl control);

        void Remove(IMvxControl control);

        void ClearAll();

        void Reset(Type viewModelType);
    }
}
