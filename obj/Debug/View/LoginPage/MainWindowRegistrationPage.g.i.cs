﻿#pragma checksum "..\..\..\..\View\LoginPage\MainWindowRegistrationPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FF1D0370676400F314D181368516399349FC6004222EF128E62588B7CB5F4CCC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using freelance.View.LoginPage;


namespace freelance.View.LoginPage {
    
    
    /// <summary>
    /// MainWindowRegistrationPage
    /// </summary>
    public partial class MainWindowRegistrationPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\..\View\LoginPage\MainWindowRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbFullName;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\View\LoginPage\MainWindowRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbPhone;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\View\LoginPage\MainWindowRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbEmail;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\View\LoginPage\MainWindowRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbSkills;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\View\LoginPage\MainWindowRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegistration;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\View\LoginPage\MainWindowRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/freelance;component/view/loginpage/mainwindowregistrationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\LoginPage\MainWindowRegistrationPage.xaml"
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
            this.TbFullName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TbPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TbEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TbSkills = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BtnRegistration = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\..\View\LoginPage\MainWindowRegistrationPage.xaml"
            this.BtnRegistration.Click += new System.Windows.RoutedEventHandler(this.BtnRegistration_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\..\View\LoginPage\MainWindowRegistrationPage.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

