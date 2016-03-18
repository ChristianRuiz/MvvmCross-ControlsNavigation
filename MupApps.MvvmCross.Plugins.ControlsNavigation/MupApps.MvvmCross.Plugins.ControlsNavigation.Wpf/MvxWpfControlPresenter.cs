// MvxStoreControlPresenter.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using MvvmCross.Core.Views;
using MvvmCross.Wpf.Views;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.Wpf
{
    public class MvxWpfControlPresenter 
        : MvxControlPresenter, IMvxWpfViewPresenter
    {
        public MvxWpfControlPresenter(IMvxViewPresenter viewPresenter) : base(viewPresenter)
        {
        }
    }
}
