using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Views;

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