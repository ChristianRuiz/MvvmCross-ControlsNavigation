// MvxTouchControl.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Touch;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using Foundation;

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
                this.CheckEmptyControlBehaviour();
            }
        }

        private readonly IMvxControlsContainer _container;

		public MvxTouchControl(string nibName, NSBundle bundle) : base(nibName, bundle)
        {
            //Hack: iOS crashes if you create a MvxUIViewController without DataContext
			DataContext = new object ();

            if (!Mvx.CanResolve<IMvxControlsContainer>())
                new Plugin().Load();

            _container = Mvx.Resolve<IMvxControlsContainer>();
            _container.Add(this);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

			if (!_emptyControlBehaviour.HasValue)
            	EmptyControlBehaviour = this.GetDefaultEmptyControlBehaviour();
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
            if (View != null)
                View.Hidden = !visible;
        }

        public void ChangeEnabled(bool enabled)
        {
            if (View != null)
                View.UserInteractionEnabled = enabled;
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
