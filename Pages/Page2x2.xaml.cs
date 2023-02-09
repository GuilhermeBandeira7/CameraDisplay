using LibVLCSharp.Shared;
using MosaicoApp.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using Vlc.DotNet.Wpf;

namespace MosaicoApp.Pages
{
    /// <summary>
    /// Interaction logic for Page2x2.xaml
    /// </summary>
    /// 

    public partial class Page2x2 : Page
    {
        public Page2x2()
        {
            InitializeComponent();
        }

        public void StopVideos()
        {
            videos.StopCameraVideos();
        }

        public void StartVideos()
        {
            videos.StartCameraVideos();
        }

    }
}
