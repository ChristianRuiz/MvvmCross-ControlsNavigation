// MvxStoreControl.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Controls;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.WindowsStore
{
    public class MvxStoreControl
        : UserControl, IMvxControl
    {
        public IMvxViewModel ViewModel
        {
            get { return DataContext as IMvxViewModel; }
            set
            {
                DataContext = value;
            }
        }

        private readonly IMvxControlsContainer _container;

        public MvxStoreControl()
        {
            DataContext = null;

            if (DesignMode.DesignModeEnabled)
                return;

            if (!Mvx.CanResolve<IMvxControlsContainer>())
                new Plugin().Load();
            
            _container = Mvx.Resolve<IMvxControlsContainer>();

            Loaded += MvxStoreControl_Loaded;
            Unloaded += MvxStoreControl_Unloaded;
        }

        void MvxStoreControl_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            _container.Add(this);
        }

        void MvxStoreControl_Unloaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            _container.Remove(this);
        }

        public void ResetControl(Type viewModelType)
        {
            _container.Reset(viewModelType);
        }
    }
}
