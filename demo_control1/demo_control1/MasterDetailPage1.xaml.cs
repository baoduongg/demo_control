using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo_control1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage1MenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;
            switch (item.Id)
            {
                case 0:
                    Detail = new NavigationPage(new PageLabel());
                    IsPresented = false;
                    break;
                case 1:
                    Detail = new NavigationPage(new PageEntry());
                    IsPresented = false;
                    break;
                case 2:
                    Detail = new NavigationPage(new PageEditor());
                    IsPresented = false;
                    break;
                case 3:
                    Detail = new NavigationPage(new PageButton());
                    IsPresented = false;
                    break;
                case 4:
                    Detail = new NavigationPage(new PageDatePicker());
                    IsPresented = false;
                    break;
                case 5:
                    Detail = new NavigationPage(new PagePicker());
                    IsPresented = false;
                    break;
                case 6:
                    Detail = new NavigationPage(new PageSlider());
                    IsPresented = false;
                    break;
                case 7:
                    Detail = new NavigationPage(new Pageswitch());
                    IsPresented = false;
                    break;



                default:
                    break;
            }


            MasterPage.ListView.SelectedItem = null;
        }
    }
}