using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Controls;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Core;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;

namespace MupApps.MvvmCross.Plugins.TabletNavigation.WindowsStore
{
    public class MvxStoreControl
        : UserControl, IMvxControl
    {
        private IMvxViewModel _viewModel;
        public IMvxViewModel ViewModel
        {
            get { return _viewModel; }
            set
            {
                if (_viewModel == value)
                    return;

                _viewModel = value;
                DataContext = ViewModel;
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
