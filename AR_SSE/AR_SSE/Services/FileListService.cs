using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSE.Model.Models;

namespace AR_SSE.Services
{
    public class FileListService
    {
        private static List<FileListData> _fileListData;

        public FileListService()
        {
            _fileListData = new List<FileListData>()
            {
                new FileListData()
                {
                    Title = "Sample",
                    Link = "sampleLink"
                }
            };
        }

        public List<FileListData> GetAll()
        {
            return _fileListData;
        }
    }
}
