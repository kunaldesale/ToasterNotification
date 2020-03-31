using Plugin.Toasts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms;

namespace XamarinTestApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            //Xamarin.Forms.Forms.Init();
            //DependencyService.Register<ToastNotificatorImplementation>();
            //ToastNotificatorImplementation.Init(stackSize: 2);

            DependencyService.Register<ToastNotification>();
            ToastNotification.Init();

            LoadApplication(new XamarinTestApp.App());
        }
    }
}
