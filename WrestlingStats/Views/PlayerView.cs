using System;
using MonoTouch.UIKit;
using System.Drawing;
using MonoTouch.CoreGraphics;

namespace WrestlingStats
{
	
	public class PlayerView : UIView {

		UIButton _name;
		UIButton _team;
		UIButton _score;


		public PlayerView (RectangleF frame) : base (frame)
		{
			// Your initialization code goes here
		}
		
		
		public override void Draw (RectangleF rect)
		{
			var buttonHeight = 50.0f;
			base.Draw (rect); 
			AddButton (rect, buttonHeight, ref _name, 0, "name");
			AddButton (rect, buttonHeight, ref _team, 1, "team");
		}
		
		void AddButton (RectangleF rect, float buttonHeight, ref UIButton button, int index, string text)
		{
			button = UIButton.FromType (UIButtonType.RoundedRect);
			button.SetTitle (text, UIControlState.Normal);
			button.Frame = new RectangleF (0, index * buttonHeight, rect.Width, buttonHeight);
			this.Add (button);
		}
	}

}

