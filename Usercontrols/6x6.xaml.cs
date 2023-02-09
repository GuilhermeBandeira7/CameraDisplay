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
    /// Interaction logic for _6x6.xaml
    /// </summary>
    public partial class _6x6 : UserControl
    {
        private MosaicoVM vm = new MosaicoVM();
        private readonly DirectoryInfo vlcLibDirectory;

        public _6x6()
        {
            InitializeComponent();

            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            vlcLibDirectory = new DirectoryInfo(System.IO.Path.Combine
                (currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
            
        }

        internal void StopCameraVideos()
        {
            CameraDisplay1?.SourceProvider.Dispose();
            CameraDisplay1?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay2?.SourceProvider.Dispose();
            CameraDisplay2?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay3?.SourceProvider.Dispose();
            CameraDisplay3?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay4?.SourceProvider.Dispose();
            CameraDisplay4?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay5?.SourceProvider.Dispose();
            CameraDisplay5?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay6?.SourceProvider.Dispose();
            CameraDisplay6?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay7?.SourceProvider.Dispose();
            CameraDisplay7?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay8?.SourceProvider.Dispose();
            CameraDisplay8?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay9?.SourceProvider.Dispose();
            CameraDisplay9?.SourceProvider.MediaPlayer?.Dispose();
        }

        internal void StartCameraVideos()
        {
            CameraDisplay1.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay1.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(0));

            CameraDisplay2.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay2.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(1));

            CameraDisplay3.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay3.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(2));

            CameraDisplay4.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay4.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(3));

            CameraDisplay5.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay5.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(4));

            CameraDisplay6.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay6.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(5));

            CameraDisplay7.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay7.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(6));

            CameraDisplay8.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay8.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(7));

            CameraDisplay9.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay9.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(8));
        }

        private void DisplaySelectedCamera(object sender, MouseButtonEventArgs e)
        {
            VlcControl control = sender as VlcControl;
            string rtsp = vm.DisplaySelectedCamera(control.Name);

            SelectedCamera selectedCamera = new SelectedCamera(rtsp);
            selectedCamera.Show();

        }
    }
}
