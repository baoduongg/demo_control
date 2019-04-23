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
	public partial class Pageswitch : ContentPage
	{
		public Pageswitch ()
		{
			InitializeComponent ();
		}

        private void Switch1_Toggled(object sender, ToggledEventArgs e)
        {
            bool value = e.Value;
            lbl2.Text = "" + value;
        }
    }
}