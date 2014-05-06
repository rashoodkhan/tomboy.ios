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
	[Register("SWRevealViewControllerDelegate", true)]
	[Model]
	public unsafe partial class SWRevealViewControllerDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SWRevealViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init), "init");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public SWRevealViewControllerDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SWRevealViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SWRevealViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("revealController:willMoveToPosition:")]
		[CompilerGenerated]
		public virtual void WillMoveToPosition (SWRevealViewController revealController, FrontViewPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:didMoveToPosition:")]
		[CompilerGenerated]
		public virtual void DidMoveToPosition (SWRevealViewController revealController, FrontViewPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:animateToPosition:")]
		[CompilerGenerated]
		public virtual void AnimateToPosition (SWRevealViewController revealController, FrontViewPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerPanGestureShouldBegin:")]
		[CompilerGenerated]
		public virtual bool PanGestureShouldBegin (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerTapGestureShouldBegin:")]
		[CompilerGenerated]
		public virtual bool TapGestureShouldBegin (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerPanGestureBegan:")]
		[CompilerGenerated]
		public virtual void PanGestureBegan (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerPanGestureEnded:")]
		[CompilerGenerated]
		public virtual void PanGestureEnded (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureBeganFromLocation:progress:")]
		[CompilerGenerated]
		public virtual void PanGestureBeganFromLocation (SWRevealViewController revealController, float location, float progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureMovedToLocation:progress:")]
		[CompilerGenerated]
		public virtual void PanGestureMovedToLocation (SWRevealViewController revealController, float location, float progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureEndedToLocation:progress:")]
		[CompilerGenerated]
		public virtual void PanGestureEndedToLocation (SWRevealViewController revealController, float location, float progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:willAddViewController:forOperation:animated:")]
		[CompilerGenerated]
		public virtual void WillAddViewController (SWRevealViewController revealController, global::MonoTouch.UIKit.UIViewController viewController, SWRevealControllerOperation operation, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:didAddViewController:forOperation:animated:")]
		[CompilerGenerated]
		public virtual void DidAddViewController (SWRevealViewController revealController, global::MonoTouch.UIKit.UIViewController viewController, SWRevealControllerOperation operation, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:animationControllerForOperation:fromViewController:toViewController:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewControllerAnimatedTransitioning AnimationControllerForOperation (SWRevealViewController revealController, SWRevealControllerOperation operation, global::MonoTouch.UIKit.UIViewController fromVC, global::MonoTouch.UIKit.UIViewController toVC)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class SWRevealViewControllerDelegate */
}
