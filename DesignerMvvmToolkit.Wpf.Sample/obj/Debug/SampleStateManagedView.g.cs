﻿#pragma checksum "..\..\SampleStateManagedView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "47A5F7184BE8FB1768659EB062FF0ACA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DesignerMvvmToolkit.Behaviors;
using MicroMvvmSample;
using Microsoft.Expression.Interactivity.Core;
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
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MicroMvvmSample {
    
    
    /// <summary>
    /// SampleStateManagedView
    /// </summary>
    public partial class SampleStateManagedView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\SampleStateManagedView.xaml"
        internal System.Windows.VisualStateGroup CoreStates;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\SampleStateManagedView.xaml"
        internal System.Windows.VisualState PrimaryState;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SampleStateManagedView.xaml"
        internal System.Windows.VisualState SecondaryState;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\SampleStateManagedView.xaml"
        internal System.Windows.Shapes.Rectangle PrimaryRectangle;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\SampleStateManagedView.xaml"
        internal System.Windows.Shapes.Rectangle SecondaryRectangle;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DesignerMvvmToolkit.Wpf.Sample;component/samplestatemanagedview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SampleStateManagedView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CoreStates = ((System.Windows.VisualStateGroup)(target));
            return;
            case 2:
            this.PrimaryState = ((System.Windows.VisualState)(target));
            return;
            case 3:
            this.SecondaryState = ((System.Windows.VisualState)(target));
            return;
            case 4:
            this.PrimaryRectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.SecondaryRectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}