using System;
using System.Collections.Generic;
using System.Text;
using SSE.Model.Models;

namespace SSE.DAL.Repositories
{
    interface IAuthorizationRepository
    {
        bool Authorize(UserCredential userCredential);
    }
}
