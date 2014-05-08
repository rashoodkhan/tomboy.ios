//
//  AppDelegate.cs
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
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Tomboy;

namespace tomboy.ios
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;

		// UI Navigation Controller
		UINavigationController rootNavigationController;

		//Main Notes Screen Controller
		MainNotesScreen mainScreen;

		NoteTakingScreen noteScreen;

		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			rootNavigationController = new UINavigationController ();

			// If you have defined a root view controller, set it here:
			// window.RootViewController = myViewController;
			if (mainScreen == null)
				mainScreen = new MainNotesScreen ();
			//window.RootViewController = mainScreen;

			noteScreen = new NoteTakingScreen ();
			rootNavigationController.PushViewController (mainScreen, false);
			window.RootViewController = rootNavigationController;

			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

