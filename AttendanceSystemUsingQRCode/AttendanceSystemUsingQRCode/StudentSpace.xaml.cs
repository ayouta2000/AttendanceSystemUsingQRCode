using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace AttendanceSystemeUsingQRCode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentSpace : ContentPage
    {
       
        
        public StudentSpace()
        {
            InitializeComponent();
           
        }

        private async void scan_Clicked(object sender, EventArgs e)
        {
            var scan = new ZXingScannerPage();
            await Navigation.PushModalAsync(scan);
            scan.OnScanResult += (result) => {
                Device.BeginInvokeOnMainThread(async () => {
                    await Navigation.PopModalAsync();
                    await DisplayAlert("you are registered and present in a class: ", "" + result.Text, "Ok");

                });
            };
        }
        private void schedule_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TimeSchedule());
        }
    }
}