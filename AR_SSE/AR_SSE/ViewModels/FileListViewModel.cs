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
    public sealed class FileListViewModel:INotifyPropertyChanged
    {
        #region private variables
        private FileListService _fileListService;
        private List<FileListData> _fileListDataCollection;
        #endregion

        #region implemented from interface
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Constructor
        public FileListViewModel()
        {
            _fileListService = new FileListService();
            LoadData();
        }
        #endregion

        #region public Properties
        public List<FileListData> FileListDataCollection
        {
            get => _fileListDataCollection;
            set { _fileListDataCollection = value; OnPropertyChanged(nameof(FileListDataCollection)); }
        }
        #endregion

        #region Private Methods
        private void LoadData()
        {
            FileListDataCollection = _fileListService.GetAll();
        }
        #endregion

    }
}
