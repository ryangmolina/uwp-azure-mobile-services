﻿#pragma checksum "C:\Users\RyanPC\Desktop\adprog\App\App\View\RestaurantInfo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "27D5856897DD0A950E392D6CDD894F4C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.View
{
    partial class RestaurantInfo : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        private class RestaurantInfo_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IRestaurantInfo_Bindings
        {
            private global::App.View.RestaurantInfo dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj2;
            private global::Windows.UI.Xaml.Controls.ListView obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj16;
            private global::Windows.UI.Xaml.Controls.TextBlock obj17;
            private global::Windows.UI.Xaml.Controls.TextBlock obj18;
            private global::Windows.UI.Xaml.Controls.TextBlock obj19;
            private global::Windows.UI.Xaml.Controls.TextBlock obj24;
            private global::Windows.UI.Xaml.Controls.ItemsControl obj25;

            public RestaurantInfo_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 16:
                        this.obj16 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 17:
                        this.obj17 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 18:
                        this.obj18 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 19:
                        this.obj19 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 24:
                        this.obj24 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 25:
                        this.obj25 = (global::Windows.UI.Xaml.Controls.ItemsControl)target;
                        break;
                    default:
                        break;
                }
            }

            // IRestaurantInfo_Bindings

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

            // RestaurantInfo_obj1_Bindings

            public void SetDataRoot(global::App.View.RestaurantInfo newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::App.View.RestaurantInfo obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Restaurant(obj.Restaurant, phase);
                    }
                }
            }
            private void Update_Restaurant(global::App.DataModel.Restaurant obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Restaurant_Name(obj.Name, phase);
                        this.Update_Restaurant_Feedback(obj.Feedback, phase);
                        this.Update_Restaurant_Address(obj.Address, phase);
                        this.Update_Restaurant_Description(obj.Description, phase);
                        this.Update_Restaurant_Cost(obj.Cost, phase);
                        this.Update_Restaurant_CuisineString(obj.CuisineString, phase);
                        this.Update_Restaurant_StoreTime(obj.StoreTime, phase);
                    }
                }
            }
            private void Update_Restaurant_Name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj2, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj16, obj, null);
                }
            }
            private void Update_Restaurant_Feedback(global::System.Collections.ObjectModel.ObservableCollection<global::App.DataModel.Feedback> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj9, obj, null);
                }
            }
            private void Update_Restaurant_Address(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj17, obj, null);
                }
            }
            private void Update_Restaurant_Description(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj18, obj, null);
                }
            }
            private void Update_Restaurant_Cost(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj19, obj.ToString(), null);
                }
            }
            private void Update_Restaurant_CuisineString(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj24, obj, null);
                }
            }
            private void Update_Restaurant_StoreTime(global::System.Collections.Generic.ICollection<global::App.DataModel.StoreTime> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj25, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.titleBar = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.infoPageScrollViewer = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 4:
                {
                    this.infoPage = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 5:
                {
                    this.sidebar = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    this.overview = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 7:
                {
                    this.menu = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 8:
                {
                    this.reviewTextBox = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 9:
                {
                    this.reviewList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 10:
                {
                    this.header = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.profilePicture = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.reviewEditBox = (global::Windows.UI.Xaml.Controls.RichEditBox)(target);
                }
                break;
            case 13:
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 98 "..\..\..\View\RestaurantInfo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.Button_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.menuImages = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 78 "..\..\..\View\RestaurantInfo.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.menuImages).ItemClick += this.menuImages_ItemClick;
                    #line default
                }
                break;
            case 15:
                {
                    this.coverPhoto = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 16:
                {
                    this.restaurantName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.location = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.description = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.creditCard = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21:
                {
                    this.wifi = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22:
                {
                    this.petFriendly = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23:
                {
                    this.outdoorSeating = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26:
                {
                    this.wide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 27:
                {
                    this.narrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    RestaurantInfo_obj1_Bindings bindings = new RestaurantInfo_obj1_Bindings();
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

