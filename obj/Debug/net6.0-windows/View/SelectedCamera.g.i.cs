﻿#pragma checksum "..\..\..\..\View\SelectedCamera.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79953E4DB436EDDB8B1D1B1C0D6D6FFF3D59BDBA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MosaicoApp.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Vlc.DotNet.Wpf;


namespace MosaicoApp.View {
    
    
    /// <summary>
    /// SelectedCamera
    /// </summary>
    public partial class SelectedCamera : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\View\SelectedCamera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Vlc.DotNet.Wpf.VlcControl camera;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MosaicoApp;component/view/selectedcamera.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\SelectedCamera.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\..\View\SelectedCamera.xaml"
            ((MosaicoApp.View.SelectedCamera)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.SelectedCamera_OnKeyDown);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\..\View\SelectedCamera.xaml"
            ((MosaicoApp.View.SelectedCamera)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\View\SelectedCamera.xaml"
            ((MosaicoApp.View.SelectedCamera)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.camera = ((Vlc.DotNet.Wpf.VlcControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
