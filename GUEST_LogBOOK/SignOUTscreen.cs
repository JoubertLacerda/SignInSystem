using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GUEST_LogBOOK
{
    [Activity(Label = "@string/SignOut")]
    public class SignOUTscreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SignOUT_Screen);
            Registered_Users();
        }

        public void Registered_Users ()
        {
            string FirstName = Intent.GetStringExtra("First Name" ?? "Info. not provided");
            string LastName = Intent.GetStringExtra("Last Name" ?? "Info. not provided");
            string HereToSee = Intent.GetStringExtra("Here To See" ?? "Info. not provided");

            var Fname = FindViewById<TextView>(Resource.Id.TxtFName);
            var Lname = FindViewById<TextView>(Resource.Id.TxtLName);
            var ToSee = FindViewById<TextView>(Resource.Id.TxtHereToSeeWho);

            Fname.Text = FirstName;
            Lname.Text = LastName;
            ToSee.Text = HereToSee;
        }
    }
}