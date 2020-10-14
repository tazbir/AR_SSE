using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSE.DAL.Repositories;
using SSE.Model.Models;

namespace AR_SSE.Services
{
    public class AuthorizationService
    {
        private AuthorizationRepository _authorizationRepository;
        public AuthorizationService()
        {
            _authorizationRepository= new AuthorizationRepository();
        }

        public bool Authorize(UserCredential userCredential)
        {
            if (string.IsNullOrWhiteSpace(userCredential.UserName) ||
                string.IsNullOrWhiteSpace(userCredential.Password))
            {
                return false;
            }
            return _authorizationRepository.Authorize(userCredential);
        }
    }
}
