using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSE.DAL.Repositories;
using SSE.Model.Models;

namespace AR_SSE.Services
{
    public class FileListService
    {
        private static List<FileListData> _fileListData;
        private FileRepository _fileRepository;

        public FileListService()
        {
            _fileRepository= new  FileRepository();
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
            var result = _fileRepository.GetAll();
            return result;
        }
    }
}
