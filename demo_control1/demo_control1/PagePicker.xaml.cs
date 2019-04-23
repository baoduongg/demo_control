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
	public partial class PagePicker : ContentPage
	{
        public PagePicker()
        {
            InitializeComponent();
            BindingContext = new MonkeysPageViewModel();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            pickermonkey.Focus();   
        }
    }
        
       
}