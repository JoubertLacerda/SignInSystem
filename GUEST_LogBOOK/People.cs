using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GUEST_LogBOOK
{
    class People
    {
        int VisitorNo { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string WhoToSee { get; set; }

        public People( string fName, string lname, string Visiting)
        {
            //constructor 
           // VisitorNo = No;
            FName = fName;
            LName = lname;
            WhoToSee = Visiting;
        }

        public People()
        {

        }

        public override string ToString()
        {
            return VisitorNo+" "+FName+" "+LName+" "+WhoToSee;
        }
    }
}