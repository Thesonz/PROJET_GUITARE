﻿#pragma checksum "..\..\..\F\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8E66A38FAA8C8121C449BA96252BAB786C5950D28CD9D255AA7FDE6997B4CD4B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.Sharp;
using IHM_VRAI_CUSTOM_NET;
using IHM_VRAI_CUSTOM_NET.C;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace IHM_VRAI_CUSTOM_NET.F {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\F\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_PN;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\F\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Home;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\F\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Bois;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\F\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Micro;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\F\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Vibrato;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\F\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Commande;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\F\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Quitter;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\F\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame F_Page;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/IHM_VRAI_CUSTOM_NET;component/f/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\F\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TB_PN = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.BTN_Home = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\F\MainWindow.xaml"
            this.BTN_Home.Click += new System.Windows.RoutedEventHandler(this.BTN_Home_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_Bois = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\F\MainWindow.xaml"
            this.BTN_Bois.Click += new System.Windows.RoutedEventHandler(this.BTN_Bois_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_Micro = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\F\MainWindow.xaml"
            this.BTN_Micro.Click += new System.Windows.RoutedEventHandler(this.BTN_Micro_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_Vibrato = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\F\MainWindow.xaml"
            this.BTN_Vibrato.Click += new System.Windows.RoutedEventHandler(this.BTN_Vibrato_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BTN_Commande = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\F\MainWindow.xaml"
            this.BTN_Commande.Click += new System.Windows.RoutedEventHandler(this.BTN_Commande_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BTN_Quitter = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\F\MainWindow.xaml"
            this.BTN_Quitter.Click += new System.Windows.RoutedEventHandler(this.BTN_Quitter_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 109 "..\..\..\F\MainWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.F_Page = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
