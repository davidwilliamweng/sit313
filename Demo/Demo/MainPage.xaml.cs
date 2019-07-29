using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Picture Rotary Index
        /// </summary>
        private int index =1;
        private string imgName = "";
        /// <summary>
        /// Initialization
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            RPM.TextColor = Color.FromRgb(250, 63, 126);
            //Calendar Component Hiding
            DatePicker.IsVisible = false;
            //Picture Rotary
            img.IsVisible = true;
            btn.IsVisible = true;
            //Binding default images
            imgName = "A" + index;
            img.Source = imgName;
        }
        /// <summary>
        /// Calendar Selection Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            DisplayAlert("The date you choose is：",  args.NewDate.Date.ToLongDateString(), "Got It");
        }
        /// <summary>
        /// Rotary Calendar Switching
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)//RPM
            {
                DatePicker.IsVisible = false;
                img.IsVisible = true;
                btn.IsVisible = true;
                CD.TextColor = Color.Black;
                RPM.TextColor = Color.FromRgb(250, 63, 126);
            }
            else
            {//CD
                DatePicker.IsVisible = true;
                img.IsVisible = false;
                btn.IsVisible = false;
                RPM.TextColor = Color.Black;
                CD.TextColor = Color.FromRgb(250, 63, 126);
            }
        }
        /// <summary>
        /// Last picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnBack(object sender, EventArgs e) {
            index--;
            if (index<1)
            {
                index = 8;
            }
            imgName = "A" + index;
            img.Source = imgName;
        }
        /// <summary>
        /// Next picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnNext(object sender, EventArgs e)
        {
            index++;
            if (index>8)
            {
                index=1;
            }
            imgName = "A" + index;
            img.Source = imgName;
        }
    }
}
