using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace calendar
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_main);

            var calendarView = FindViewById<CalendarView>(Resource.Id.calendarView1);
            var txtDisplay = FindViewById<TextView>(Resource.Id.txtDisplay);

            txtDisplay.Text = "Date: ";
            calendarView.DateChange += (s,e) =>
              {
                  int day = e.DayOfMonth;
                  int month = e.Month;
                  int year = e.Year;
                  txtDisplay.Text = "Date: " + day + "/" + month + "/" + year;
              };
        }
      
        

   
        
	}
}

