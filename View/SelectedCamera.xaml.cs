using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Vlc.DotNet.Wpf;

namespace MosaicoApp.View
{
    /// <summary>
    /// Interaction logic for SelectedCamera.xaml
    /// </summary>
    public partial class SelectedCamera : Window
    {
        private readonly DirectoryInfo vlcLibDirectory;

        public SelectedCamera(string rtsp)
        {
            InitializeComponent();
            this.WindowStyle = WindowStyle.None;
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            vlcLibDirectory = new DirectoryInfo(System.IO.Path.Combine
                (currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));

            StarCamera(rtsp);
        }

        private void SelectedCamera_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        internal void StarCamera(string rtsp)
        {
            camera.SourceProvider.CreatePlayer(vlcLibDirectory);
            camera.SourceProvider.MediaPlayer?.Play(rtsp);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {           
            base.OnClosing(e);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
                  
        }
    }
}
