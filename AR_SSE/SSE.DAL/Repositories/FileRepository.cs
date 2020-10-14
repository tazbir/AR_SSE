using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using SSE.Model.Models;

namespace SSE.DAL.Repositories
{
    public class FileRepository
    {
        public List<FileListData> GetAll()
        {
            XmlDocument doc = new XmlDocument();
            string fileName = "../../Resourses/DownloadInfo.xml";
            string XPATH = "//files/file";
            var collection = new List<FileListData>();

            doc.Load(fileName);
            XPathNavigator navigator = doc.CreateNavigator();

            //XPathNodeIterator bookNodesIterator = navigator.Select(XPATH);

            //if (bookNodesIterator.Current != null)
            //{
            //    var sdf = bookNodesIterator.Current.UnderlyingObject;
            //}

            foreach (XPathNavigator nav in navigator.Select(XPATH))
            {
                FileListData data= new FileListData();
                data.Title = nav.GetAttribute("title", string.Empty);
                data.Link = nav.GetAttribute("link", string.Empty);
                collection.Add(data);
            }

            return collection;
        }
    }
}
