﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AR_SSE.ViewModels;

namespace AR_SSE.Views
{
    /// <summary>
    /// Interaction logic for FileList.xaml
    /// </summary>
    public partial class FileList : Page
    {
        private FileListViewModel _fileListViewModel;
        public FileList()
        {
            InitializeComponent();
            _fileListViewModel = new FileListViewModel();
            DataContext = _fileListViewModel;
        }
    }
}
