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
    public partial class NoticationPage : ContentPage
    {
        public NoticationPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender , EventArgs e)
        {
            //  Navigation.PushModalAsync(new Page1()); traj3ni llapage 1 wla :
            Navigation.PopModalAsync();//y3ni suprimi la page hedhi ra7 yrj3 automatic llawla 

        }
    }
}