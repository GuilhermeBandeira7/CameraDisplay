using System;
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

namespace MosaicoApp.Pages
{
    /// <summary>
    /// Interaction logic for Page5x5.xaml
    /// </summary>
    public partial class Page5x5 : Page
    {
        public Page5x5()
        {
            InitializeComponent();
        }

        internal void StopVideos()
        {
            videos.StopCameraVideos();
        }

        internal void StartVideos()
        {
            videos.StartCameraVideos();
        }
    }
}
