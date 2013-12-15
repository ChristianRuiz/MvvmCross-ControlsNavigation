// FolderControl.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Cirrious.MvvmCross.Binding.BindingContext;
using MupApps.ControlsNavigation.Sample.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Touch.Views;
using MupApps.MvvmCross.Plugins.ControlsNavigation.Touch;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	public partial class FolderControl : MvxTouchControl
	{
		public FolderControl () : base ("FolderControl", null)
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

			var source = new MvxSimpleTableViewSource(MailsTable, MailCellTemplate.Key, MailCellTemplate.Key);
			MailsTable.Source = source;

			var set = this.CreateBindingSet<FolderControl, FolderViewModel>();
			set.Bind(source).To (vm => vm.Mails);
			set.Bind(source).For(s => s.SelectedItem).To (vm => vm.SelectedMail);
			set.Apply ();
		}

		protected override void OnDataContextChanged ()
		{
			base.OnDataContextChanged ();
			ResetControl (typeof(MailViewModel));
		}
	}
}

