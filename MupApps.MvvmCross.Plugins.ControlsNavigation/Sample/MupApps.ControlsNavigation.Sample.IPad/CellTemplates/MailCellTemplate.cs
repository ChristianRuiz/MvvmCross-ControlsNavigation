// MailCellTemplate.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;
using Foundation;
using UIKit;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using MupApps.ControlsNavigation.Sample.Core.Model;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	public partial class MailCellTemplate : MvxTableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("MailCellTemplate", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("MailCellTemplate");

		public MailCellTemplate (IntPtr handle) : base (handle)
		{
			this.DelayBind(() => {
				var set = this.CreateBindingSet<MailCellTemplate, Mail>();
				set.Bind(FromLabel).To(folder => folder.From);
				set.Bind(SubjectLabel).To(folder => folder.Subject);
				set.Bind(DateLabel).To(folder => folder.Date);
				set.Apply ();
			});
		}

		public static MailCellTemplate Create ()
		{
			return (MailCellTemplate)Nib.Instantiate (null, null) [0];
		}
	}
}

