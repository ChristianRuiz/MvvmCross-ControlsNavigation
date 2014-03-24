using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using MupApps.MvvmCross.Plugins.ControlsNavigation;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.WindowsPhone
{
    public class MvxPhoneControl: UserControl, IMvxControl
    {
        public event EventHandler DataContextChanged;

        protected virtual void OnDataContextChanged()
        {
            var handler = DataContextChanged;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        public IMvxViewModel ViewModel
        {
            get { return DataContext as IMvxViewModel; }
            set
            {
                DataContext = value;
                this.CheckEmptyControlBehaviour();
                OnDataContextChanged();
            }
        }

        private readonly IMvxControlsContainer _container;

        public MvxPhoneControl()
        {
            DataContext = null;

            EmptyControlBehaviour = this.GetDefaultEmptyControlBehaviour();

            if (DesignerProperties.IsInDesignTool)
                return;

            if (!Mvx.CanResolve<IMvxControlsContainer>())
                new Plugin().Load();
            
            _container = Mvx.Resolve<IMvxControlsContainer>();

            Loaded += MvxPhoneControl_Loaded;
            Unloaded += MvxPhoneControl_Unloaded;
        }

        void MvxPhoneControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            _container.Add(this);
        }

        void MvxPhoneControl_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            _container.Remove(this);
        }

        public void ResetControl(Type viewModelType)
        {
            _container.Reset(viewModelType);
        }

        private EmptyControlBehaviours? _emptyControlBehaviour;
        public EmptyControlBehaviours EmptyControlBehaviour
        {
            get
            {
                return _emptyControlBehaviour.HasValue
                    ? _emptyControlBehaviour.Value
                    : this.GetDefaultEmptyControlBehaviour();
            }
            set
            {
                var lastBehaviour = _emptyControlBehaviour;
                _emptyControlBehaviour = value;
                this.CheckEmptyControlBehaviour(lastBehaviour);    
            }
        }

        public void ChangeVisibility(bool visible)
        {
            Visibility = visible ? System.Windows.Visibility.Visible : System.Windows.Visibility.Collapsed;
        }

        public void ChangeEnabled(bool enabled)
        {
            IsEnabled = enabled;
        }
    }
}