using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
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
            get { return BindingContext.DataContext; }
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