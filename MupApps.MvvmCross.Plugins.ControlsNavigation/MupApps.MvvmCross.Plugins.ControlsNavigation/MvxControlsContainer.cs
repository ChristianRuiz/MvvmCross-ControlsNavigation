using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation
{
    public class MvxControlsContainer
    : IMvxControlsContainer
    {
        private readonly List<IMvxControl> _controls = new List<IMvxControl>();

        public void Add(IMvxControl control)
        {
            _controls.Add(control);
        }

        public void Remove(IMvxControl control)
        {
            _controls.Remove(control);
        }

        public void ClearAll()
        {
            _controls.Clear();
        }

        public void Reset(Type viewModelType)
        {
            var controlFinder = Mvx.Resolve<IMvxControlFinder>();
            var control = controlFinder.GetControl(viewModelType);
            if (control != null)
                control.ViewModel = null;
        }

        public IMvxControl GetControl(IMvxViewModel viewModelType)
        {
            return GetControl(viewModelType.GetType());
        }

        public IMvxControl GetControl(Type viewModelType)
        {
            //TODO: Check if there's some constant on the framework for "ViewModel"
            var viewModelName = viewModelType.Name;
            if (!viewModelName.Contains("ViewModel"))
                return null;
            
            var controlName = string.Format("{0}Control", 
                viewModelName.Substring(0, viewModelName.LastIndexOf("ViewModel")));
            var control = _controls.FirstOrDefault(c => c.GetType().Name == controlName);

            return control;
        }
    }
}
