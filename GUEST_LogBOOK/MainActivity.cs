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
using SQLite;
using System.IO;

namespace GUEST_LogBOOK
{    
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        // path string to the DB file.
        string DbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Log.db");


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            SignIn();
            SignOUT();
        }
        public void SignIn()
        {
            //takes user to the screen where they can sign in. information entered on the sign in screen to be saved into the DB and used on the sign out page.            
            var BTN_IN = FindViewById<Button>(Resource.Id.BTN_signIN);
            BTN_IN.Click += delegate
            {
                StartActivity(typeof(SignINscreen));
            };
        }
        public void SignOUT()
        {
            //takes user to the sign out page where they will be able to see and select their Guest/user info and sign out. info to be saved into DB.
            var BTN_OUT = FindViewById<Button>(Resource.Id.BTN_signOUT);
            BTN_OUT.Click += delegate
            {
                StartActivity(typeof(SignOUTscreen));               
                    EditText Guests = FindViewById<EditText>(Resource.Id.USERINFO);

                    //conn. to the DB.
                    var LogDB = new SQLiteConnection(DbPath);

                    //connect to the table.
                    var table = LogDB.Table<People>();


                    foreach (var Item in table)
                    {
                        People loggedIN = new People(Item.FName, Item.LName, Item.WhoToSee);
                        Guests.Text += loggedIN + "/n"; // ERROR HERE!<<<<<<<<<<<<<<<<<
                    }
                };
        }
    }
    
}