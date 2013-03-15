using System.Collections.Generic;
using System.Drawing;
using MonoTouch.UIKit;

namespace WrestlingStats
{
	public class MainScreen : UIViewController
	{
		UIView _homeView;
		UIButton _matchButton; 
		MatchScreen _matchScreen ;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			float buttonHeight = 50.0f;
			float buttonWidth = 50.0f;
			float padding = 10.0f;
			int n = 25;
			
			this._homeView = new UIView {
				Frame = new RectangleF (0, 0, View.Frame.Width, View.Frame.Height), 
				BackgroundColor = UIColor.Yellow 
			};

			
			_matchButton = UIButton.FromType (UIButtonType.RoundedRect);
			_matchButton.SetTitle ("Match", UIControlState.Normal);
			var i = 1;
			_matchButton.Frame = new RectangleF (padding , padding * (i + 1) + (i * buttonWidth), buttonWidth, buttonHeight);
			_homeView.AddSubview (this._matchButton); 
			
			//---- same thing, but for the hello universe screen
			this._matchButton.TouchUpInside += (sender, e) => {
				if(this._matchScreen == null) { this._matchScreen = new MatchScreen(); }
				this.NavigationController.PushViewController(this._matchScreen, true);
			};

			View.AddSubview (this._homeView);
		}

		
		public override void ViewWillAppear (bool animated) {
			base.ViewWillAppear (animated);
			this.NavigationController.SetNavigationBarHidden (true, animated);
		} 
		

		 
	}
}