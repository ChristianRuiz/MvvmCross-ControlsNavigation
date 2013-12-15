// FolderCellTemplate.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using MupApps.ControlsNavigation.Sample.Core.Model;

namespace MupApps.ControlsNavigation.Sample.IPad
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

