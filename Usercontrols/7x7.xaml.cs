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
    /// Interaction logic for _7x7.xaml
    /// </summary>
    public partial class _7x7 : UserControl
    {
        private MosaicoVM vm = new MosaicoVM();
        private readonly DirectoryInfo vlcLibDirectory;
        public _7x7()
        {
            InitializeComponent();

            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            vlcLibDirectory = new DirectoryInfo(System.IO.Path.Combine
                (currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
           
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

            CameraDisplay26.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay26.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(25));

            CameraDisplay27.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay27.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(26));

            CameraDisplay28.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay28.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(27));

            CameraDisplay29.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay29.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(28));

            CameraDisplay30.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay30.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(29));

            CameraDisplay31.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay31.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(30));

            CameraDisplay32.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay32.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(31));

            CameraDisplay33.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay33.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(32));

            CameraDisplay34.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay34.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(33));

            CameraDisplay35.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay35.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(34));

            CameraDisplay36.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay36.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(35));

            CameraDisplay37.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay37.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(36));

            CameraDisplay38.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay38.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(37));

            CameraDisplay39.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay39.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(38));

            CameraDisplay40.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay40.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(39));

            CameraDisplay41.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay41.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(40));

            CameraDisplay42.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay42.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(41));

            CameraDisplay43.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay43.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(42));

            CameraDisplay44.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay44.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(43));

            CameraDisplay45.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay45.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(44));

            CameraDisplay46.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay46.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(45));

            CameraDisplay47.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay47.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(46));

            CameraDisplay48.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay48.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(47));

            CameraDisplay49.SourceProvider.CreatePlayer(vlcLibDirectory);
            CameraDisplay49.SourceProvider.MediaPlayer.Play(MosaicoController.Instance.listRtsp.ElementAt(48));
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
            CameraDisplay26?.SourceProvider.Dispose();
            CameraDisplay26?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay27?.SourceProvider.Dispose();
            CameraDisplay27?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay28?.SourceProvider.Dispose();
            CameraDisplay28?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay29?.SourceProvider.Dispose();
            CameraDisplay29?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay30?.SourceProvider.Dispose();
            CameraDisplay30?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay31?.SourceProvider.Dispose();
            CameraDisplay31?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay32?.SourceProvider.Dispose();
            CameraDisplay32?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay33?.SourceProvider.Dispose();
            CameraDisplay33?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay34?.SourceProvider.Dispose();
            CameraDisplay34?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay35?.SourceProvider.Dispose();
            CameraDisplay35?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay36?.SourceProvider.Dispose();
            CameraDisplay36?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay37?.SourceProvider.Dispose();
            CameraDisplay37?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay38?.SourceProvider.Dispose();
            CameraDisplay38?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay39?.SourceProvider.Dispose();
            CameraDisplay39?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay40?.SourceProvider.Dispose();
            CameraDisplay40?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay41?.SourceProvider.Dispose();
            CameraDisplay41?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay42?.SourceProvider.Dispose();
            CameraDisplay42?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay43?.SourceProvider.Dispose();
            CameraDisplay43?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay44?.SourceProvider.Dispose();
            CameraDisplay44?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay45?.SourceProvider.Dispose();
            CameraDisplay45?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay46?.SourceProvider.Dispose();
            CameraDisplay46?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay47?.SourceProvider.Dispose();
            CameraDisplay47?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay48?.SourceProvider.Dispose();
            CameraDisplay48?.SourceProvider.MediaPlayer?.Dispose();
            CameraDisplay49?.SourceProvider.Dispose();
            CameraDisplay49?.SourceProvider.MediaPlayer?.Dispose();
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
