
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace WrestlingStats
{
		public partial class EditNameScreen : UIViewController
		{
				public EditNameScreen () : base ("EditNameScreen", null)
				{
				}
		
				public override void DidReceiveMemoryWarning ()
				{
						// Releases the view if it doesn't have a superview.
						base.DidReceiveMemoryWarning ();
			
						// Release any cached data, images, etc that aren't in use.
				}
		
				public override void ViewDidLoad ()
				{
						base.ViewDidLoad ();
						this.name.SetKeyboardEditorWithCloseButton (UIKeyboardType.ASCIICapable);
						// Perform any additional setup after loading the view, typically from a nib.

			
			this.save.TouchUpInside += (o, e) => 
			{  
				//				using(var alert = new UIAlertView("Sorry", "this device has No Camera", null, "OK", null)) 
				//				{
				//					alert.Show();  
				//				}
				 
				this.NavigationController.PopToViewController(this, true);
			}; 



				}
		}
}

