using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            
            satusMessage.Text = "";
            List<User> users = await App.UserRepo.GetUsersAsync();
            foreach(User u in users)
            {
                if (string.Equals(email.Text,u.email) && string.Equals(password.Text,u.password))
                {
                    await Navigation.PushAsync(new Navigation());

                }
            }


            satusMessage.Text = "wrong Email/Password!"
 ;


        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Inscri());

        }
    }
}