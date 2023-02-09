using MahApps.Metro.Controls;
using MosaicoApp.View;
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

namespace MosaicoApp.Usercontrols
{
    /// <summary>
    /// Interaction logic for _2x2.xaml
    /// </summary>
    public partial class _2x2 : UserControl
    {
        private readonly DirectoryInfo vlcLibDirectory;
        public MosaicoVM VM { get; set; }

        public _2x2()
        {
            InitializeComponent();

            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            vlcLibDirectory = new DirectoryInfo(System.IO.Path.Combine
                (currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
            VM = new MosaicoVM();
        }


        public void StopCameraVideos()
        {
            CameraDisplay1?.SourceProvider.Dispose();
            CameraDisplay1?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay2?.SourceProvider.Dispose();
            CameraDisplay2?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay3?.SourceProvider.Dispose();
            CameraDisplay3?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay4?.SourceProvider.Dispose();
            CameraDisplay4?.SourceProvider.MediaPlayer?.Dispose();
        }

        public void StartCameraVideos()
        {
            CameraDisplay1.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay1?.SourceProvider.MediaPlayer?.Play(MosaicoController.Instance.listRtsp.First());

            CameraDisplay2.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay2?.SourceProvider.MediaPlayer?.Play(MosaicoController.Instance.listRtsp.ElementAt(1));

            CameraDisplay3.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay3?.SourceProvider.MediaPlayer?.Play(MosaicoController.Instance.listRtsp.ElementAt(2));

            CameraDisplay4.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay4?.SourceProvider.MediaPlayer?.Play(MosaicoController.Instance.listRtsp.ElementAt(3));
        }

        private void DisplaySelectedCamera(object sender, MouseButtonEventArgs e)
        {
            VlcControl control = sender as VlcControl;
            string rtsp = VM.DisplaySelectedCamera(control.Name);

            SelectedCamera selectedCamera = new SelectedCamera(rtsp);
            selectedCamera.Show();
 
        }
    }
}
