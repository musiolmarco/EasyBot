﻿#pragma checksum "..\..\..\Views\CreateMouseActionWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1C4D63C3EE1971BEC28B76A2FED89A3489437D7ECCC75F8E31417DA8AA5CB7A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using EasyBot.Views;
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


namespace EasyBot.Views {
    
    
    /// <summary>
    /// CreateMouseActionWindow
    /// </summary>
    public partial class CreateMouseActionWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_X_Value;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_Y_Value;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_SetLocation;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_TestLocation;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_SetLocationInfo;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButton_Leftclick;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButton_Rightclick;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Delay;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Create;
        
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
            System.Uri resourceLocater = new System.Uri("/EasyBot;component/views/createmouseactionwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CreateMouseActionWindow.xaml"
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
            
            #line 8 "..\..\..\Views\CreateMouseActionWindow.xaml"
            ((EasyBot.Views.CreateMouseActionWindow)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Label_X_Value = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Label_Y_Value = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Button_SetLocation = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Views\CreateMouseActionWindow.xaml"
            this.Button_SetLocation.Click += new System.Windows.RoutedEventHandler(this.Button_SetLocation_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Button_TestLocation = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Label_SetLocationInfo = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.RadioButton_Leftclick = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.RadioButton_Rightclick = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.TextBox_Delay = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Button_Create = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Views\CreateMouseActionWindow.xaml"
            this.Button_Create.Click += new System.Windows.RoutedEventHandler(this.Button_Create_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

