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
        public void GuestRegister()
        {
            //First Name.
            var Edit_Fname = FindViewById<EditText>(Resource.Id.TxtFname); 
            //Last name.
            var Edit_Lname = FindViewById<EditText>(Resource.Id.TxtLName);
            //who is the guest here to see?.
            var Edit_HereToSee = FindViewById<EditText>(Resource.Id.TxtHereToSeeWho);
            //Visitor number,TODO this to be auto asigned
            var GuestNo = FindViewById<TextView>(Resource.Id.TxtGuestNo);
            //Time Visitor arrived.
            var TimeIn = FindViewById<TextView>(Resource.Id.TimeIn);

           
                Intent RegisterUser = new Intent(this, typeof(SignOUTscreen));
            RegisterUser.PutExtra("First Name", Edit_Fname.Text);
            RegisterUser.PutExtra("Last Name", Edit_Lname.Text);
            RegisterUser.PutExtra("Here to See", Edit_HereToSee.Text);
            RegisterUser.PutExtra("Guest No.", GuestNo.Text);
            RegisterUser.PutExtra("Arrived At", TimeIn.Text);
            

            
            
        }
    }
}