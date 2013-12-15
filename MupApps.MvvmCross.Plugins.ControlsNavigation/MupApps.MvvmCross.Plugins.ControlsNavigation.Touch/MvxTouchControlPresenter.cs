using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.Views;
using MonoTouch.UIKit;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.Touch
{
    public class MvxTouchControlPresenter
        : MvxControlPresenter, IMvxTouchViewPresenter
    {
        protected IMvxTouchViewPresenter TouchViewPresenter
        {
            get
            {
                return _viewPresenter as IMvxTouchViewPresenter;
            }
        }

        public MvxTouchControlPresenter(IMvxViewPresenter viewPresenter) : base(viewPresenter)
        {
        }

        public bool PresentModalViewController(UIViewController controller, bool animated)
        {
            return TouchViewPresenter.PresentModalViewController(controller, animated);
        }

        public void NativeModalViewControllerDisappearedOnItsOwn()
        {
            TouchViewPresenter.NativeModalViewControllerDisappearedOnItsOwn();
        }
    }
}