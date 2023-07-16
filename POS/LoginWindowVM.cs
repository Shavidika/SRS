using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media.Imaging;

namespace POS
{
    public partial class LoginWindowVM :ObservableObject
    {
        public Action CloseAction { get; internal set; }

        public LoginWindowVM()
        {

        }

        [RelayCommand]
        public void goBack()
        {
            CloseAction();
            Application.Current.MainWindow.Show();
        }
    }
}
