using System;
using MonoTouch.UIKit;
using System.Drawing;
using MonoTouch.CoreGraphics;

namespace WrestlingStats
{
	
	public class PlayerView : UIView {
		
		public PlayerView (RectangleF frame) : base (frame)
		{
			// Your initialization code goes here
		}
		
		
		public override void Draw (RectangleF rect)
		{
			base.Draw (rect);
			UIButton name = UIButton.FromType (UIButtonType.RoundedRect);
			name.SetTitle ("name", UIControlState.Normal); 
			name.Frame = new RectangleF (  0 ,   0  , 50.0f , 50.0f );
			this.Add(name);
		}
		
	}

}

