// FoldersView.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System.Linq;
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

		    var folderControl = new FolderControl();
            AddChildViewController(folderControl);
            FolderView.AddSubview(folderControl.View);

			var mailControl = new MailControl();
			AddChildViewController(mailControl);
			MailView.AddSubview(mailControl.View);

			var source = new MvxSimpleTableViewSource(FoldersTable, FolderCellTemplate.Key, FolderCellTemplate.Key);
			FoldersTable.Source = source;

			var set = this.CreateBindingSet<FoldersView, FoldersViewModel>();
			set.Bind(source).To (vm => vm.Folders);
			set.Bind(source).For(s => s.SelectedItem).To (vm => vm.SelectedFolder);
			set.Apply ();

			this.Title = "MailApp";

			//As the folder is also showed on this view, we don't wait for the user to select one
			((FoldersViewModel)ViewModel).SelectedFolder = ((FoldersViewModel)ViewModel).Folders.FirstOrDefault();
		}
	}
}

