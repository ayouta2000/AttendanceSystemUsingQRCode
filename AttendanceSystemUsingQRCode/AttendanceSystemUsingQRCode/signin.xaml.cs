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
    public partial class signin : ContentPage
    {
        public signin()
        {
            InitializeComponent();
        }
      
        private void go_to_signup_Clicked(object sender, EventArgs e)
        {
        Navigation.PushModalAsync(new SingUp());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //verification of data
            Navigation.PushModalAsync(new StudentSpace());
        }
        
    }
}