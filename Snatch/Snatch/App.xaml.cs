using Snatch.Services;
using Snatch.Services.ChineseCalendar;
using Snatch.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Snatch
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<IChineseCalendarService>();
            MainPage = new AppShell();
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
