using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MupApps.ControlsNavigation.Sample.Droid.Views
{
    [Activity(Label = "")]
    public class FolderView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.View_Folder);
        }
    }
}