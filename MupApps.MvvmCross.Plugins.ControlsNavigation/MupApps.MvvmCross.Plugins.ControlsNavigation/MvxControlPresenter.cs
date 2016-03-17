// MvxControlPresenter.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Platform;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation
{
    public class MvxControlPresenter : IMvxViewPresenter
    {
        protected readonly IMvxViewPresenter _viewPresenter;

        public MvxControlPresenter(IMvxViewPresenter viewPresenter)
        {
            _viewPresenter = viewPresenter;
        }

        public virtual void Show(MvxViewModelRequest request)
        {
            if (ShowControl(request)) return;

            _viewPresenter.Show(request);
        }

        protected bool ShowControl(MvxViewModelRequest request)
        {
            IMvxControlFinder finder;

            if (!Mvx.TryResolve(out finder))
            {
                return false;
            }
            var control = finder.GetControl(request.ViewModelType);
            if (control == null)
            {
                return false;
            }
            if (control.ViewModel != null)
            {
                return true;
            }
            var loaderService = Mvx.Resolve<IMvxViewModelLoader>();
            var viewModel = loaderService.LoadViewModel(request, new MvxBundle());
            control.ViewModel = viewModel;
            return true;
        }

        public virtual void ChangePresentation(MvxPresentationHint hint)
        {
            if (hint is MvxClosePresentationHint)
            {
                IMvxControlFinder finder;

                if (Mvx.TryResolve(out finder))
                {
                    var control = finder.GetControl((hint as MvxClosePresentationHint).ViewModelToClose);
                    if (control != null)
                        control.ViewModel = null;
                    else
                        _viewPresenter.ChangePresentation(hint);
                }
                else
                    _viewPresenter.ChangePresentation(hint);
            }
            else
                _viewPresenter.ChangePresentation(hint);
        }

        public void AddPresentationHintHandler<THint>(Func<THint, bool> action) where THint : MvxPresentationHint
        {
            _viewPresenter.AddPresentationHintHandler<THint>(action);
        }
    }
}
