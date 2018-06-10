﻿using System;
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
using DearWalletDressMeUp.Model;
using Microsoft.WindowsAzure.MobileServices;
using DearWalletDressMeUp.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DearWalletDressMeUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
            DataContext = new LoginViewModel();
        }
        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void pink_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Registracija));
        }
    }
}