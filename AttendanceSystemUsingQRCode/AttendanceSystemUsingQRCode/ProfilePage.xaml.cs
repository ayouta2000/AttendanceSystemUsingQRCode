using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace AttendanceSystemeUsingQRCode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {

        public ProfilePage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           
                var scan = new ZXingScannerPage();
                await Navigation.PushModalAsync(scan);
                scan.OnScanResult += (result) =>
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Navigation.PopModalAsync();
                        await DisplayAlert("valeur QRCODE", "" + result.Text, "Ok");

                    });
                };
        }

       
        

        private void teacher_Clicked(object sender, EventArgs e)
        {

             Navigation.PushModalAsync(new TeacherSpace());
        }
        private void student_Clicked(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new signin());
        }
    }
}

