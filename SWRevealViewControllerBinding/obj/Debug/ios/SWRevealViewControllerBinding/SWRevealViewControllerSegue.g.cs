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
	[Register("SWRevealViewControllerSegue", true)]
	public unsafe partial class SWRevealViewControllerSegue : global::MonoTouch.UIKit.UIStoryboardSegue {
		[CompilerGenerated]
		const string selPerformBlock = "performBlock";
		static readonly IntPtr selPerformBlockHandle = Selector.GetHandle ("performBlock");
		[CompilerGenerated]
		const string selSetPerformBlock_ = "setPerformBlock:";
		static readonly IntPtr selSetPerformBlock_Handle = Selector.GetHandle ("setPerformBlock:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SWRevealViewControllerSegue");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SWRevealViewControllerSegue () : base (NSObjectFlag.Empty)
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
		public SWRevealViewControllerSegue (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SWRevealViewControllerSegue (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SWRevealViewControllerSegue (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public unsafe virtual SegueCallback PerformDelegate {
			[Export ("performBlock", ArgumentSemantic.Retain)]
			get {
				BlockLiteral *ret;
				if (IsDirectBinding) {
					ret = (BlockLiteral *)MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPerformBlockHandle);
				} else {
					ret = (BlockLiteral *)MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPerformBlockHandle);
				}
				if (ret == null)
					return null;
				return (SegueCallback) (ret->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (ret->global_handle).Target : GCHandle.FromIntPtr (ret->local_handle).Target);
			}
			
			[Export ("setPerformBlock:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDSegueCallback.Handler, value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPerformBlock_Handle, (IntPtr) block_ptr_value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPerformBlock_Handle, (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
	} /* class SWRevealViewControllerSegue */
	public delegate void SegueCallback (SWRevealViewControllerSegue segue, global::MonoTouch.UIKit.UIViewController svc, global::MonoTouch.UIKit.UIViewController dvc);
}
