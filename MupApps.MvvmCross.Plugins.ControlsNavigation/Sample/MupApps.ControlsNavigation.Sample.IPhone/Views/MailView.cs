// MailView.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Cirrious.MvvmCross.Binding.BindingContext;
using MupApps.ControlsNavigation.Sample.Core.ViewModels;
using Cirrious.MvvmCross.Touch.Views;

namespace MupApps.ControlsNavigation.Sample.IPhone
{
	public partial class MailView : MvxViewController
	{
		public MailView () : base ("MailView", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			var set = this.CreateBindingSet<MailView, MailViewModel>();
			set.Bind(FromLabel).To (vm => vm.Mail.From);
			set.Bind(ToLabel).To (vm => vm.Mail.To);
			set.Bind(SubjectLabel).To (vm => vm.Mail.Subject);
			set.Bind(BodyLabel).To (vm => vm.Mail.Body);
			set.Apply ();
		}
	}
}

