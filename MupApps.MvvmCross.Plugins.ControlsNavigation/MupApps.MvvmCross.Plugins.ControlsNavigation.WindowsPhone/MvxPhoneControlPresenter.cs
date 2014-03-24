using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.WindowsPhone.Views;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.WindowsPhone
{
    public class MvxPhoneControlPresenter: MvxControlPresenter, IMvxPhoneViewPresenter
    {
        public MvxPhoneControlPresenter(IMvxViewPresenter viewPresenter)
            : base(viewPresenter)
        {
        }
    }
}
