using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Cirrious.MvvmCross.WindowsStore.Views;
using MupApps.TabletNavigation.Sample.Core.ViewModels;

namespace MupApps.TabletNavigation.Sample.WindowsStore.Views
{
    public sealed partial class FoldersView : MvxStorePage
    {
        public FoldersView()
        {
            this.InitializeComponent();
        }

        private void FoldersView_OnLoaded(object sender, RoutedEventArgs e)
        {
            ((FoldersViewModel)ViewModel).SelectedFolder = ((FoldersViewModel)ViewModel).Folders.FirstOrDefault();
        }
    }
}
