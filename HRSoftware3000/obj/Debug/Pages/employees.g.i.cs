﻿#pragma checksum "..\..\..\Pages\employees.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6DE0AEDC57D2E579AB6B201D32930D9302555E0AE9D8D0C02B3456C546515B39"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using HRSoftware3000.Pages;
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


namespace HRSoftware3000.Pages {
    
    
    /// <summary>
    /// employees
    /// </summary>
    public partial class employees : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Pages\employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid employeeDataGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn name;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Vorname;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Abteilung;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Telefon;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddEmplyeeBtn;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateEmplyeeBtn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteEmplyeeBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/HRSoftware3000;component/pages/employees.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\employees.xaml"
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
            this.employeeDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.name = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 3:
            this.Vorname = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.Abteilung = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.Telefon = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.AddEmplyeeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Pages\employees.xaml"
            this.AddEmplyeeBtn.Click += new System.Windows.RoutedEventHandler(this.goToEmployeesAddPage);
            
            #line default
            #line hidden
            return;
            case 7:
            this.UpdateEmplyeeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Pages\employees.xaml"
            this.UpdateEmplyeeBtn.Click += new System.Windows.RoutedEventHandler(this.goToEmployeesUpdatePage);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DeleteEmplyeeBtn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

