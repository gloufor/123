﻿#pragma checksum "..\..\..\Pages\Admin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3C9EEE4B238A0B20A0C452A798F794A2F8CF360471F4D6A6F33B0B4B7DBD7DD"
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
    /// Admin
    /// </summary>
    public partial class Admin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBoxSorting;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBoxFilter;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockFullNameUser;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockResultAmount;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockResultAmountMax;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewProduct;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu contextMenuProduct;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnAddProduct;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOrder;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddNewProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoservicesRul;component/pages/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Admin.xaml"
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
            
            #line 9 "..\..\..\Pages\Admin.xaml"
            ((AutoservicesRul.Pages.Admin)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\Pages\Admin.xaml"
            this.txtBoxSearch.SelectionChanged += new System.Windows.RoutedEventHandler(this.txtBoxSearch_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbBoxSorting = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\..\Pages\Admin.xaml"
            this.cmbBoxSorting.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbBoxSorting_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbBoxFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\Pages\Admin.xaml"
            this.cmbBoxFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbBoxFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtBlockFullNameUser = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtBlockResultAmount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtBlockResultAmountMax = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.LViewProduct = ((System.Windows.Controls.ListView)(target));
            
            #line 46 "..\..\..\Pages\Admin.xaml"
            this.LViewProduct.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LViewProduct_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.contextMenuProduct = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 10:
            this.btnAddProduct = ((System.Windows.Controls.MenuItem)(target));
            
            #line 82 "..\..\..\Pages\Admin.xaml"
            this.btnAddProduct.Click += new System.Windows.RoutedEventHandler(this.btnAddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnOrder = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\Pages\Admin.xaml"
            this.btnOrder.Click += new System.Windows.RoutedEventHandler(this.btnOrder_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnAddNewProduct = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\Pages\Admin.xaml"
            this.btnAddNewProduct.Click += new System.Windows.RoutedEventHandler(this.btnAddNewProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

