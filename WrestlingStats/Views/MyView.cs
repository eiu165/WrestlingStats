using System;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.CoreGraphics;

namespace WrestlingStats
{
	public class MyView : UIView {
		
		public MyView (RectangleF frame) : base (frame)
		{
			// Your initialization code goes here
		}


		public override void Draw (RectangleF rect)
		{
			base.Draw (rect);
			
			var context = UIGraphics.GetCurrentContext ();
			
			context.SetLineWidth(4);
			UIColor.Red.SetFill ();
			UIColor.Blue.SetStroke ();
			
			var path = new CGPath ();
			
			path.AddLines(new PointF[]{
				new PointF(100,200),
				new PointF(160,100), 
				new PointF(220,200)});
			
			path.CloseSubpath();
			
			context.AddPath(path);		
			context.DrawPath(CGPathDrawingMode.FillStroke);
		}

	}

}

