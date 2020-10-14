﻿using System;
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
        public LoginView()
        {
            InitializeComponent();
            _loginViewModel= new LoginViewModel();
            this.DataContext = _loginViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav= NavigationService.GetNavigationService(this);
            nav?.Navigate(new Uri("Views/FileList.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
