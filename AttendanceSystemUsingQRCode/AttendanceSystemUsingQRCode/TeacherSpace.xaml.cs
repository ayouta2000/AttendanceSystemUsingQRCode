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
    public partial class TeacherSpace : ContentPage
    {
        public TeacherSpace()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void AddClass_Clicked(object sender, EventArgs e)
        {

        }

        private void AttendanceList(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new QRGenerator());
        }
    }
}