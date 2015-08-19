// FolderCellTemplate.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Foundation;
using MupApps.ControlsNavigation.Sample.Core.Model;
using UIKit;

namespace MupApps.ControlsNavigation.Sample.IPhone.CellTemplates
{
	public partial class FolderCellTemplate : MvxTableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("FolderCellTemplate", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("FolderCellTemplate");

		public FolderCellTemplate (IntPtr handle) : base (handle)
		{
			this.DelayBind(() => {
				var set = this.CreateBindingSet<FolderCellTemplate, Folder>();
				set.Bind(FolderLabel).To(folder => folder.Name);
				set.Apply ();
			});
		}

		public static FolderCellTemplate Create ()
		{
			return (FolderCellTemplate)Nib.Instantiate (null, null) [0];
		}
	}
}

