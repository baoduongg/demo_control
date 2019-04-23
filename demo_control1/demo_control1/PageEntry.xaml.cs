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
	public partial class PageEntry : ContentPage
	{
		public PageEntry ()
		{
			InitializeComponent ();
            EntyLogin.Completed += EntyLogin_Completed;
		}

        private void EntyLogin_Completed(object sender, EventArgs e)
        {
            EntyPass.Focus();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
            enty_2.Text = newText;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            string link = Entyurl.Text;
            string url="http://"+link;
            Device.OpenUri(new Uri(url));
        }
    }
}