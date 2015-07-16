// MailCellTemplate.cs
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
	public partial class MailCellTemplate : MvxTableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("MailCellTemplate", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("MailCellTemplate");

		public MailCellTemplate (IntPtr handle) : base (handle)
		{
			this.DelayBind(() => {
				var set = this.CreateBindingSet<MailCellTemplate, Mail>();
				set.Bind(FromLabel).To(mail => mail.From);
				set.Bind(SubjectLabel).To(mail => mail.Subject);
				set.Bind(DateLabel).To(mail => mail.Date);
				set.Apply ();
			});
		}

		public static MailCellTemplate Create ()
		{
			return (MailCellTemplate)Nib.Instantiate (null, null) [0];
		}
	}
}

