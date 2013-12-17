##MvvmCross - Controls Navigation Plugin 

MvvmCross plugin that allows placing multiple ViewModels in the same View as Controls, creating composite views.
##Features
1. Create composite views with multiple ViewModels asociated to Controls.
2. Use the same ViewModels for a mobile and tablet Apps. It modifies the ShowViewModel behaviour, allowing you to show Controls, not just change Views.
3. Implemented for iPad, Windows Store, Android Tablet Apps and Wpf applications.

##Sample

![Windows Phone Default MVVMCross Navigation](http://i.imgur.com/iSniJEjh.png)

![Windows Store Controls Navigation](http://i.imgur.com/yeBFtXs.png)

##Adding to your project

1. Add it from NuGet: https://www.nuget.org/packages/MupApps.MvvmCross.Plugins.ControlsNavigation

2. Override the CreateViewPresenter method on your Setup.cs file for each platform.
	
	Windows Store:
	```
	protected override IMvxStoreViewPresenter CreateViewPresenter(Frame rootFrame)
    {
        var viewPresenter = base.CreateViewPresenter(rootFrame);
        return new MvxStoreControlPresenter(viewPresenter);
    }
	```

	Droid:
	```
	protected override IMvxAndroidViewPresenter CreateViewPresenter()
    {
        var viewPresenter = base.CreateViewPresenter();
        return new MvxAndroidControlPresenter(viewPresenter);
    }
	```

	Touch:
	```
	protected override IMvxTouchViewPresenter CreatePresenter()
	{
        var viewPresenter = base.CreatePresenter();
        return new MvxTouchControlPresenter(viewPresenter);
	}
	```

	Wpf:
	```
	private readonly Dispatcher _uiThreadDispatcher;
    private readonly IMvxWpfViewPresenter _presenter;

	public Setup(Dispatcher dispatcher, IMvxWpfViewPresenter presenter)
        : base(dispatcher, presenter)
    {
        _uiThreadDispatcher = dispatcher;
        _presenter = presenter;
    }
	
	protected override IMvxViewDispatcher CreateViewDispatcher()
    {
        var controlPresenter = new MvxWpfControlPresenter(_presenter);
       
        return new MvxWpfViewDispatcher(_uiThreadDispatcher, controlPresenter);
    }
	```

3. Create a /Controls folder
4. Inherit your controls from MvxStoreControl, MvxAndroidControl or MvxTouchControl with the same name of the ViewModel but ending in Control (Ex: SecondViewModel -> SecondControl)
5. Add the user control to one of your Views that is already binded with a ViewModel (Ex: FirstView)

The control will be hidden until ShowViewModel has been called. You could change that behaviour setting the property EmptyControlBehaviour (None, Hidden, Disabled)

	Windows Store (on your View xaml):
	
	```
	xmlns:controls="using:YourNamespace.Controls"

	...

	<controls:SecondControl />
	```

	Droid (on your View axml):
	
	```
	<YourNamespace.Controls.SecondControl
        android:layout_height="fill_parent"
        android:layout_width="0dp"
        android:layout_weight="1" />
	```

	Touch:
	
	a. Add a UIView to your nib View file from XCode and position it, or add it programmatically 
		to your MvxViewController
	
	b. Ensure that your UIViewController for your control inherits from MxvTouchControl
	
	c. Add your control to your View

	```
	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();

		var secondControl = new SecondControl();
        AddChildViewController(secondControl);
        YourUIView.AddSubview(secondControl.View);

		...
	}
	```

	Wpf (on your View xaml):
	
	```
	xmlns:controls="clr-namespace:YourNamespace.Controls"

	...

	<controls:SecondControl />
	```
