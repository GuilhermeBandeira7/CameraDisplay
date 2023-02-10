using System;
using System.IO;
using System.Reflection;
using System.Windows;
using Vlc.DotNet.Core;
using Vlc.DotNet.Wpf;
using MosaicoApp.ViewModel;
using MosaicoApp.Pages;
using System.Windows.Input;

namespace MosaicoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DirectoryInfo vlcLibDirectory;
        private VlcControl control;
        MosaicoVM vm;

        public MainWindow(MosaicoVM mosaicoVM)
        {
            InitializeComponent();
            this.WindowStyle = WindowStyle.None;
            vm = Resources["vm"] as MosaicoVM;
            vm.User = mosaicoVM.User;

            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            vlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
           
            //control.SourceProvider.CreatePlayer(vlcLibDirectory/* pass your player parameters here */);
            //control.SourceProvider.MediaPlayer.Play(new Uri("rtsp://admin:Mtw@12345@172.16.2.55:554"));

            
        }

        private void CloseWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void MaximizeWindowButton_Click(object sender, RoutedEventArgs e)
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
