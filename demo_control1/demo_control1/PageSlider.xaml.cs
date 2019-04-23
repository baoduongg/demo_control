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
	public partial class PageSlider : ContentPage
	{
		public PageSlider ()
		{
			InitializeComponent ();
		}

        private void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int var = Convert.ToInt32(e.NewValue);
            lbl_result.Text = "giá trị slider" + var;
           
        }

        private void RedSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (sender == redSlider)
            {
                redLabel.Text = String.Format("Red = {0:X2}", Convert.ToInt32(e.NewValue));
            }
            else if (sender == greenSlider)
            {
                greenLabel.Text = String.Format("Green = {0:X2}", Convert.ToInt32(e.NewValue));
            }
            else if (sender == blueSlider)
            {
                blueLabel.Text = String.Format("Blue = {0:X2}", Convert.ToInt32(e.NewValue));
            }

           this.BackgroundColor = Color.FromRgb((int)redSlider.Value,
                                          (int)greenSlider.Value,
                                          (int)blueSlider.Value);
        }
    }
}