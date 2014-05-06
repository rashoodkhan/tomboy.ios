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
	[Register("SWRevealViewController", true)]
	public unsafe partial class SWRevealViewController : global::MonoTouch.UIKit.UIViewController {
		[CompilerGenerated]
		const string selRearViewController = "rearViewController";
		static readonly IntPtr selRearViewControllerHandle = Selector.GetHandle ("rearViewController");
		[CompilerGenerated]
		const string selSetRearViewController_ = "setRearViewController:";
		static readonly IntPtr selSetRearViewController_Handle = Selector.GetHandle ("setRearViewController:");
		[CompilerGenerated]
		const string selRightViewController = "rightViewController";
		static readonly IntPtr selRightViewControllerHandle = Selector.GetHandle ("rightViewController");
		[CompilerGenerated]
		const string selSetRightViewController_ = "setRightViewController:";
		static readonly IntPtr selSetRightViewController_Handle = Selector.GetHandle ("setRightViewController:");
		[CompilerGenerated]
		const string selFrontViewController = "frontViewController";
		static readonly IntPtr selFrontViewControllerHandle = Selector.GetHandle ("frontViewController");
		[CompilerGenerated]
		const string selSetFrontViewController_ = "setFrontViewController:";
		static readonly IntPtr selSetFrontViewController_Handle = Selector.GetHandle ("setFrontViewController:");
		[CompilerGenerated]
		const string selFrontViewPosition = "frontViewPosition";
		static readonly IntPtr selFrontViewPositionHandle = Selector.GetHandle ("frontViewPosition");
		[CompilerGenerated]
		const string selSetFrontViewPosition_ = "setFrontViewPosition:";
		static readonly IntPtr selSetFrontViewPosition_Handle = Selector.GetHandle ("setFrontViewPosition:");
		[CompilerGenerated]
		const string selPanGestureRecognizer = "panGestureRecognizer";
		static readonly IntPtr selPanGestureRecognizerHandle = Selector.GetHandle ("panGestureRecognizer");
		[CompilerGenerated]
		const string selTapGestureRecognizer = "tapGestureRecognizer";
		static readonly IntPtr selTapGestureRecognizerHandle = Selector.GetHandle ("tapGestureRecognizer");
		[CompilerGenerated]
		const string selRearViewRevealWidth = "rearViewRevealWidth";
		static readonly IntPtr selRearViewRevealWidthHandle = Selector.GetHandle ("rearViewRevealWidth");
		[CompilerGenerated]
		const string selSetRearViewRevealWidth_ = "setRearViewRevealWidth:";
		static readonly IntPtr selSetRearViewRevealWidth_Handle = Selector.GetHandle ("setRearViewRevealWidth:");
		[CompilerGenerated]
		const string selRightViewRevealWidth = "rightViewRevealWidth";
		static readonly IntPtr selRightViewRevealWidthHandle = Selector.GetHandle ("rightViewRevealWidth");
		[CompilerGenerated]
		const string selSetRightViewRevealWidth_ = "setRightViewRevealWidth:";
		static readonly IntPtr selSetRightViewRevealWidth_Handle = Selector.GetHandle ("setRightViewRevealWidth:");
		[CompilerGenerated]
		const string selRearViewRevealOverdraw = "rearViewRevealOverdraw";
		static readonly IntPtr selRearViewRevealOverdrawHandle = Selector.GetHandle ("rearViewRevealOverdraw");
		[CompilerGenerated]
		const string selSetRearViewRevealOverdraw_ = "setRearViewRevealOverdraw:";
		static readonly IntPtr selSetRearViewRevealOverdraw_Handle = Selector.GetHandle ("setRearViewRevealOverdraw:");
		[CompilerGenerated]
		const string selRightViewRevealOverdraw = "rightViewRevealOverdraw";
		static readonly IntPtr selRightViewRevealOverdrawHandle = Selector.GetHandle ("rightViewRevealOverdraw");
		[CompilerGenerated]
		const string selSetRightViewRevealOverdraw_ = "setRightViewRevealOverdraw:";
		static readonly IntPtr selSetRightViewRevealOverdraw_Handle = Selector.GetHandle ("setRightViewRevealOverdraw:");
		[CompilerGenerated]
		const string selRearViewRevealDisplacement = "rearViewRevealDisplacement";
		static readonly IntPtr selRearViewRevealDisplacementHandle = Selector.GetHandle ("rearViewRevealDisplacement");
		[CompilerGenerated]
		const string selSetRearViewRevealDisplacement_ = "setRearViewRevealDisplacement:";
		static readonly IntPtr selSetRearViewRevealDisplacement_Handle = Selector.GetHandle ("setRearViewRevealDisplacement:");
		[CompilerGenerated]
		const string selRightViewRevealDisplacement = "rightViewRevealDisplacement";
		static readonly IntPtr selRightViewRevealDisplacementHandle = Selector.GetHandle ("rightViewRevealDisplacement");
		[CompilerGenerated]
		const string selSetRightViewRevealDisplacement_ = "setRightViewRevealDisplacement:";
		static readonly IntPtr selSetRightViewRevealDisplacement_Handle = Selector.GetHandle ("setRightViewRevealDisplacement:");
		[CompilerGenerated]
		const string selDraggableBorderWidth = "draggableBorderWidth";
		static readonly IntPtr selDraggableBorderWidthHandle = Selector.GetHandle ("draggableBorderWidth");
		[CompilerGenerated]
		const string selSetDraggableBorderWidth_ = "setDraggableBorderWidth:";
		static readonly IntPtr selSetDraggableBorderWidth_Handle = Selector.GetHandle ("setDraggableBorderWidth:");
		[CompilerGenerated]
		const string selBounceBackOnOverdraw = "bounceBackOnOverdraw";
		static readonly IntPtr selBounceBackOnOverdrawHandle = Selector.GetHandle ("bounceBackOnOverdraw");
		[CompilerGenerated]
		const string selSetBounceBackOnOverdraw_ = "setBounceBackOnOverdraw:";
		static readonly IntPtr selSetBounceBackOnOverdraw_Handle = Selector.GetHandle ("setBounceBackOnOverdraw:");
		[CompilerGenerated]
		const string selBounceBackOnLeftOverdraw = "bounceBackOnLeftOverdraw";
		static readonly IntPtr selBounceBackOnLeftOverdrawHandle = Selector.GetHandle ("bounceBackOnLeftOverdraw");
		[CompilerGenerated]
		const string selSetBounceBackOnLeftOverdraw_ = "setBounceBackOnLeftOverdraw:";
		static readonly IntPtr selSetBounceBackOnLeftOverdraw_Handle = Selector.GetHandle ("setBounceBackOnLeftOverdraw:");
		[CompilerGenerated]
		const string selStableDragOnOverdraw = "stableDragOnOverdraw";
		static readonly IntPtr selStableDragOnOverdrawHandle = Selector.GetHandle ("stableDragOnOverdraw");
		[CompilerGenerated]
		const string selSetStableDragOnOverdraw_ = "setStableDragOnOverdraw:";
		static readonly IntPtr selSetStableDragOnOverdraw_Handle = Selector.GetHandle ("setStableDragOnOverdraw:");
		[CompilerGenerated]
		const string selStableDragOnLeftOverdraw = "stableDragOnLeftOverdraw";
		static readonly IntPtr selStableDragOnLeftOverdrawHandle = Selector.GetHandle ("stableDragOnLeftOverdraw");
		[CompilerGenerated]
		const string selSetStableDragOnLeftOverdraw_ = "setStableDragOnLeftOverdraw:";
		static readonly IntPtr selSetStableDragOnLeftOverdraw_Handle = Selector.GetHandle ("setStableDragOnLeftOverdraw:");
		[CompilerGenerated]
		const string selPresentFrontViewHierarchically = "presentFrontViewHierarchically";
		static readonly IntPtr selPresentFrontViewHierarchicallyHandle = Selector.GetHandle ("presentFrontViewHierarchically");
		[CompilerGenerated]
		const string selSetPresentFrontViewHierarchically_ = "setPresentFrontViewHierarchically:";
		static readonly IntPtr selSetPresentFrontViewHierarchically_Handle = Selector.GetHandle ("setPresentFrontViewHierarchically:");
		[CompilerGenerated]
		const string selQuickFlickVelocity = "quickFlickVelocity";
		static readonly IntPtr selQuickFlickVelocityHandle = Selector.GetHandle ("quickFlickVelocity");
		[CompilerGenerated]
		const string selSetQuickFlickVelocity_ = "setQuickFlickVelocity:";
		static readonly IntPtr selSetQuickFlickVelocity_Handle = Selector.GetHandle ("setQuickFlickVelocity:");
		[CompilerGenerated]
		const string selToggleAnimationDuration = "toggleAnimationDuration";
		static readonly IntPtr selToggleAnimationDurationHandle = Selector.GetHandle ("toggleAnimationDuration");
		[CompilerGenerated]
		const string selSetToggleAnimationDuration_ = "setToggleAnimationDuration:";
		static readonly IntPtr selSetToggleAnimationDuration_Handle = Selector.GetHandle ("setToggleAnimationDuration:");
		[CompilerGenerated]
		const string selReplaceViewAnimationDuration = "replaceViewAnimationDuration";
		static readonly IntPtr selReplaceViewAnimationDurationHandle = Selector.GetHandle ("replaceViewAnimationDuration");
		[CompilerGenerated]
		const string selSetReplaceViewAnimationDuration_ = "setReplaceViewAnimationDuration:";
		static readonly IntPtr selSetReplaceViewAnimationDuration_Handle = Selector.GetHandle ("setReplaceViewAnimationDuration:");
		[CompilerGenerated]
		const string selFrontViewShadowRadius = "frontViewShadowRadius";
		static readonly IntPtr selFrontViewShadowRadiusHandle = Selector.GetHandle ("frontViewShadowRadius");
		[CompilerGenerated]
		const string selSetFrontViewShadowRadius_ = "setFrontViewShadowRadius:";
		static readonly IntPtr selSetFrontViewShadowRadius_Handle = Selector.GetHandle ("setFrontViewShadowRadius:");
		[CompilerGenerated]
		const string selFrontViewShadowOffset = "frontViewShadowOffset";
		static readonly IntPtr selFrontViewShadowOffsetHandle = Selector.GetHandle ("frontViewShadowOffset");
		[CompilerGenerated]
		const string selSetFrontViewShadowOffset_ = "setFrontViewShadowOffset:";
		static readonly IntPtr selSetFrontViewShadowOffset_Handle = Selector.GetHandle ("setFrontViewShadowOffset:");
		[CompilerGenerated]
		const string selFrontViewShadowOpacity = "frontViewShadowOpacity";
		static readonly IntPtr selFrontViewShadowOpacityHandle = Selector.GetHandle ("frontViewShadowOpacity");
		[CompilerGenerated]
		const string selSetFrontViewShadowOpacity_ = "setFrontViewShadowOpacity:";
		static readonly IntPtr selSetFrontViewShadowOpacity_Handle = Selector.GetHandle ("setFrontViewShadowOpacity:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selInitWithRearViewControllerFrontViewController_ = "initWithRearViewController:frontViewController:";
		static readonly IntPtr selInitWithRearViewControllerFrontViewController_Handle = Selector.GetHandle ("initWithRearViewController:frontViewController:");
		[CompilerGenerated]
		const string selSetRearViewControllerAnimated_ = "setRearViewController:animated:";
		static readonly IntPtr selSetRearViewControllerAnimated_Handle = Selector.GetHandle ("setRearViewController:animated:");
		[CompilerGenerated]
		const string selSetRightViewControllerAnimated_ = "setRightViewController:animated:";
		static readonly IntPtr selSetRightViewControllerAnimated_Handle = Selector.GetHandle ("setRightViewController:animated:");
		[CompilerGenerated]
		const string selSetFrontViewControllerAnimated_ = "setFrontViewController:animated:";
		static readonly IntPtr selSetFrontViewControllerAnimated_Handle = Selector.GetHandle ("setFrontViewController:animated:");
		[CompilerGenerated]
		const string selPushFrontViewControllerAnimated_ = "pushFrontViewController:animated:";
		static readonly IntPtr selPushFrontViewControllerAnimated_Handle = Selector.GetHandle ("pushFrontViewController:animated:");
		[CompilerGenerated]
		const string selSetFrontViewPositionAnimated_ = "setFrontViewPosition:animated:";
		static readonly IntPtr selSetFrontViewPositionAnimated_Handle = Selector.GetHandle ("setFrontViewPosition:animated:");
		[CompilerGenerated]
		const string selRevealToggleAnimated_ = "revealToggleAnimated:";
		static readonly IntPtr selRevealToggleAnimated_Handle = Selector.GetHandle ("revealToggleAnimated:");
		[CompilerGenerated]
		const string selRightRevealToggleAnimated_ = "rightRevealToggleAnimated:";
		static readonly IntPtr selRightRevealToggleAnimated_Handle = Selector.GetHandle ("rightRevealToggleAnimated:");
		[CompilerGenerated]
		const string selRevealToggle_ = "revealToggle:";
		static readonly IntPtr selRevealToggle_Handle = Selector.GetHandle ("revealToggle:");
		[CompilerGenerated]
		const string selRightRevealToggle_ = "rightRevealToggle:";
		static readonly IntPtr selRightRevealToggle_Handle = Selector.GetHandle ("rightRevealToggle:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SWRevealViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SWRevealViewController () : base (NSObjectFlag.Empty)
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
		public SWRevealViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SWRevealViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SWRevealViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRearViewController:frontViewController:")]
		[CompilerGenerated]
		public SWRevealViewController (global::MonoTouch.UIKit.UIViewController rearViewController, global::MonoTouch.UIKit.UIViewController frontViewController)
			: base (NSObjectFlag.Empty)
		{
			if (rearViewController == null)
				throw new ArgumentNullException ("rearViewController");
			if (frontViewController == null)
				throw new ArgumentNullException ("frontViewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithRearViewControllerFrontViewController_Handle, rearViewController.Handle, frontViewController.Handle), "initWithRearViewController:frontViewController:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithRearViewControllerFrontViewController_Handle, rearViewController.Handle, frontViewController.Handle), "initWithRearViewController:frontViewController:");
			}
		}
		
		[Export ("setRearViewController:animated:")]
		[CompilerGenerated]
		public virtual void SetRearViewController (global::MonoTouch.UIKit.UIViewController rearViewController, bool animated)
		{
			if (rearViewController == null)
				throw new ArgumentNullException ("rearViewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selSetRearViewControllerAnimated_Handle, rearViewController.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selSetRearViewControllerAnimated_Handle, rearViewController.Handle, animated);
			}
		}
		
		[Export ("setRightViewController:animated:")]
		[CompilerGenerated]
		public virtual void SetRightViewController (global::MonoTouch.UIKit.UIViewController rightViewController, bool animated)
		{
			if (rightViewController == null)
				throw new ArgumentNullException ("rightViewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selSetRightViewControllerAnimated_Handle, rightViewController.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selSetRightViewControllerAnimated_Handle, rightViewController.Handle, animated);
			}
		}
		
		[Export ("setFrontViewController:animated:")]
		[CompilerGenerated]
		public virtual void SetFrontViewController (global::MonoTouch.UIKit.UIViewController frontViewController, bool animated)
		{
			if (frontViewController == null)
				throw new ArgumentNullException ("frontViewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selSetFrontViewControllerAnimated_Handle, frontViewController.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selSetFrontViewControllerAnimated_Handle, frontViewController.Handle, animated);
			}
		}
		
		[Export ("pushFrontViewController:animated:")]
		[CompilerGenerated]
		public virtual void PushFrontViewController (global::MonoTouch.UIKit.UIViewController frontViewController, bool animated)
		{
			if (frontViewController == null)
				throw new ArgumentNullException ("frontViewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selPushFrontViewControllerAnimated_Handle, frontViewController.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selPushFrontViewControllerAnimated_Handle, frontViewController.Handle, animated);
			}
		}
		
		[Export ("setFrontViewPosition:animated:")]
		[CompilerGenerated]
		public virtual void SetFrontViewPosition (FrontViewPosition frontViewPosition, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int_bool (this.Handle, selSetFrontViewPositionAnimated_Handle, (int)frontViewPosition, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_bool (this.SuperHandle, selSetFrontViewPositionAnimated_Handle, (int)frontViewPosition, animated);
			}
		}
		
		[Export ("revealToggleAnimated:")]
		[CompilerGenerated]
		public virtual void RevealToggleAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selRevealToggleAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selRevealToggleAnimated_Handle, animated);
			}
		}
		
		[Export ("rightRevealToggleAnimated:")]
		[CompilerGenerated]
		public virtual void RightRevealToggleAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selRightRevealToggleAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selRightRevealToggleAnimated_Handle, animated);
			}
		}
		
		[Export ("revealToggle:")]
		[CompilerGenerated]
		public virtual void RevealToggle (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRevealToggle_Handle, sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRevealToggle_Handle, sender.Handle);
			}
		}
		
		[Export ("rightRevealToggle:")]
		[CompilerGenerated]
		public virtual void RightRevealToggle (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRightRevealToggle_Handle, sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRightRevealToggle_Handle, sender.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_RearViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController RearViewController {
			[Export ("rearViewController", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRearViewControllerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRearViewControllerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RearViewController_var = ret;
				return ret;
			}
			
			[Export ("setRearViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRearViewController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRearViewController_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RearViewController_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_RightViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController RightViewController {
			[Export ("rightViewController", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRightViewControllerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRightViewControllerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RightViewController_var = ret;
				return ret;
			}
			
			[Export ("setRightViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRightViewController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRightViewController_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RightViewController_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_FrontViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController FrontViewController {
			[Export ("frontViewController", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFrontViewControllerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFrontViewControllerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FrontViewController_var = ret;
				return ret;
			}
			
			[Export ("setFrontViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFrontViewController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFrontViewController_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FrontViewController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual FrontViewPosition FrontViewPosition {
			[Export ("frontViewPosition")]
			get {
				if (IsDirectBinding) {
					return (FrontViewPosition) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selFrontViewPositionHandle);
				} else {
					return (FrontViewPosition) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selFrontViewPositionHandle);
				}
			}
			
			[Export ("setFrontViewPosition:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetFrontViewPosition_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetFrontViewPosition_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PanGestureRecognizer_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIPanGestureRecognizer PanGestureRecognizer {
			[Export ("panGestureRecognizer")]
			get {
				global::MonoTouch.UIKit.UIPanGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIPanGestureRecognizer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPanGestureRecognizerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIPanGestureRecognizer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPanGestureRecognizerHandle));
				}
				MarkDirty ();
				__mt_PanGestureRecognizer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_TapGestureRecognizer_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UITapGestureRecognizer TapGestureRecognizer {
			[Export ("tapGestureRecognizer")]
			get {
				global::MonoTouch.UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UITapGestureRecognizer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTapGestureRecognizerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UITapGestureRecognizer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTapGestureRecognizerHandle));
				}
				MarkDirty ();
				__mt_TapGestureRecognizer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual float RearViewRevealWidth {
			[Export ("rearViewRevealWidth")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRearViewRevealWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRearViewRevealWidthHandle);
				}
			}
			
			[Export ("setRearViewRevealWidth:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRearViewRevealWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRearViewRevealWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RightViewRevealWidth {
			[Export ("rightViewRevealWidth")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRightViewRevealWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRightViewRevealWidthHandle);
				}
			}
			
			[Export ("setRightViewRevealWidth:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRightViewRevealWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRightViewRevealWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RearViewRevealOverdraw {
			[Export ("rearViewRevealOverdraw")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRearViewRevealOverdrawHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRearViewRevealOverdrawHandle);
				}
			}
			
			[Export ("setRearViewRevealOverdraw:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRearViewRevealOverdraw_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRearViewRevealOverdraw_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RightViewRevealOverdraw {
			[Export ("rightViewRevealOverdraw")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRightViewRevealOverdrawHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRightViewRevealOverdrawHandle);
				}
			}
			
			[Export ("setRightViewRevealOverdraw:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRightViewRevealOverdraw_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRightViewRevealOverdraw_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RearViewRevealDisplacement {
			[Export ("rearViewRevealDisplacement")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRearViewRevealDisplacementHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRearViewRevealDisplacementHandle);
				}
			}
			
			[Export ("setRearViewRevealDisplacement:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRearViewRevealDisplacement_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRearViewRevealDisplacement_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RightViewRevealDisplacement {
			[Export ("rightViewRevealDisplacement")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRightViewRevealDisplacementHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRightViewRevealDisplacementHandle);
				}
			}
			
			[Export ("setRightViewRevealDisplacement:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRightViewRevealDisplacement_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRightViewRevealDisplacement_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float DraggableBorderWidth {
			[Export ("draggableBorderWidth")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selDraggableBorderWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selDraggableBorderWidthHandle);
				}
			}
			
			[Export ("setDraggableBorderWidth:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetDraggableBorderWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetDraggableBorderWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool BounceBackOnOverdraw {
			[Export ("bounceBackOnOverdraw")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBounceBackOnOverdrawHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selBounceBackOnOverdrawHandle);
				}
			}
			
			[Export ("setBounceBackOnOverdraw:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetBounceBackOnOverdraw_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetBounceBackOnOverdraw_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool BounceBackOnLeftOverdraw {
			[Export ("bounceBackOnLeftOverdraw")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBounceBackOnLeftOverdrawHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selBounceBackOnLeftOverdrawHandle);
				}
			}
			
			[Export ("setBounceBackOnLeftOverdraw:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetBounceBackOnLeftOverdraw_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetBounceBackOnLeftOverdraw_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool StableDragOnOverdraw {
			[Export ("stableDragOnOverdraw")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStableDragOnOverdrawHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selStableDragOnOverdrawHandle);
				}
			}
			
			[Export ("setStableDragOnOverdraw:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetStableDragOnOverdraw_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetStableDragOnOverdraw_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool StableDragOnLeftOverdraw {
			[Export ("stableDragOnLeftOverdraw")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStableDragOnLeftOverdrawHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selStableDragOnLeftOverdrawHandle);
				}
			}
			
			[Export ("setStableDragOnLeftOverdraw:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetStableDragOnLeftOverdraw_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetStableDragOnLeftOverdraw_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PresentFrontViewHierarchically {
			[Export ("presentFrontViewHierarchically")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPresentFrontViewHierarchicallyHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selPresentFrontViewHierarchicallyHandle);
				}
			}
			
			[Export ("setPresentFrontViewHierarchically:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPresentFrontViewHierarchically_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPresentFrontViewHierarchically_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float QuickFlickVelocity {
			[Export ("quickFlickVelocity")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selQuickFlickVelocityHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selQuickFlickVelocityHandle);
				}
			}
			
			[Export ("setQuickFlickVelocity:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetQuickFlickVelocity_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetQuickFlickVelocity_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double ToggleAnimationDuration {
			[Export ("toggleAnimationDuration")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selToggleAnimationDurationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selToggleAnimationDurationHandle);
				}
			}
			
			[Export ("setToggleAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetToggleAnimationDuration_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetToggleAnimationDuration_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double ReplaceViewAnimationDuration {
			[Export ("replaceViewAnimationDuration")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selReplaceViewAnimationDurationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selReplaceViewAnimationDurationHandle);
				}
			}
			
			[Export ("setReplaceViewAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetReplaceViewAnimationDuration_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetReplaceViewAnimationDuration_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float FrontViewShadowRadius {
			[Export ("frontViewShadowRadius")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFrontViewShadowRadiusHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selFrontViewShadowRadiusHandle);
				}
			}
			
			[Export ("setFrontViewShadowRadius:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFrontViewShadowRadius_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetFrontViewShadowRadius_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.SizeF FrontViewShadowOffset {
			[Export ("frontViewShadowOffset", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selFrontViewShadowOffsetHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selFrontViewShadowOffsetHandle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selFrontViewShadowOffsetHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selFrontViewShadowOffsetHandle);
					}
				}
				return ret;
			}
			
			[Export ("setFrontViewShadowOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetFrontViewShadowOffset_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetFrontViewShadowOffset_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float FrontViewShadowOpacity {
			[Export ("frontViewShadowOpacity")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFrontViewShadowOpacityHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selFrontViewShadowOpacityHandle);
				}
			}
			
			[Export ("setFrontViewShadowOpacity:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFrontViewShadowOpacity_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetFrontViewShadowOpacity_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual SWRevealViewControllerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				SWRevealViewControllerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SWRevealViewControllerDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<SWRevealViewControllerDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_RearViewController_var = null;
				__mt_RightViewController_var = null;
				__mt_FrontViewController_var = null;
				__mt_PanGestureRecognizer_var = null;
				__mt_TapGestureRecognizer_var = null;
				__mt_Delegate_var = null;
			}
		}
	} /* class SWRevealViewController */
}
