﻿#pragma checksum "..\..\..\..\F\P\P_HOME_COMMANDER.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC86A665866ADAF5EA5EC86566FF147C59559E33E993A85651FD350CCCB76166"
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
    /// P_HOME_COMMANDER
    /// </summary>
    public partial class P_HOME_COMMANDER : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\F\P\P_HOME_COMMANDER.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_HomeTitle;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\F\P\P_HOME_COMMANDER.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_Descriptif;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\F\P\P_HOME_COMMANDER.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Suivant;
        
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
            System.Uri resourceLocater = new System.Uri("/IHM_VRAI_CUSTOM_NET;component/f/p/p_home_commander.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\F\P\P_HOME_COMMANDER.xaml"
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
            this.TB_Descriptif = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BTN_Suivant = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\F\P\P_HOME_COMMANDER.xaml"
            this.BTN_Suivant.Click += new System.Windows.RoutedEventHandler(this.BTN_Suivant_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

