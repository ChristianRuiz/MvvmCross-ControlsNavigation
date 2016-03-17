// MvxControlsContainer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System;
using System.Collections.Generic;
using System.Linq;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation
{
    public class MvxControlsContainer
    : IMvxControlsContainer
    {
        //TODO: Check if there are some constants defined in the framework for these names
        private const string ViewmodelNameSuffix = "ViewModel";
        private const string ControlNameSuffix = "Control";
        private const string ViewNameSuffix = "View";
        private readonly List<IMvxControl> _controls = new List<IMvxControl>();

        public void Add(IMvxControl control)
        {
            if (!_controls.Contains(control))
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
            var viewModelName = viewModelType.Name;
            if (!viewModelName.EndsWith(ViewmodelNameSuffix))
                return null;

            var viewModelPrefix = viewModelName.Substring(0,
                viewModelName.LastIndexOf(ViewmodelNameSuffix, StringComparison.CurrentCulture));
            var controlName = string.Format("{0}{1}", viewModelPrefix, ControlNameSuffix);
            var viewName = string.Format("{0}{1}", viewModelPrefix, ViewNameSuffix);
            var control = _controls.LastOrDefault(c =>
			    {
				var name = c.GetType().Name;
				return
				    string.Equals(name, controlName, StringComparison.CurrentCulture) ||
				    string.Equals(name, viewName, StringComparison.CurrentCulture);
			    });
            return control;
 
        }
    }
}
