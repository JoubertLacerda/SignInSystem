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
using SQLite;
using System.IO;

namespace GUEST_LogBOOK
{
    [Activity(Label = "@string/SignOut")]
    public class SignOUTscreen : Activity
    {
        // path string to the DB file.
        string DbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Log.db");

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SignOUT_Screen);
            //Registered_Users();
        }

        public void Registered_Users ()
        {
            Button ActiveUsers = FindViewById<Button>(Resource.Id.BTN_signOUT);
            ActiveUsers.Click += delegate
            {
                    TextView Guests = FindViewById<TextView>(Resource.Id.USERINFO);

                //conn. to the DB.
                var LogDB = new SQLiteConnection(DbPath);

                //connect to the table.
                var table = LogDB.Table<People>();

               
                    foreach (var Item in table)
                    {
                        People loggedIN = new People(Item.FName, Item.LName, Item.WhoToSee);
                        Guests.Text += loggedIN + "/n";
                    }
            };
        }
    }
}