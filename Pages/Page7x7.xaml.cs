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
    /// Interaction logic for Page7x7.xaml
    /// </summary>
    public partial class Page7x7 : Page
    {
        public Page7x7()
        {
            InitializeComponent();
        }

        internal void StartVideos()
        {
            videos.StartCameraVideos();
        }

        internal void StopVideos()
        {
           videos.StopCameraVideos();
        }
    }
}
