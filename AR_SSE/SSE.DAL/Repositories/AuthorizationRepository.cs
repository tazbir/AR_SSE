using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using SSE.Model.Models;

namespace SSE.DAL.Repositories
{
    public class AuthorizationRepository
    {
        //public bool Authorize(UserCredential userCredential)
        //{
        //    var UName = userCredential.UserName;
        //    var PWord = userCredential.Password;
        //    XDocument config = XDocument.Load("../../Resourses/UserInfo.xml");
        //    var query = from o in config.Root.Elements("user")
        //        where (string)o.Element("username") == UName
        //        select o.Element("username")?.Value;
        //    var query2 = from o in config.Root.Elements("user")
        //        where (string)o.Element("username") == UName
        //        select o.Element("password")?.Value;
        //    var password = query2.ToString();
        //    if (PWord == password)
        //    {
        //        //NavigationService service = NavigationService.GetNavigationService(this);
        //        //service.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
        //        return true;
        //    }
        //    return false;
        //    //LblError.Content = "Username or Password Incorrect !";
        //}

        public bool Authorize(UserCredential credential)
        {
                XmlDocument doc = new XmlDocument();
                string fileName = "../../Resourses/UserInfo.xml";
                string XPATH = "//user";


                doc.Load(fileName);
                XPathNavigator navigator = doc.CreateNavigator();

                XPathNodeIterator bookNodesIterator = navigator.Select(XPATH);

                string userCredential = $"{credential.UserName}{credential.Password}";
                bool sdf = bookNodesIterator.Current != null && bookNodesIterator.Current.Value.Contains(userCredential);
                return sdf;
        }
    }
}
