//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace SWRevealViewControllerBinding {
	public unsafe static partial class SWRevealViewController_UIViewController  {
		[CompilerGenerated]
		const string selRevealViewController = "revealViewController";
		static readonly IntPtr selRevealViewControllerHandle = Selector.GetHandle ("revealViewController");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::MonoTouch.UIKit.UIViewController");
		
		[Export ("revealViewController")]
		[CompilerGenerated]
		public static SWRevealViewController RevealViewController (this global::MonoTouch.UIKit.UIViewController This)
		{
			return  Runtime.GetNSObject<SWRevealViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, selRevealViewControllerHandle));
		}
		
	} /* class SWRevealViewController_UIViewController */
}
