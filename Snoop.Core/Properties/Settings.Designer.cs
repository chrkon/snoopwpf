//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Snoop.DebugListenerTab;

namespace Snoop.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public WINDOWPLACEMENT? SnoopUIWindowPlacement {
            get {
                return ((WINDOWPLACEMENT?)(this["SnoopUIWindowPlacement"]));
            }
            set {
                this["SnoopUIWindowPlacement"] = value;
            }
        }
               
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public WINDOWPLACEMENT? ZoomerWindowPlacement {
            get {
                return ((WINDOWPLACEMENT?)(this["ZoomerWindowPlacement"]));
            }
            set {
                this["ZoomerWindowPlacement"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n        <ArrayOfPropertyFilter" +
            "Set xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"\r\n        xmlns:xsd=\"ht" +
            "tp://www.w3.org/2001/XMLSchema\">\r\n        <PropertyFilterSet>\r\n        <DisplayN" +
            "ame>Layout</DisplayName>\r\n        <IsDefault>false</IsDefault>\r\n        <IsEditC" +
            "ommand>false</IsEditCommand>\r\n        <Properties>\r\n        <string>width</strin" +
            "g>\r\n        <string>height</string>\r\n        <string>actualwidth</string>\r\n     " +
            "   <string>actualheight</string>\r\n        <string>margin</string>\r\n        <stri" +
            "ng>padding</string>\r\n        <string>canvas.left</string>\r\n        <string>canva" +
            "s.top</string>\r\n        </Properties>\r\n        </PropertyFilterSet>\r\n        <Pr" +
            "opertyFilterSet>\r\n        <DisplayName>Grid/Dock</DisplayName>\r\n        <IsDefau" +
            "lt>false</IsDefault>\r\n        <IsEditCommand>false</IsEditCommand>\r\n        <Pro" +
            "perties>\r\n        <string>grid.</string>\r\n        <string>dockpanel.dock</string" +
            ">\r\n        </Properties>\r\n        </PropertyFilterSet>\r\n        <PropertyFilterS" +
            "et>\r\n        <DisplayName>Color</DisplayName>\r\n        <IsDefault>false</IsDefau" +
            "lt>\r\n        <IsEditCommand>false</IsEditCommand>\r\n        <Properties>\r\n       " +
            " <string>color</string>\r\n        <string>background</string>\r\n        <string>fo" +
            "reground</string>\r\n        <string>borderbrush</string>\r\n        <string>fill</s" +
            "tring>\r\n        <string>stroke</string>\r\n        </Properties>\r\n        </Proper" +
            "tyFilterSet>\r\n        <PropertyFilterSet>\r\n        <DisplayName>ItemsControl</Di" +
            "splayName>\r\n        <IsDefault>false</IsDefault>\r\n        <IsEditCommand>false</" +
            "IsEditCommand>\r\n        <Properties>\r\n        <string>items</string>\r\n        <s" +
            "tring>selected</string>\r\n        </Properties>\r\n        </PropertyFilterSet>\r\n  " +
            "      </ArrayOfPropertyFilterSet>\r\n      ")]
        public PropertyFilterSet[] PropertyFilterSets
        {
            get
            {
                return ((PropertyFilterSet[])(this["PropertyFilterSets"]));
            }
            set
            {
                this["PropertyFilterSets"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowDefaults {
            get {
                return ((bool)(this["ShowDefaults"]));
            }
            set {
                this["ShowDefaults"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowPreviewer {
            get {
                return ((bool)(this["ShowPreviewer"]));
            }
            set {
                this["ShowPreviewer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ClearAfterDelve {
            get {
                return ((bool)(this["ClearAfterDelve"]));
            }
            set {
                this["ClearAfterDelve"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public SnoopSingleFilter[] SnoopDebugFilters
        {
            get
            {
                return ((SnoopSingleFilter[])(this["SnoopDebugFilters"]));
            }
            set
            {
                this["SnoopDebugFilters"] = value;
            }
        }
    }
}
