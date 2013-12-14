using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.WindowsStore.Views;

namespace MupApps.MvvmCross.Plugins.TabletNavigation.WindowsStore
{
    public class MvxStoreControlPresenter : MvxControlPresenter, IMvxStoreViewPresenter
    {
        public MvxStoreControlPresenter(IMvxViewPresenter viewPresenter) : base(viewPresenter)
        {
        }
    }
}
