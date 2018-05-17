using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace DearWalletDressMeUp.Helper
{
    public static class Navigacija
    {
        public static void Navigiraj(Type sourcePage)
        {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage);
        }

        public static void Navigiraj(Type sourcePage, object parameter)
        {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage, parameter);
        }

        public static void Nazad()
        {
            var frame = (Frame)Window.Current.Content;
            frame.GoBack();
        }
    }
}

