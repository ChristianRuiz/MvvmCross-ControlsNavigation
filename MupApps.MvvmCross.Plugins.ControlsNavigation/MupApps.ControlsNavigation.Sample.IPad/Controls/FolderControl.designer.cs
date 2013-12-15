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
	[Register ("FolderControl")]
	partial class FolderControl
	{
		[Outlet]
		MonoTouch.UIKit.UITableView MailsTable { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MailsTable != null) {
				MailsTable.Dispose ();
				MailsTable = null;
			}
		}
	}
}
