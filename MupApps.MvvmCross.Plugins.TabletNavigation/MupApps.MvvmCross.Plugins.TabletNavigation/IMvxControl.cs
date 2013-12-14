using Cirrious.CrossCore.Core;
using Cirrious.MvvmCross.ViewModels;

namespace MupApps.MvvmCross.Plugins.TabletNavigation
{
    public interface IMvxControl
        : IMvxDataConsumer
    {
        IMvxViewModel ViewModel { get; set; }
    }
}
