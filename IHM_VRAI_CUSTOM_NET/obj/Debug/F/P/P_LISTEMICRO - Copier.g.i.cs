﻿#pragma checksum "..\..\..\..\F\P\P_LISTEMICRO - Copier.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A0B38FD90A9F95F93D77DFCA070B85F0721C512A1D5F88D6B2479BC940E4D360"
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
using IHM_VRAI_CUSTOM_NET.C;
using IHM_VRAI_CUSTOM_NET.F.P;
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


namespace IHM_VRAI_CUSTOM_NET.F.P {
    
    
    /// <summary>
    /// P_LISTEMICRO
    /// </summary>
    public partial class P_LISTEMICRO : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\F\P\P_LISTEMICRO - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_HomeTitle;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\F\P\P_LISTEMICRO - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_Nom;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\F\P\P_LISTEMICRO - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_Dispo;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\F\P\P_LISTEMICRO - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_Prix;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\F\P\P_LISTEMICRO - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_Description;
        
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
            System.Uri resourceLocater = new System.Uri("/IHM_VRAI_CUSTOM_NET;component/f/p/p_listemicro%20-%20copier.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\F\P\P_LISTEMICRO - Copier.xaml"
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
            this.TB_HomeTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TB_Nom = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TB_Dispo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TB_Prix = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TB_Description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            
            #line 117 "..\..\..\..\F\P\P_LISTEMICRO - Copier.xaml"
            ((System.Windows.Controls.ListBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

