using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MupApps.ControlsNavigation.Sample.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Touch.Views;

namespace MupApps.ControlsNavigation.Sample.IPhone
{
	public partial class FolderView : MvxViewController
	{
		public FolderView () : base ("FolderView", null)
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

			var set = this.CreateBindingSet<FolderView, FolderViewModel>();
			set.Bind(source).To (vm => vm.Mails);
			set.Bind(source).For(s => s.SelectedItem).To (vm => vm.SelectedMail);
			set.Apply ();

			Title = ((FolderViewModel)ViewModel).Folder.Name;
		}
	}
}

