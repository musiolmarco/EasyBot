﻿#pragma checksum "..\..\..\Views\CreateMouseActionWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EEAD3EB51CA843221D570E8CC5A4D605C7121E1D52FDDC84B502FF7C0AC1E45C"
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
        
        
        #line 20 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_X_Value;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_Y_Value;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_SetLocation;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_TestLocation;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButton_Leftclick;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButton_Rightclick;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\CreateMouseActionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Delay;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\CreateMouseActionWindow.xaml"
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
            this.Label_X_Value = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Label_Y_Value = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Button_SetLocation = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Button_TestLocation = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.RadioButton_Leftclick = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.RadioButton_Rightclick = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.TextBox_Delay = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Button_Create = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Views\CreateMouseActionWindow.xaml"
            this.Button_Create.Click += new System.Windows.RoutedEventHandler(this.Button_Create_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
