﻿#pragma checksum "D:\coursewave\ModernOSAppDevlop\VS_Projects\Competition\Competition\Views\MatchInfo\MatchCreated.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "381A5375E8E9B37306BBECCE83556696"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Competition.Views.MatchInfo
{
    partial class MatchCreated : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MatchCreated_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMatchCreated_Bindings
        {
            private global::Competition.Views.MatchInfo.MatchCreated dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBox obj3;
            private global::Windows.UI.Xaml.Controls.TextBox obj4;
            private global::Windows.UI.Xaml.Controls.TextBox obj5;
            private global::Windows.UI.Xaml.Controls.TextBox obj6;
            private global::Windows.UI.Xaml.Controls.TextBox obj7;
            private global::Windows.UI.Xaml.Controls.TextBox obj8;
            private global::Windows.UI.Xaml.Controls.TextBox obj9;
            private global::Windows.UI.Xaml.Controls.TextBox obj10;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;

            public MatchCreated_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Views\MatchInfo\MatchCreated.xaml line 43
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 4: // Views\MatchInfo\MatchCreated.xaml line 32
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 5: // Views\MatchInfo\MatchCreated.xaml line 34
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 6: // Views\MatchInfo\MatchCreated.xaml line 36
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 7: // Views\MatchInfo\MatchCreated.xaml line 38
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 8: // Views\MatchInfo\MatchCreated.xaml line 23
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 9: // Views\MatchInfo\MatchCreated.xaml line 25
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 10: // Views\MatchInfo\MatchCreated.xaml line 27
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 11: // Views\MatchInfo\MatchCreated.xaml line 17
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IMatchCreated_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Competition.Views.MatchInfo.MatchCreated)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Competition.Views.MatchInfo.MatchCreated obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_matchesVM(obj.matchesVM, phase);
                        this.Update_matchEvent(obj.matchEvent, phase);
                        this.Update_matchType(obj.matchType, phase);
                    }
                }
            }
            private void Update_matchesVM(global::Competition.ViewModels.MatchesVM obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_matchesVM_SelectedMatch(obj.SelectedMatch, phase);
                    }
                }
            }
            private void Update_matchesVM_SelectedMatch(global::Competition.Models.Matches obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_matchesVM_SelectedMatch_seedNumber(obj.seedNumber, phase);
                        this.Update_matchesVM_SelectedMatch_placeContain(obj.placeContain, phase);
                        this.Update_matchesVM_SelectedMatch_place(obj.place, phase);
                        this.Update_matchesVM_SelectedMatch_sectionPerDay(obj.sectionPerDay, phase);
                        this.Update_matchesVM_SelectedMatch_matchLastTime(obj.matchLastTime, phase);
                        this.Update_matchesVM_SelectedMatch_startTime(obj.startTime, phase);
                        this.Update_matchesVM_SelectedMatch_name(obj.name, phase);
                    }
                }
            }
            private void Update_matchesVM_SelectedMatch_seedNumber(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MatchInfo\MatchCreated.xaml line 43
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj3, obj, null);
                }
            }
            private void Update_matchesVM_SelectedMatch_placeContain(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MatchInfo\MatchCreated.xaml line 32
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj4, obj, null);
                }
            }
            private void Update_matchesVM_SelectedMatch_place(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MatchInfo\MatchCreated.xaml line 34
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj5, obj, null);
                }
            }
            private void Update_matchesVM_SelectedMatch_sectionPerDay(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MatchInfo\MatchCreated.xaml line 36
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj6, obj, null);
                }
            }
            private void Update_matchesVM_SelectedMatch_matchLastTime(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MatchInfo\MatchCreated.xaml line 38
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj7, obj, null);
                }
            }
            private void Update_matchEvent(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MatchInfo\MatchCreated.xaml line 23
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj8, obj, null);
                }
            }
            private void Update_matchType(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MatchInfo\MatchCreated.xaml line 25
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj9, obj, null);
                }
            }
            private void Update_matchesVM_SelectedMatch_startTime(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MatchInfo\MatchCreated.xaml line 27
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj10, obj, null);
                }
            }
            private void Update_matchesVM_SelectedMatch_name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MatchInfo\MatchCreated.xaml line 17
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MatchInfo\MatchCreated.xaml line 30
                {
                    this.TennisAddition = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 11: // Views\MatchInfo\MatchCreated.xaml line 17
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\MatchInfo\MatchCreated.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MatchCreated_obj1_Bindings bindings = new MatchCreated_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
