// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace WrestlingStats
{
	[Register ("EditNameScreen")]
	partial class EditNameScreen
	{
		[Outlet]
		MonoTouch.UIKit.UITextField name { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton save { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (name != null) {
				name.Dispose ();
				name = null;
			}

			if (save != null) {
				save.Dispose ();
				save = null;
			}
		}
	}
}
