// FolderCellTemplate.designer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Foundation;
using UIKit;

namespace MupApps.ControlsNavigation.Sample.IPhone.CellTemplates
{
	[Register("FolderCellTemplate")]
	partial class FolderCellTemplate
	{
		[Outlet]
		UILabel FolderLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FolderLabel != null) {
				FolderLabel.Dispose ();
				FolderLabel = null;
			}
		}
	}
}
