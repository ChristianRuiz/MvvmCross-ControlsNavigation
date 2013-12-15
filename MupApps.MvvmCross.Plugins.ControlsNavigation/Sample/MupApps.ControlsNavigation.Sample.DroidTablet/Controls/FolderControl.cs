// FolderControl.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Android.Content;
using Android.Util;
using MupApps.ControlsNavigation.Sample.Core.ViewModels;
using MupApps.MvvmCross.Plugins.ControlsNavigation.Droid;

namespace MupApps.ControlsNavigation.Sample.DroidTablet.Controls
{
    public class FolderControl : MvxAndroidControl
    {
        public FolderControl(Context context) : base(context)
        {
            Initialize();
        }

        public FolderControl(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Initialize();
        }

        public FolderControl(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {
            Initialize();
        }

        private void Initialize()
        {
            SetContentView(Resource.Layout.View_Folder);
        }

        protected override void OnDataContextChanged()
        {
            base.OnDataContextChanged();
            ResetControl(typeof(MailViewModel));
        }
    }
}
