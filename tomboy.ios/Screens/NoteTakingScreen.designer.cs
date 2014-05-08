// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace tomboy.ios
{
	[Register ("NoteTakingScreen")]
	partial class NoteTakingScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem BackButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIWebView TextEditor { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TextEditor != null) {
				TextEditor.Dispose ();
				TextEditor = null;
			}

			if (BackButton != null) {
				BackButton.Dispose ();
				BackButton = null;
			}
		}
	}
}
