﻿#pragma checksum "..\..\..\XamlPages\LoginPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E1789E68B5637346D3FAA835EE99481B23C55DA20216509520AC6B27AE1ACF97"
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
        
        
        #line 40 "..\..\..\XamlPages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label wrongData;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\XamlPages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NoAccountMatch;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\XamlPages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameTextBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\XamlPages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\XamlPages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordTextBoxShow;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\XamlPages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowPasswordButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\XamlPages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ShowPasswordImage;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\XamlPages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\XamlPages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Animelist-CSharp-Project;component/xamlpages/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\XamlPages\LoginPage.xaml"
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
            this.NoAccountMatch = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.UsernameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\XamlPages\LoginPage.xaml"
            this.UsernameTextBox.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.LostKeyFocus);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\XamlPages\LoginPage.xaml"
            this.UsernameTextBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.GotKeyFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 45 "..\..\..\XamlPages\LoginPage.xaml"
            this.PasswordTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.PasswordEnter);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\XamlPages\LoginPage.xaml"
            this.PasswordTextBox.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.LostKeyFocus);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\XamlPages\LoginPage.xaml"
            this.PasswordTextBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.GotKeyFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PasswordTextBoxShow = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\XamlPages\LoginPage.xaml"
            this.PasswordTextBoxShow.KeyDown += new System.Windows.Input.KeyEventHandler(this.PasswordEnter);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\XamlPages\LoginPage.xaml"
            this.PasswordTextBoxShow.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.LostKeyFocus);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\XamlPages\LoginPage.xaml"
            this.PasswordTextBoxShow.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.GotKeyFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ShowPasswordButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\XamlPages\LoginPage.xaml"
            this.ShowPasswordButton.Click += new System.Windows.RoutedEventHandler(this.ShowPasswordButtonEvent);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ShowPasswordImage = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\XamlPages\LoginPage.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.RegisterButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\XamlPages\LoginPage.xaml"
            this.RegisterButton.Click += new System.Windows.RoutedEventHandler(this.RegisterButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

