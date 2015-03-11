using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Platform;
using UIKit;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using MupApps.MvvmCross.Plugins.ControlsNavigation.Touch;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	public class Setup : MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new Core.App();
		}
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxTouchViewPresenter CreatePresenter()
	    {
            var viewPresenter = base.CreatePresenter();
            return new MvxTouchControlPresenter(viewPresenter);
	    }
	}
}