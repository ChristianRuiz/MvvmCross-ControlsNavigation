
================================

MvvmCross plugin for allowing multiple ViewModels in the same View. 
##Features
1. Allows iPad, Windows Store Apps and Desktop applications to have UserControls instead of Views for each ViewModel, that can be on one same page

##Sample

![Windows Phone Default MVVMCross Navigation](http://i.imgur.com/iSniJEjh.png)

![Windows Store Controls Navigation](http://i.imgur.com/yeBFtXs.png)

##Adding to your project
1. Override the CreateViewPresenter method on your Setup.cs file for each platform.
	
	protected override IMvxStoreViewPresenter CreateViewPresenter(Frame rootFrame)
    {
        var viewPresenter = base.CreateViewPresenter(rootFrame);
        return new MvxStoreControlPresenter(viewPresenter);
    }

2. Create a /Controls folder
3. Inherit your controls from MvxStoreControl with the same name of the ViewModel but ending in Control (Ex: SecondViewModel -> SecondControl)
4. Add the user control to one of your Views that is already binded with a ViewModel (Ex: FirstView)