using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ARFoods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public ViewModel.LoginViewModel ViewModel;

        public LoginWindow()
        {
            InitializeComponent();
            ViewModel = new ViewModel.LoginViewModel();
            DataContext = ViewModel;
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ViewModel.Login.Password = passwordBox.Password;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            object connection = DB.Connection;
        }

        
    }
}
