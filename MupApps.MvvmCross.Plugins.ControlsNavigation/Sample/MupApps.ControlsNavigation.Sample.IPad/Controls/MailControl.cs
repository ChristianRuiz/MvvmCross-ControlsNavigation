// MailControl.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Cirrious.MvvmCross.Binding.BindingContext;
using MupApps.ControlsNavigation.Sample.Core.ViewModels;
using MupApps.MvvmCross.Plugins.ControlsNavigation.Touch;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	public partial class MailControl : MvxTouchControl
	{
		public MailControl () : base ("MailControl", null)
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

			var set = this.CreateBindingSet<MailControl, MailViewModel>();
			set.Bind(FromLabel).To (vm => vm.Mail.From);
			set.Bind(ToLabel).To (vm => vm.Mail.To);
			set.Bind(SubjectLabel).To (vm => vm.Mail.Subject);
			set.Bind(BodyLabel).To (vm => vm.Mail.Body);
			set.Bind(DateLabel).To (vm => vm.Mail.Date);
			set.Apply ();
		}
	}
}

