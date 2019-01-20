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
    [Activity(Label = "@string/SignIN")]
    public class SignINscreen : Activity
    {  
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SignIN_Screen);
            BackBTN();
            logged();

        }

        public void BackBTN()
        {
            //clicking the back button to go to main screen.
            var BackBTN = FindViewById<Button>(Resource.Id.BTN_Back);
            BackBTN.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }
        public void logged()
        {
            // capture the information entered, saves it and sends it to the LogOut page to be displayed.
            Button Register = FindViewById<Button>(Resource.Id.BTN_Register);
            Register.Click += delegate
            {
                //First Name.
                EditText TxtFname = FindViewById<EditText>(Resource.Id.TxtFName);
                string FName = TxtFname.Text;

                //Last name.
                EditText TxtLName = FindViewById<EditText>(Resource.Id.TxtLName);
                string LName = TxtLName.Text;

                //who is the guest here to see?.
                EditText TxtHereToSeeWho = FindViewById<EditText>(Resource.Id.TxtHereToSeeWho);
                string Visiting = TxtHereToSeeWho.Text;

                //Visitor number,TODO this to be auto asigned
                var GuestNo = FindViewById<TextView>(Resource.Id.TxtGuestNo);
                //Time Visitor arrived.
                var TimeIn = FindViewById<TextView>(Resource.Id.TimeIn);

                //create a toast notification to confirm the submission
                Android.Widget.Toast.MakeText(this, "Logged In", ToastLength.Short).Show();

                //clear text boxes of the text after info was entered and saved.
                TxtFname.Text = "";
                TxtLName.Text = "";
                TxtHereToSeeWho.Text = "";
            };
        }
       
    }
}