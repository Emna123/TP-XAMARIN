using System;
using System.IO;
using Tp.Repos;
using Tp.views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NavigationPage = Xamarin.Forms.NavigationPage;

namespace Tp
{
    public partial class App : Application
    {
        private string dbPath = Path.Combine(FileSystem.AppDataDirectory, "database.db3");
        public static UserRepo UserRepo { get; private set; }
        public App()
        {
            InitializeComponent();
            UserRepo = new UserRepo(dbPath);
            MainPage = new NavigationPage(new Login());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
