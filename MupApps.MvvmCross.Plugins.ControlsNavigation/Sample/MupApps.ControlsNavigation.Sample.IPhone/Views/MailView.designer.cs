// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

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
