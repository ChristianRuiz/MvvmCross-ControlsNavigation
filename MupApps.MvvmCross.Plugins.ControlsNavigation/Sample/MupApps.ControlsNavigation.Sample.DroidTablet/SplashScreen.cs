// SplashScreen.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Droid.Views;

namespace MupApps.ControlsNavigation.Sample.DroidTablet
{
    [Activity(
		Label = "MupApps.ControlsNavigation.Sample.DroidTablet"
		, MainLauncher = true
		, Icon = "@drawable/icon"
		, Theme = "@style/Theme.Splash"
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
