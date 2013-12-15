// FolderControl.xaml.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Windows.UI.Xaml;
// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236
using MupApps.MvvmCross.Plugins.ControlsNavigation.WindowsStore;
using MupApps.ControlsNavigation.Sample.Core.ViewModels;

namespace MupApps.ControlsNavigation.Sample.WindowsStore.Controls
{
    public sealed partial class FolderControl : MvxStoreControl
    {
        public FolderControl()
        {
            this.InitializeComponent();
        }

        void FolderControl_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            //If we change the folder, we reset the current mail ViewModel
            ResetControl(typeof(MailViewModel));
        }
    }
}
