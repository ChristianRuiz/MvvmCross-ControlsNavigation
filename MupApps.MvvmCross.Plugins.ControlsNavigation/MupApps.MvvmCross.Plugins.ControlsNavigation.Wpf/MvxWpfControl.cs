// MvxStoreControl.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;
using System.ComponentModel;
using System.Windows;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Wpf.Views;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.Wpf
{
    public class MvxWpfControl
        : MvxWpfView, IMvxControl
    {
        private readonly IMvxControlsContainer _container;

        public MvxWpfControl()
        {
            DataContext = null;

            if (DesignerProperties.GetIsInDesignMode(this))
                return;

            if (!Mvx.CanResolve<IMvxControlsContainer>())
                new Plugin().Load();

            _container = Mvx.Resolve<IMvxControlsContainer>();

            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            _container.Add(this);
        }

        private void OnUnloaded(object sender, RoutedEventArgs routedEventArgs)
        {
            _container.Remove(this);
        }

        public void ResetControl(Type viewModelType)
        {
            _container.Reset(viewModelType);
        }
    }
}
