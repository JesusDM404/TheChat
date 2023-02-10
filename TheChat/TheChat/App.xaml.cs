using Acr.UserDialogs;
using FreshMvvm;
using System;
using TheChat.Core.Services;
using TheChat.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheChat
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ConfigureContainer();

            var loginPage =
                FreshPageModelResolver
                    .ResolvePageModel<LoginViewModel>();

            var navPage =
                new FreshNavigationContainer(loginPage);

            MainPage = navPage;

        }

        private void ConfigureContainer()
        {
            FreshIOC.Container.Register<IChatService, ChatService>();
            FreshIOC.Container.Register<IUserDialogs>(UserDialogs.Instance);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
