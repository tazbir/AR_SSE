using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Policy;
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
        private MainWindow _main;

        public FileList(MainWindow main)
        {
            InitializeComponent();
            _fileListViewModel = new FileListViewModel();
            DataContext = _fileListViewModel;
            _main = main;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Uri fileUrl = new Uri(((Button)sender).Tag.ToString());


            string file = System.IO.Path.GetFileName(fileUrl.ToString());
            WebClient cln = new WebClient();
            cln.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            cln.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            cln.DownloadFileAsync(fileUrl, file);
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            _fileListViewModel.DownloadStatus = (e.BytesReceived/1024/1024) + " of " + (e.TotalBytesToReceive/1024/1024);
            _fileListViewModel.ProgressBarStatus = e.ProgressPercentage;
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            _fileListViewModel.DownloadStatus = "Completed";
        }
    }

}
