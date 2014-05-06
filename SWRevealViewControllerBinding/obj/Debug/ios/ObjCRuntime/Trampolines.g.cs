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

namespace MonoTouch.ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DSegueCallback (IntPtr block, IntPtr segue, IntPtr svc, IntPtr dvc);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSegueCallback {
			static internal readonly DSegueCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSegueCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr segue, IntPtr svc, IntPtr dvc) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::SWRevealViewControllerBinding.SegueCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ( Runtime.GetNSObject<SWRevealViewControllerBinding.SWRevealViewControllerSegue> (segue),  Runtime.GetNSObject<MonoTouch.UIKit.UIViewController> (svc),  Runtime.GetNSObject<MonoTouch.UIKit.UIViewController> (dvc));
			}
		} /* class SDSegueCallback */
		
		internal class NIDSegueCallback {
			IntPtr blockPtr;
			DSegueCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDSegueCallback (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DSegueCallback) Runtime.GetDelegateForBlock (block->invoke, typeof (DSegueCallback));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::SWRevealViewControllerBinding.SegueCallback Create (IntPtr block)
			{
				return new NIDSegueCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::SWRevealViewControllerBinding.SWRevealViewControllerSegue segue, global::MonoTouch.UIKit.UIViewController svc, global::MonoTouch.UIKit.UIViewController dvc)
			{
				if (segue == null)
					throw new ArgumentNullException ("segue");
				if (svc == null)
					throw new ArgumentNullException ("svc");
				if (dvc == null)
					throw new ArgumentNullException ("dvc");
				invoker (blockPtr, segue.Handle, svc.Handle, dvc.Handle);
			}
		} /* class NIDSegueCallback */
	}
}
