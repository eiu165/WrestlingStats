using System;
using MonoTouch.UIKit;

namespace WrestlingStats
{
	public static class Keyboard
	{
		public static void SetKeyboardEditorWithCloseButton (this UITextField txt, UIKeyboardType     keyboardType, string closeButtonText = "Done")
		{
			UIToolbar toolbar = new UIToolbar ();
			txt.KeyboardType = keyboardType;
			toolbar.BarStyle = UIBarStyle.Black;
			toolbar.Translucent = true;
			toolbar.SizeToFit ();
			UIBarButtonItem doneButton = new UIBarButtonItem (closeButtonText, UIBarButtonItemStyle.Done,
			                                                  (s, e) => {
				txt.ResignFirstResponder ();
			});
			toolbar.SetItems (new UIBarButtonItem[]{doneButton}, true);
			
			txt.InputAccessoryView = toolbar;
		}
	}
}

