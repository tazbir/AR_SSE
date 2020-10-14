using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using AR_SSE.Commands;
using AR_SSE.Services;
using AR_SSE.Views;
using SSE.Model.Annotations;
using SSE.Model.Models;


namespace AR_SSE.ViewModels
{
    public class LoginViewModel:INotifyPropertyChanged
    {
        #region implemented from interface
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region private variables

        private readonly AuthorizationService _authorizationService;
        private UserCredential _userCredential;
        private LoginCommand _authorizeCommand;

        #endregion

        #region Properties
        public UserCredential UserCredential
        {
            get => _userCredential;
            set { _userCredential = value; OnPropertyChanged(nameof(UserCredential)); }
        }

        public bool AuthorizationStatus { get; set; }
        #endregion
        
        #region Constructor
        public LoginViewModel()
        {
            UserCredential = new UserCredential();
            _authorizationService = new AuthorizationService();
            _authorizeCommand = new LoginCommand(Authorize);
        }
        #endregion


        public LoginCommand AuthorizeCommand => _authorizeCommand;

        public void Authorize()
        {
            AuthorizationStatus =  _authorizationService.Authorize(UserCredential);

            if (AuthorizationStatus)
            {
                NavigationService nav = NavigationService.GetNavigationService(new LoginView().GetView());
                nav?.Navigate(new Uri("Views/FileList.xaml", UriKind.RelativeOrAbsolute));
            }
        }

    }
}
