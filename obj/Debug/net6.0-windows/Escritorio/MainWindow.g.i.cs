﻿#pragma checksum "..\..\..\..\Escritorio\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2759EDB0EBF0E715C72BC341EBCC9E135B0F05E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using uMind;


namespace uMind {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 36 "..\..\..\..\Escritorio\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimizar;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Escritorio\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Escritorio\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerCita;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\Escritorio\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegistrarCita;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Escritorio\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPsicologo;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\Escritorio\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridCitas;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\Escritorio\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridPacientes2;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\..\Escritorio\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegistrar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/uMind;component/escritorio/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Escritorio\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnMinimizar = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Escritorio\MainWindow.xaml"
            this.btnMinimizar.Click += new System.Windows.RoutedEventHandler(this.btnMinimizar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Escritorio\MainWindow.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.datePickerCita = ((System.Windows.Controls.DatePicker)(target));
            
            #line 73 "..\..\..\..\Escritorio\MainWindow.xaml"
            this.datePickerCita.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.changeSelectedDate);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 76 "..\..\..\..\Escritorio\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.dateForward);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 80 "..\..\..\..\Escritorio\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.dateBackward);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRegistrarCita = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\Escritorio\MainWindow.xaml"
            this.btnRegistrarCita.Click += new System.Windows.RoutedEventHandler(this.btnRegistrarCita_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbPsicologo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 90 "..\..\..\..\Escritorio\MainWindow.xaml"
            this.cbPsicologo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.changeSelectedDoctor);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dataGridCitas = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.dataGridPacientes2 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 13:
            
            #line 174 "..\..\..\..\Escritorio\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.nombrePaciente);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 175 "..\..\..\..\Escritorio\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.idPaciente);
            
            #line default
            #line hidden
            return;
            case 15:
            this.btnRegistrar = ((System.Windows.Controls.Button)(target));
            
            #line 178 "..\..\..\..\Escritorio\MainWindow.xaml"
            this.btnRegistrar.Click += new System.Windows.RoutedEventHandler(this.btnRegistrar_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 97 "..\..\..\..\Escritorio\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnModificarCita_Click);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 146 "..\..\..\..\Escritorio\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnModificarPaciente_Click);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 149 "..\..\..\..\Escritorio\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.deletePaciente);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

