// MvxStoreControlPresenter.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.WindowsStore.Views;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.WindowsStore
{
    public class MvxStoreControlPresenter 
        : MvxControlPresenter, IMvxStoreViewPresenter
    {
        public MvxStoreControlPresenter(IMvxViewPresenter viewPresenter) : base(viewPresenter)
        {
        }
    }
}
