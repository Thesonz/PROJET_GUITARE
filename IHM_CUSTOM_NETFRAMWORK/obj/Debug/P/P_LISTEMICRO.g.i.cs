﻿#pragma checksum "..\..\..\P\P_LISTEMICRO.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "224B36BA049974C2FBCB2AC6FA82FDC7B10407EBA4A13C1D99CBA170E10D5779"
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
using IHM_CUSTOM_NETFRAMWORK.C;
using IHM_CUSTOM_NETFRAMWORK.P;
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


namespace IHM_CUSTOM_NETFRAMWORK.P {
    
    
    /// <summary>
    /// P_LISTEMICRO
    /// </summary>
    public partial class P_LISTEMICRO : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "..\..\..\P\P_LISTEMICRO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_NombreVue;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\P\P_LISTEMICRO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Nouveau;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\P\P_LISTEMICRO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Modifier;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\P\P_LISTEMICRO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Supprimer;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\P\P_LISTEMICRO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_Erreur;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\P\P_LISTEMICRO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Nom;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\P\P_LISTEMICRO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Dispo;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\P\P_LISTEMICRO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Prix;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\P\P_LISTEMICRO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Description;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\P\P_LISTEMICRO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Vider;
        
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
            System.Uri resourceLocater = new System.Uri("/IHM_CUSTOM_NETFRAMWORK;component/p/p_listemicro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\P\P_LISTEMICRO.xaml"
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
            this.TB_NombreVue = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.BTN_Nouveau = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\P\P_LISTEMICRO.xaml"
            this.BTN_Nouveau.Click += new System.Windows.RoutedEventHandler(this.BTN_Nouveau_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_Modifier = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\P\P_LISTEMICRO.xaml"
            this.BTN_Modifier.Click += new System.Windows.RoutedEventHandler(this.BTN_Modifier_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_Supprimer = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\P\P_LISTEMICRO.xaml"
            this.BTN_Supprimer.Click += new System.Windows.RoutedEventHandler(this.BTN_Supprimer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TB_Erreur = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.TB_Nom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TB_Dispo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TB_Prix = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.TB_Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.BTN_Vider = ((System.Windows.Controls.Button)(target));
            
            #line 206 "..\..\..\P\P_LISTEMICRO.xaml"
            this.BTN_Vider.Click += new System.Windows.RoutedEventHandler(this.BTN_Vider_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

