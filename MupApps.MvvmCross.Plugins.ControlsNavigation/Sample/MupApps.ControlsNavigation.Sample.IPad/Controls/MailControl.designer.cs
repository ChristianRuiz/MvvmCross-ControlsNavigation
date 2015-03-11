// MailControl.designer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Foundation;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	[Register ("MailControl")]
	partial class MailControl
	{
		[Outlet]
		UIKit.UILabel BodyLabel { get; set; }

		[Outlet]
		UIKit.UILabel DateLabel { get; set; }

		[Outlet]
		UIKit.UILabel FromLabel { get; set; }

		[Outlet]
		UIKit.UILabel SubjectLabel { get; set; }

		[Outlet]
		UIKit.UILabel ToLabel { get; set; }
		
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

			if (DateLabel != null) {
				DateLabel.Dispose ();
				DateLabel = null;
			}
		}
	}
}
