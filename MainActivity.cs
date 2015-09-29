using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Homework
{
	[Activity (Label = "Homework", MainLauncher = true, Icon = "@drawable/icon")]
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
			EditText editText1 = FindViewById<EditText> (Resource.Id.editText1);
			EditText editText2 = FindViewById<EditText> (Resource.Id.editText2);
			TextView textView1 = FindViewById<TextView> (Resource.Id.textView1);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);

				int a , b;
				a = int.Parse(editText1.Text);
				b = int.Parse(editText2.Text);

				textView1.Text = (a + b).ToString();
			};
		}
	}
}


