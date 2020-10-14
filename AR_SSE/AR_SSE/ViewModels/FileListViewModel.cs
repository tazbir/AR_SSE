using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AR_SSE.Services;
using SSE.Model.Annotations;
using SSE.Model.Models;

namespace AR_SSE.ViewModels
{
    public class FileListViewModel:INotifyPropertyChanged
    {
        private FileListService _fileListService;
        private List<FileListData> _fileListDataCollection;
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public FileListViewModel()
        {
            _fileListService= new FileListService();
            LoadData();
        }

        public List<FileListData> FileListDataCollection
        {
            get => _fileListDataCollection;
            set { _fileListDataCollection = value; OnPropertyChanged(nameof(FileListDataCollection));}
        }

        private void LoadData()
        {
            FileListDataCollection = _fileListService.GetAll();
        }
    }
}
