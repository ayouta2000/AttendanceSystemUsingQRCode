using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plugin.FirebasePushNotification;

namespace AttendanceSystemeUsingQRCode.Droid
{
    [Application]
   public class MainApplication : Application
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transer) : base(handle, transer)
        {

        }
        public override void OnCreate()
        {
            base.OnCreate();
            {
                base.OnCreate();
            //Set the default notification channel for your app when running android Oredo
            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
                {
                    //change for ur default notification channel id here
                    FirebasePushNotificationManager.DefaultNotificationChannelId = 
                        "FirebasePushNotificationChannel";
                    //change for ur default notification channel name here
                    FirebasePushNotificationManager.DefaultNotificationChannelName =
                        "General";

                }
                //if debug you should reset the token each time .
#if DEBUG
                FirebasePushNotificationManager.Initialize(this, true);
#else
              FirebasePushNotificationManager.Initialize(this, false);
#endif
                //Handle notification when app is closed here
                CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
                {
                };
               
            }
        }
    }
}