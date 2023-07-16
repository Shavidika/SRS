using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media.Imaging;

namespace POS
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Person> persons;
        [ObservableProperty]
        public Person selectedUser = null;
        [ObservableProperty]
        public Person defaultPerson = null;

        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }

        [RelayCommand]
        public void user()
        {
            var vm = new LoginWindow();
            LoginWindow window = new LoginWindow();
            window.ShowDialog();
        }

        [RelayCommand]
        public void admin()
        {
            var vm = new LoginWindow();
            LoginWindow window = new LoginWindow();
            window.ShowDialog();
        }

        
    }
}
