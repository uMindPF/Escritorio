﻿#pragma checksum "..\..\..\..\Escritorio\RegistrarCita.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "583A652D0F31EE9B8B455E28279DA01C70D7E469"
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
    /// RegistrarCita
    /// </summary>
    public partial class RegistrarCita : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\Escritorio\RegistrarCita.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxID;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Escritorio\RegistrarCita.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxName;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Escritorio\RegistrarCita.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxDoctor;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Escritorio\RegistrarCita.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Guardar;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Escritorio\RegistrarCita.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAtras;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Escritorio\RegistrarCita.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerDia;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Escritorio\RegistrarCita.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxHora;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Escritorio\RegistrarCita.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxDuracion;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Escritorio\RegistrarCita.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxTipoVisita;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Escritorio\RegistrarCita.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxEstado;
        
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
            System.Uri resourceLocater = new System.Uri("/uMind;component/escritorio/registrarcita.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Escritorio\RegistrarCita.xaml"
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
            this.TextBoxID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextBoxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ComboBoxDoctor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\..\Escritorio\RegistrarCita.xaml"
            this.ComboBoxDoctor.DropDownClosed += new System.EventHandler(this.ComboBoxDoctor_OnDropDownClosed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Guardar = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\Escritorio\RegistrarCita.xaml"
            this.Guardar.Click += new System.Windows.RoutedEventHandler(this.Guardar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAtras = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\Escritorio\RegistrarCita.xaml"
            this.btnAtras.Click += new System.Windows.RoutedEventHandler(this.btnAtras_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DatePickerDia = ((System.Windows.Controls.DatePicker)(target));
            
            #line 65 "..\..\..\..\Escritorio\RegistrarCita.xaml"
            this.DatePickerDia.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePickerDia_OnSelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ComboBoxHora = ((System.Windows.Controls.ComboBox)(target));
            
            #line 69 "..\..\..\..\Escritorio\RegistrarCita.xaml"
            this.ComboBoxHora.DropDownClosed += new System.EventHandler(this.ComboBoxHora_OnDropDownClosed);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ComboBoxDuracion = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.ComboBoxTipoVisita = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.ComboBoxEstado = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

