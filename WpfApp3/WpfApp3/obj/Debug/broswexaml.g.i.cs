﻿#pragma checksum "..\..\broswexaml.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4CB961ACD13586A7D894465B3811A4B594E5EB4D888DCF738E123FC77C84A056"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp3;


namespace WpfApp3 {
    
    
    /// <summary>
    /// broswexaml
    /// </summary>
    public partial class broswexaml : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\broswexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGlibirary;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\broswexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchtxt;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\broswexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\broswexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_butt;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\broswexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\broswexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IDtxt;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\broswexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox authertxt;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\broswexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Namext;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\broswexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox catIDtxt;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/broswexaml.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\broswexaml.xaml"
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
            this.DGlibirary = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.searchtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Search = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\broswexaml.xaml"
            this.Search.Click += new System.Windows.RoutedEventHandler(this.Search_butt);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Add_butt = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\broswexaml.xaml"
            this.Add_butt.Click += new System.Windows.RoutedEventHandler(this.Add_butt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 134 "..\..\broswexaml.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_butt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\broswexaml.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_butt);
            
            #line default
            #line hidden
            return;
            case 7:
            this.IDtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.authertxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Namext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.catIDtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

