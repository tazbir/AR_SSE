using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AR_SSE.Services;
using SSE.Model.Annotations;


namespace AR_SSE.ViewModels
{
    public class LoginViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private AuthorizationService _authorizationService;
        public LoginViewModel()
        {
            _authorizationService = new AuthorizationService();
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        
        
    }
}
