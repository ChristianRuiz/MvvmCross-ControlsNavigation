// FolderCellTemplate.designer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using MonoTouch.Foundation;

namespace MupApps.ControlsNavigation.Sample.IPhone
{
	[Register ("FolderCellTemplate")]
	partial class FolderCellTemplate
	{
		[Outlet]
		MonoTouch.UIKit.UILabel FolderLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FolderLabel != null) {
				FolderLabel.Dispose ();
				FolderLabel = null;
			}
		}
	}
}
