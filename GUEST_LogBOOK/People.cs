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

namespace GUEST_LogBOOK
{
     class People
    {    
        public int VisitorNo { get; set; }
        public string FName { get; set; }
        public string Lname { get; set; }
        public string WhoToSee { get; set; }

        //public Visitors(int No, string FullName, string Visiting)
        //{
        //    No = VisitorNo;
        //    FullName = FName + Lname;
        //    Visiting = WhoToSee;
        //}
        public override string ToString()
        {
            return VisitorNo +""+ FName +""+ Lname +""+ WhoToSee;
        }
    }
   
}