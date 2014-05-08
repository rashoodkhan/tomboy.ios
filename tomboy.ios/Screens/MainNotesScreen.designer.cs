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
	[Register ("MainNotesScreen")]
	partial class MainNotesScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem AddNoteButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (AddNoteButton != null) {
				AddNoteButton.Dispose ();
				AddNoteButton = null;
			}
		}
	}
}
