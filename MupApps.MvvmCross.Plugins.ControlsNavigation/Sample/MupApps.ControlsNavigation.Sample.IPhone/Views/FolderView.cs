// FolderView.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using MupApps.ControlsNavigation.Sample.Core.ViewModels;
using MupApps.ControlsNavigation.Sample.IPhone.CellTemplates;

namespace MupApps.ControlsNavigation.Sample.IPhone.Views
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

