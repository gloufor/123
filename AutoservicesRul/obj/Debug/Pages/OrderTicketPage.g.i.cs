﻿#pragma checksum "..\..\..\Pages\OrderTicketPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AC615397E6B0D68B7498B286EA239A68E239BD8178562D1FF1E12C4876807D43"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoservicesRul.Pages;
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


namespace AutoservicesRul.Pages {
    
    
    /// <summary>
    /// OrderTicketPage
    /// </summary>
    public partial class OrderTicketPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Pages\OrderTicketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.FlowDocument FlowDoc;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\OrderTicketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtProductList;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\OrderTicketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtCost;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\OrderTicketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDiscountSum;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\OrderTicketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPickupPoint;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\OrderTicketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveDocument;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoservicesRul;component/pages/orderticketpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\OrderTicketPage.xaml"
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
            this.FlowDoc = ((System.Windows.Documents.FlowDocument)(target));
            return;
            case 2:
            this.txtProductList = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtCost = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtDiscountSum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.txtPickupPoint = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btnSaveDocument = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Pages\OrderTicketPage.xaml"
            this.btnSaveDocument.Click += new System.Windows.RoutedEventHandler(this.btnSaveDocument_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

