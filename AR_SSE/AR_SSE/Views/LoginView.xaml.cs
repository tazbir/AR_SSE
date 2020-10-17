using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using AR_SSE.ViewModels;

namespace AR_SSE.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        private LoginViewModel _loginViewModel;

        public LoginView(MainWindow mainWindow)
        {
            InitializeComponent();
            _loginViewModel= new LoginViewModel(this, mainWindow);
            this.DataContext = _loginViewModel;
        }
    }
}
