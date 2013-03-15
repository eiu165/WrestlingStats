using System;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.UIKit;

namespace WrestlingStats
{
	public class PlayerControl: UIViewController
	{ 
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad (); 
			
			UIButton _matchButton = UIButton.FromType (UIButtonType.RoundedRect);
			_matchButton.SetTitle ("test", UIControlState.Normal);
			var i = 1;
			
			float buttonHeight = 50.0f;
			float buttonWidth = 50.0f;
			float padding = 10.0f;
			int n = 25;

			_matchButton.Frame = new RectangleF (padding , padding * (i + 1) + (i * buttonWidth), buttonWidth, buttonHeight);
			//_homeView.AddSubview (this._matchButton); 



			View.AddSubview (_matchButton);  
		}
	} 
}