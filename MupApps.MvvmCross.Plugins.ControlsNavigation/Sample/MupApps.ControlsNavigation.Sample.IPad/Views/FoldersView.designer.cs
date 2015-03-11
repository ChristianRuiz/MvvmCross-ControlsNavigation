// FoldersView.designer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Foundation;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	[Register ("FoldersView")]
	partial class FoldersView
	{
		[Outlet]
		UIKit.UITableView FoldersTable { get; set; }

		[Outlet]
		UIKit.UIView FolderView { get; set; }

		[Outlet]
		UIKit.UIView MailView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FoldersTable != null) {
				FoldersTable.Dispose ();
				FoldersTable = null;
			}

			if (FolderView != null) {
				FolderView.Dispose ();
				FolderView = null;
			}

			if (MailView != null) {
				MailView.Dispose ();
				MailView = null;
			}
		}
	}
}
