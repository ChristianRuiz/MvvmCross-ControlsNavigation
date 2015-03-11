// FolderCellTemplate.designer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Foundation;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	[Register ("FolderCellTemplate")]
	partial class FolderCellTemplate
	{
		[Outlet]
		UIKit.UILabel FolderLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FolderLabel != null) {
				FolderLabel.Dispose ();
				FolderLabel = null;
			}
		}
	}
}
