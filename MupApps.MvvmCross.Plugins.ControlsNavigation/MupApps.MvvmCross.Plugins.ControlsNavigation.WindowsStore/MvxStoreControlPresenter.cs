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
