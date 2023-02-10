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
    /// Interaction logic for _5x5.xaml
    /// </summary>
    public partial class _5x5 : UserControl
    {
        private MosaicoVM vm = new MosaicoVM();
        private readonly DirectoryInfo vlcLibDirectory;

        public _5x5()
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
            CameraDisplay10?.SourceProvider.Dispose();
            CameraDisplay10?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay11?.SourceProvider.Dispose();
            CameraDisplay11?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay12?.SourceProvider.Dispose();
            CameraDisplay12?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay13?.SourceProvider.Dispose();
            CameraDisplay13?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay14?.SourceProvider.Dispose();
            CameraDisplay14?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay15?.SourceProvider.Dispose();
            CameraDisplay15?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay16?.SourceProvider.Dispose();
            CameraDisplay16?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay17?.SourceProvider.Dispose();
            CameraDisplay17?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay18?.SourceProvider.Dispose();
            CameraDisplay18?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay19?.SourceProvider.Dispose();
            CameraDisplay19?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay20?.SourceProvider.Dispose();
            CameraDisplay20?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay21?.SourceProvider.Dispose();
            CameraDisplay21?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay22?.SourceProvider.Dispose();
            CameraDisplay22?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay23?.SourceProvider.Dispose();
            CameraDisplay23?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay24?.SourceProvider.Dispose();
            CameraDisplay24?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay25?.SourceProvider.Dispose();
            CameraDisplay25?.SourceProvider.MediaPlayer?.Dispose();

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

            CameraDisplay10.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay10.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(9));

            CameraDisplay11.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay11.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(10));

            CameraDisplay12.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay12.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(11));

            CameraDisplay13.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay13.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(12));

            CameraDisplay14.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay14.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(13));

            CameraDisplay15.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay15.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(14));

            CameraDisplay16.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay16.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(15));

            CameraDisplay17.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay17.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(16));

            CameraDisplay18.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay18.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(17));

            CameraDisplay19.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay19.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(18));

            CameraDisplay20.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay20.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(19));

            CameraDisplay21.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay21.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(20));

            CameraDisplay22.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay22.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(21));

            CameraDisplay23.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay23.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(22));

            CameraDisplay24.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay24.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(23));

            CameraDisplay25.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay25.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(24));
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
