using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MupApps.ControlsNavigation.Sample.DroidTablet.Views
{
    [Activity(Label = "Settings")]
    public class SettingsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.View_Settings);
        }
    }
}