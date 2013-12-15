// MailCellTemplate.designer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using MonoTouch.Foundation;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	[Register ("MailCellTemplate")]
	partial class MailCellTemplate
	{
		[Outlet]
		MonoTouch.UIKit.UILabel DateLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel FromLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel SubjectLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FromLabel != null) {
				FromLabel.Dispose ();
				FromLabel = null;
			}

			if (SubjectLabel != null) {
				SubjectLabel.Dispose ();
				SubjectLabel = null;
			}

			if (DateLabel != null) {
				DateLabel.Dispose ();
				DateLabel = null;
			}
		}
	}
}
