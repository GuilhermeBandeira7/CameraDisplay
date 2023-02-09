﻿using System;
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
    /// Interaction logic for Page4x4.xaml
    /// </summary>
    public partial class Page4x4 : Page
    {
        public Page4x4()
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