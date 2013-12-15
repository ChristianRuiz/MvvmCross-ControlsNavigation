using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;
using MupApps.MvvmCross.Plugins.ControlsNavigation;
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
