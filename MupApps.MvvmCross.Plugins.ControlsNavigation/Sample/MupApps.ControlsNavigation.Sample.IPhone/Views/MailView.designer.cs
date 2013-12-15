// MailView.designer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using MonoTouch.Foundation;

namespace MupApps.ControlsNavigation.Sample.IPhone
{
	[Register ("MailView")]
	partial class MailView
	{
		[Outlet]
		MonoTouch.UIKit.UILabel BodyLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel FromLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel SubjectLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel ToLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FromLabel != null) {
				FromLabel.Dispose ();
				FromLabel = null;
			}

			if (ToLabel != null) {
				ToLabel.Dispose ();
				ToLabel = null;
			}

			if (SubjectLabel != null) {
				SubjectLabel.Dispose ();
				SubjectLabel = null;
			}

			if (BodyLabel != null) {
				BodyLabel.Dispose ();
				BodyLabel = null;
			}
		}
	}
}
