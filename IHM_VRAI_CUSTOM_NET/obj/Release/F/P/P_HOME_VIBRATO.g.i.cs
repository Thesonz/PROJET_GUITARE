﻿#pragma checksum "..\..\..\..\F\P\P_HOME_VIBRATO.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "862F29DF915D7399A24D12E3B580193BBCC16318B9BF38D5BD601B20F735265D"
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
    /// P_HOME_VIBRATO
    /// </summary>
    public partial class P_HOME_VIBRATO : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\F\P\P_HOME_VIBRATO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_HomeTitle;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\F\P\P_HOME_VIBRATO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_Vibrato;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\F\P\P_HOME_VIBRATO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Suivant;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\F\P\P_HOME_VIBRATO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Precedent;
        
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
            System.Uri resourceLocater = new System.Uri("/IHM_VRAI_CUSTOM_NET;component/f/p/p_home_vibrato.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\F\P\P_HOME_VIBRATO.xaml"
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
            this.CB_Vibrato = ((System.Windows.Controls.ComboBox)(target));
            
            #line 98 "..\..\..\..\F\P\P_HOME_VIBRATO.xaml"
            this.CB_Vibrato.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CB_Vibrato_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_Suivant = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\..\F\P\P_HOME_VIBRATO.xaml"
            this.BTN_Suivant.Click += new System.Windows.RoutedEventHandler(this.BTN_Suivant_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_Precedent = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\..\..\F\P\P_HOME_VIBRATO.xaml"
            this.BTN_Precedent.Click += new System.Windows.RoutedEventHandler(this.BTN_Precedent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
