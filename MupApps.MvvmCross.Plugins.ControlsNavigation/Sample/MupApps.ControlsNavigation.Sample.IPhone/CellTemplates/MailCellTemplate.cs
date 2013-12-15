// MailCellTemplate.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using MupApps.ControlsNavigation.Sample.Core.Model;

namespace MupApps.ControlsNavigation.Sample.IPhone
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

