using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using UniversalLauncher.Views;

namespace UniversalLauncher.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Blah";



        // I cant belive i got it to work lmao.
        public static void CloseWin(Window window) {
            window.Close();
        }
    }
}
