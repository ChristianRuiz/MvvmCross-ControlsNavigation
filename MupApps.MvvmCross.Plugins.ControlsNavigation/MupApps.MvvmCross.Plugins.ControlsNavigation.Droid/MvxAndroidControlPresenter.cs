// MvxAndroidControlPresenter.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Cirrious.CrossCore;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;
using Java.Lang;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.Droid
{
    public class MvxAndroidControlPresenter
        : MvxControlPresenter, IMvxAndroidViewPresenter
    {
        public MvxAndroidControlPresenter(IMvxViewPresenter viewPresenter) : base(viewPresenter)
        {
        }
    }
}
