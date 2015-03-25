﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HelloDojo
{
	[Activity (Label = "HelloDojo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			var userName = FindViewById<TextView> (Resource.Id.userName);
			var welcome = FindViewById<TextView> (Resource.Id.welcome);
			
			button.Click += delegate {
				welcome.Text = string.Format ("Welcome, {0}", userName.Text);
			};
		}
	}
}


