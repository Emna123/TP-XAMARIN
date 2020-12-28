using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navigation : ContentPage
    {
        public Navigation()
        {
            InitializeComponent();
        }
       private void OnClick1(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MasterDetailPage());
        }
       private void OnClick2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage());
        }
        private void OnClick3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPage());
        }
        private void OnClick4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarouselPage());
        }
    }
}