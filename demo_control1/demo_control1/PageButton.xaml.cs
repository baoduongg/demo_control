using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo_control1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageButton : ContentPage
	{
        bool animationInProgress = false;
        Stopwatch stopwatch = new Stopwatch();

        public PageButton ()
		{
			InitializeComponent ();
            btn_1.Clicked += Btn_1_Clicked;
		}

        private void Btn_1_Clicked(object sender, EventArgs e)
        {
            label.RelRotateTo(360, 1000);
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            btn_login.IsEnabled = true;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            etry_pass.Focus();

        }

        private void Etry_pass_Completed(object sender, EventArgs e)
        {
            Button_Clicked(null, null);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Thông báo", "Bạn đã đăng nhập thành công", "OK");
        }

        private void Btn_1_Released(object sender, EventArgs e)
        {
            animationInProgress = false;
            stopwatch.Stop();
        }

        private void Btn_1_Pressed(object sender, EventArgs e)
        {
            stopwatch.Start();
            animationInProgress = true;

            Device.StartTimer(TimeSpan.FromMilliseconds(16), () =>
            {
                label.Rotation = 360 * (stopwatch.Elapsed.TotalSeconds % 1);

                return animationInProgress;
            });
        }
    }
}