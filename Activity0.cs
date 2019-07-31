using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Drawing;
using System.Collections.Generic;
using System;
using Android.Content;


namespace _2
{
    [Activity(Label = "Activity0")]
    public class Activity0 : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            //Button buttonlogin = FindViewById<Button>(Resource.Id.useLogo);
            Button buttonvistior = FindViewById<Button>(Resource.Id.buttonVisitor);
            EditText editUserName = FindViewById<EditText>(Resource.Id.useLogo);
            EditText editPassword = FindViewById<EditText>(Resource.Id.password);
            buttonvistior.Click += (sender, e) =>
            {
                Intent intent1 = new Intent(this, typeof(Activity1));

                StartActivity(intent1);

            };

        }


        // Create your application here


    }
}