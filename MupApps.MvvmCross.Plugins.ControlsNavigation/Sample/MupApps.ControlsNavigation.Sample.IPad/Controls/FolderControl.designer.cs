// FolderControl.designer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Foundation;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	[Register ("FolderControl")]
	partial class FolderControl
	{
		[Outlet]
		UIKit.UITableView MailsTable { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MailsTable != null) {
				MailsTable.Dispose ();
				MailsTable = null;
			}
		}
	}
}
