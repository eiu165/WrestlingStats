using System.Collections.Generic;
using System.Drawing;
using MonoTouch.UIKit;

namespace WrestlingStats
{
	public class MatchScreen : UIViewController
	{
		UIView _overview;
		UIScrollView _detail; 
		 
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad (); 
			float overViewHeight = 190.0f; 
			AddOverview (overViewHeight); 
			AddDetails (overViewHeight);  
		}
		
		void AddOverview (float overViewHeight)
		{
			_overview = new UIView {
				Frame = new RectangleF (0, 0, View.Frame.Width, overViewHeight),
				BackgroundColor = UIColor.Orange
			};
			//_overview.Add (new PlayerControl ());
			View.AddSubview (_overview);
		}

		void AddDetails (float overViewHeight)
		{
			float detailHeight = View.Frame.Height - _overview.Frame.Height;
			_detail = new UIScrollView {
				Frame = new RectangleF (0, overViewHeight, View.Frame.Width, detailHeight),
				ContentSize = new SizeF (View.Frame.Width * 2, detailHeight),
				BackgroundColor = UIColor.DarkGray,
				AutoresizingMask = UIViewAutoresizing.FlexibleWidth
			};
			View.AddSubview (_detail);
		}
	}
}