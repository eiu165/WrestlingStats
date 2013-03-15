using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace WrestlingStats
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window; 

        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {     
            window = new UIWindow (UIScreen.MainScreen.Bounds);          
            MainScreen vc = new MainScreen ();
 
			
			//---- instantiate a new navigation controller
			var rootNavigationController = new UINavigationController();  
			//---- add the home screen to the navigation controller (it'll be the top most screen)
			rootNavigationController.PushViewController(vc, false);
			
			//---- set the root view controller on the window. the nav controller will handle the rest
			this.window.RootViewController = rootNavigationController;
			
			this.window.MakeKeyAndVisible (); 
 
            return true;
        }
    }
}