using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileComp_CPSC4250.Services;
using MobileComp_CPSC4250.Views;

namespace MobileComp_CPSC4250
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
