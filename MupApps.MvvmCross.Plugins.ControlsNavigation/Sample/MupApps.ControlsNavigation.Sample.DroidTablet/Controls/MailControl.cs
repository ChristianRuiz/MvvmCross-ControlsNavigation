// MailControl.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Android.Content;
using Android.Util;
using MupApps.MvvmCross.Plugins.ControlsNavigation.Droid;

namespace MupApps.ControlsNavigation.Sample.DroidTablet.Controls
{
    public class MailControl : MvxAndroidControl
    {
        public MailControl(Context context) : base(context)
        {
            Initialize();
        }

        public MailControl(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Initialize();
        }

        public MailControl(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {
            Initialize();
        }

        private void Initialize()
        {
           SetContentView(Resource.Layout.View_Mail);
        }
    }
}
