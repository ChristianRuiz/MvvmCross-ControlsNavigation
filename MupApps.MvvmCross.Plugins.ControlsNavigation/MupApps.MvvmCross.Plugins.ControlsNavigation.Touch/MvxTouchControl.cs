using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.Touch
{
    public class MvxTouchControl : MvxViewController, IMvxControl
    {
        public new IMvxViewModel ViewModel
        {
            get { return base.ViewModel; }
            set
            {
                base.ViewModel = value;
                OnDataContextChanged();
                OnViewModelSet();
            }
        }

        private readonly IMvxControlsContainer _container;

        public MvxTouchControl(string nibName, NSBundle bundle) : base(nibName, bundle)
        {
            if (!Mvx.CanResolve<IMvxControlsContainer>())
                new Plugin().Load();

            _container = Mvx.Resolve<IMvxControlsContainer>();
            _container.Add(this);
        }

        public override void ViewDidDisappear(bool animated)
        {
            _container.Remove(this);
        }

        public void ResetControl(Type viewModelType)
        {
            _container.Reset(viewModelType);
        }

        public event EventHandler DataContextChanged;

        protected virtual void OnDataContextChanged()
        {
            var handler = DataContextChanged;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnViewModelSet()
        {
        }
    }
}