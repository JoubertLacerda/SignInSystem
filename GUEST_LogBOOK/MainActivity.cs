using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;

namespace GUEST_LogBOOK
{    

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            SignIn();
        }
        public void SignIn()
        {
            //TODO:add the method for the sign in screen here, screen should contain a field the guest to type their name, and who they are visiting. a number should be automaticly assigned to each guest. the hour they signed in should also be saved. while the guest is signed in the information should be displayed on the 'Sign Out' screen.
            var BTN_IN = FindViewById<Button>(Resource.Id.BTN_signIN);
            BTN_IN.Click += delegate
            {
                StartActivity(typeof(SignINscreen));
            };
        }
        public void SignOUT()
        {
            //TODO: add the method for the sign OUT screen here, should be in a GridView, user to select their name and click a button to sign out, GriView to grey out the entire row containing the name, date, number of the guest. the hour they signed out should be saved. all this info to be saved on a .TXT file
            var BTN_OUT = FindViewById<Button>(Resource.Id.BTN_signOUT);
            BTN_OUT.Click += delegate
            {
                StartActivity(typeof(SignOUTscreen));
            };
        }
    }
    
}