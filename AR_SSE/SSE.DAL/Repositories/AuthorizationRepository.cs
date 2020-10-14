using System.Linq;
using System.Xml.Linq;
using SSE.Model.Models;

namespace SSE.DAL.Repositories
{
    class AuthorizationRepository:IAuthorizationRepository
    {
        public bool Authorize(UserCredential userCredential)
        {
            var UName = userCredential.UserName;
            var PWord = userCredential.Password;
            XDocument config = XDocument.Load("../Resources/UserInfo.xml");
            var query = from o in config.Root.Elements("user")
                where (string)o.Element("username") == UName
                select o.Element("username")?.Value;
            var query2 = from o in config.Root.Elements("user")
                where (string)o.Element("username") == UName
                select o.Element("password")?.Value;
            var password = query2.ToString();
            if (PWord == password)
            {
                //NavigationService service = NavigationService.GetNavigationService(this);
                //service.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
                return true;
            }
            return false;
            //LblError.Content = "Username or Password Incorrect !";
        }
    }
}
