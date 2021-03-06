﻿//
//  MainNotesScreen.cs
//
//  Author:
//       Rashid Khan <rashood.khan@gmail.com>
//
//  Copyright (c) 2014 Rashid Khan
//
//  This library is free software; you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as
//  published by the Free Software Foundation; either version 2.1 of the
//  License, or (at your option) any later version.
//
//  This library is distributed in the hope that it will be useful, but
//  WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//  Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public
//  License along with this library; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace tomboy.ios
{
	public partial class MainNotesScreen : UIViewController
	{
		//Note Taking Screen Controller
		NoteTakingScreen noteScreen;

		public MainNotesScreen () : base ("MainNotesScreen", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.AddNoteButton.Clicked += (sender, e) => {
				if(noteScreen == null)
					noteScreen = new NoteTakingScreen ();
				this.NavigationController.PushViewController(noteScreen, true);
			};
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.SetNavigationBarHidden (true, animated);
		}
			
	}
}

