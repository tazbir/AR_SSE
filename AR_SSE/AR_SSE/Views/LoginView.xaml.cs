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
        private NavigationService _nav;

        public NavigationService Nav
        {
            get => _nav;
            set => _nav = value;
        }

        public LoginView()
        {
            InitializeComponent();
            _loginViewModel= new LoginViewModel();
            this.DataContext = _loginViewModel;
            Nav = NavigationService.GetNavigationService(this);
        }
    }
}
