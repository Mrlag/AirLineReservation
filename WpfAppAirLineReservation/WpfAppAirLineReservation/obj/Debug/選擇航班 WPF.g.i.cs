﻿#pragma checksum "..\..\選擇航班 WPF.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77C08C182A14E36BFA5361B8E16B0FB553595500"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfAppAirLineReservation;


namespace WpfAppAirLineReservation {
    
    
    /// <summary>
    /// 選擇航班_WPF
    /// </summary>
    public partial class 選擇航班_WPF : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\選擇航班 WPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander GoExpander;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\選擇航班 WPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox DeparturelistBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\選擇航班 WPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox2;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\選擇航班 WPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem listBox2Item;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\選擇航班 WPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander OrderDetailExpander;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\選擇航班 WPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ExpanderStack;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\選擇航班 WPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextStepButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppAirLineReservation;component/%e9%81%b8%e6%93%87%e8%88%aa%e7%8f%ad%20wpf.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\選擇航班 WPF.xaml"
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
            this.GoExpander = ((System.Windows.Controls.Expander)(target));
            return;
            case 2:
            this.DeparturelistBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.listBox2 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.listBox2Item = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 5:
            
            #line 80 "..\..\選擇航班 WPF.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.OrderDetailExpander = ((System.Windows.Controls.Expander)(target));
            return;
            case 7:
            this.ExpanderStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.NextStepButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

