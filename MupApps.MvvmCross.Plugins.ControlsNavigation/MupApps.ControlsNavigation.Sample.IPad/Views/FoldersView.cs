using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MupApps.ControlsNavigation.Sample.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Touch.Views;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	public partial class FoldersView : MvxViewController
	{
		public FoldersView () : base ("FoldersView", null)
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

			FolderView.AddSubview (new FolderControl ());
			
			var source = new MvxSimpleTableViewSource(FoldersTable, FolderCellTemplate.Key, FolderCellTemplate.Key);
			FoldersTable.Source = source;

			var set = this.CreateBindingSet<FoldersView, FoldersViewModel>();
			set.Bind(source).To (vm => vm.Folders);
			set.Bind(source).For(s => s.SelectedItem).To (vm => vm.SelectedFolder);
			set.Apply ();

			this.Title = "MailApp";
		}
	}
}

