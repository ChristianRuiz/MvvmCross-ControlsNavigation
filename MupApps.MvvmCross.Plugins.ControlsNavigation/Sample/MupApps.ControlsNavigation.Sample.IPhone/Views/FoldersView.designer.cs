// FoldersView.designer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using MonoTouch.Foundation;

namespace MupApps.ControlsNavigation.Sample.IPhone
{
	[Register ("FoldersView")]
	partial class FoldersView
	{
		[Outlet]
		MonoTouch.UIKit.UITableView FoldersTable { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FoldersTable != null) {
				FoldersTable.Dispose ();
				FoldersTable = null;
			}
		}
	}
}
