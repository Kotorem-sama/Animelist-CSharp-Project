﻿#pragma checksum "..\..\LoginPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "00A92DC8F1805A45FA8B371CCDC6960FA39C919FADC4E6590C43074964DDDBF1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Animelist_CSharp_Project;
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


namespace Animelist_CSharp_Project {
    
    
    /// <summary>
    /// LoginPage
    /// </summary>
    public partial class LoginPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label wrongData;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordTextBoxShow;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowPasswordButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ShowPasswordImage;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Animelist-CSharp-Project;component/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginPage.xaml"
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
            this.wrongData = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.UsernameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\LoginPage.xaml"
            this.UsernameTextBox.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_LostKeyboardFocusUsername);
            
            #line default
            #line hidden
            
            #line 21 "..\..\LoginPage.xaml"
            this.UsernameTextBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 22 "..\..\LoginPage.xaml"
            this.PasswordTextBox.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_LostKeyboardFocusPassword);
            
            #line default
            #line hidden
            
            #line 22 "..\..\LoginPage.xaml"
            this.PasswordTextBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.PasswordBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PasswordTextBoxShow = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\LoginPage.xaml"
            this.PasswordTextBoxShow.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_LostKeyboardFocusShowPassword);
            
            #line default
            #line hidden
            
            #line 23 "..\..\LoginPage.xaml"
            this.PasswordTextBoxShow.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ShowPasswordButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\LoginPage.xaml"
            this.ShowPasswordButton.Click += new System.Windows.RoutedEventHandler(this.ShowPasswordButtonEvent);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ShowPasswordImage = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\LoginPage.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

