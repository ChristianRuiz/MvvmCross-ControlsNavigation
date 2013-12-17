// MvxAndroidControl.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;
using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.ViewModels;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.Droid
{
    public class MvxAndroidControl : FrameLayout, IMvxControl, IMvxDataContextChanged, IMvxBindingContextOwner, IMvxLayoutInflater
    {
        public IMvxBindingContext BindingContext { get; set; }

        public object DataContext
        {
            get { return BindingContext != null ? BindingContext.DataContext : null; }
            set { BindingContext.DataContext = value; }
        }

        public IMvxViewModel ViewModel
        {
            get { return DataContext as IMvxViewModel; }
            set
            {
                DataContext = value;
                OnDataContextChanged();
                OnViewModelSet();
                this.CheckEmptyControlBehaviour();
            }
        }

        private IMvxControlsContainer _container;

        public MvxAndroidControl(Context context) : base(context)
        {
            Initialize();
        }

        public MvxAndroidControl(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Initialize();
        }

        public MvxAndroidControl(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {
            Initialize();
        }

        private void Initialize()
        {
            EmptyControlBehaviour = this.GetDefaultEmptyControlBehaviour();

            BindingContext = new MvxAndroidBindingContext(Context, this);

            if (!Mvx.CanResolve<IMvxControlsContainer>())
                new Plugin().Load();

            _container = Mvx.Resolve<IMvxControlsContainer>();
            _container.Add(this);
        }

        protected override void OnDetachedFromWindow()
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
            Visibility = visible ? ViewStates.Visible : ViewStates.Invisible;
        }

        public void ChangeEnabled(bool enabled)
        {
            Enabled = enabled;
        }

        public void SetContentView(int layoutResId)
        {
            var view = this.BindingInflate(layoutResId, null);
            AddView(view);
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

        public LayoutInflater LayoutInflater
        {
            get
            {
                return LayoutInflater.From(Context);
            }
        }
    }
}
