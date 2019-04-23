using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo_control1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageDatePicker : ContentPage
    {
       
        public PageDatePicker ()
		{
			InitializeComponent ();

            var lbltitle = new Label
            {
                Text = "Demo Picker",
                FontSize = 30
            };
            var tp = new TimePicker();
            
            var dp = new DatePicker();
            {
                dp.MinimumDate = DateTime.Now;
               
            }

            var dataList = new List<string>();
            dataList.Add("Viet Nam");
            dataList.Add("Thai Lan");
            dataList.Add("Lao");
            dataList.Add("Campuchia");
            dataList.Add("Nhat Ban");
            dataList.Add("Trung Quoc");
            var datapicker = new Picker();
            {
                datapicker.Title = "Select Location";
            }
            datapicker.ItemsSource = dataList;

            var btn_show = new Button {

                Text ="Show picker"
            };
            var btnsubmit = new Button
            {
                Text = "Submit"
            };
            var lblresult = new Label();
            
      
            btnsubmit.Clicked += Btn_Clicked;
             void Btn_Clicked(object sender, EventArgs e)
            {
                var time = tp.Time;
                
                var date = dp.Date.ToShortDateString();
                var day = dp.Date.Day;
                var month = dp.Date.Month;
                var year = dp.Date.Year;
                

                
              
                var getdatapicker = datapicker.SelectedItem;
                lblresult.Text = String.Format("Date: {0} \n Day {1} \n Month {2} \n Year {3} \n  Time {4} \n Location: {5}", date, day, month, year, time,getdatapicker);
            }
            btn_show.Clicked += Btn_show_Clicked;
            void Btn_show_Clicked(object sender, EventArgs e)
            {
                datapicker.Focus();
            }
            this.Content = new StackLayout
            {
                Padding = 10,
                Children =
                {
                    lbltitle,dp,tp,datapicker,btn_show,lblresult,btnsubmit
                }
            };     
        }
        

       
    }
}