using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MupApps.ControlsNavigation.Sample.Droid.Views
{
    [Activity(Label = "")]
    public class FoldersView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.View_Folders);
        }
    }
}