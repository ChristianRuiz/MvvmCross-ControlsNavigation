// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	[Register ("FoldersView")]
	partial class FoldersView
	{
		[Outlet]
		MonoTouch.UIKit.UITableView FoldersTable { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView FolderView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView MailView { get; set; }
		
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
