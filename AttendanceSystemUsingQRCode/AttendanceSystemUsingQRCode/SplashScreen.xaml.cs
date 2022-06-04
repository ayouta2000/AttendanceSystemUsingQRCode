using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AttendanceSystemeUsingQRCode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
     
        public SplashScreen()
        {
            InitializeComponent();
            Animate();
        }
        public async Task Animate()
        {
            extenImg.Opacity = 0;
            await extenImg.FadeTo(1, 2000);
            await animationView.FadeTo(1, 2000);
            Application.Current.MainPage = new HomePage();
        }


    }
}