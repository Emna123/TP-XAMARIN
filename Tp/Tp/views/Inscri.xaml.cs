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
    public partial class Inscri : ContentPage
    {
        public Inscri()
        {
            InitializeComponent();
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            satusMessage.Text = "";
            await App.UserRepo.AddNewUserAsunc(email.Text, password.Text);
            if (App.UserRepo.StatusMessage == "successful registration")
            { await Navigation.PushAsync(new Login()); }
            satusMessage.Text = App.UserRepo.StatusMessage;

        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new Login()); 
         

        }

    }
}