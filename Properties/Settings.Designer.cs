﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aifrus.SimGPS2.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string Hostname {
            get {
                return ((string)(this["Hostname"]));
            }
            set {
                this["Hostname"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60 FPS")]
        public string RefreshRate {
            get {
                return ((string)(this["RefreshRate"]));
            }
            set {
                this["RefreshRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int AutoStart {
            get {
                return ((int)(this["AutoStart"]));
            }
            set {
                this["AutoStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoPower {
            get {
                return ((bool)(this["AutoPower"]));
            }
            set {
                this["AutoPower"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoRecord {
            get {
                return ((bool)(this["AutoRecord"]));
            }
            set {
                this["AutoRecord"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TopMost {
            get {
                return ((bool)(this["TopMost"]));
            }
            set {
                this["TopMost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowTaskbar {
            get {
                return ((bool)(this["ShowTaskbar"]));
            }
            set {
                this["ShowTaskbar"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool NotifyIcon {
            get {
                return ((bool)(this["NotifyIcon"]));
            }
            set {
                this["NotifyIcon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Cyan")]
        public global::System.Drawing.Color LEDColor {
            get {
                return ((global::System.Drawing.Color)(this["LEDColor"]));
            }
            set {
                this["LEDColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{Documents}\\SimGPS Recordings")]
        public string RecordingPath {
            get {
                return ((string)(this["RecordingPath"]));
            }
            set {
                this["RecordingPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Disabled")]
        public string Port {
            get {
                return ((string)(this["Port"]));
            }
            set {
                this["Port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4800")]
        public string Baud {
            get {
                return ((string)(this["Baud"]));
            }
            set {
                this["Baud"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public string Data {
            get {
                return ((string)(this["Data"]));
            }
            set {
                this["Data"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("N - None")]
        public string Parity {
            get {
                return ((string)(this["Parity"]));
            }
            set {
                this["Parity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public string Stop {
            get {
                return ((string)(this["Stop"]));
            }
            set {
                this["Stop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GNSS")]
        public string DeviceType {
            get {
                return ((string)(this["DeviceType"]));
            }
            set {
                this["DeviceType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool GGA {
            get {
                return ((bool)(this["GGA"]));
            }
            set {
                this["GGA"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RMC {
            get {
                return ((bool)(this["RMC"]));
            }
            set {
                this["RMC"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool VTG {
            get {
                return ((bool)(this["VTG"]));
            }
            set {
                this["VTG"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool GSV {
            get {
                return ((bool)(this["GSV"]));
            }
            set {
                this["GSV"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool GSA {
            get {
                return ((bool)(this["GSA"]));
            }
            set {
                this["GSA"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("320")]
        public int MainLocationX {
            get {
                return ((int)(this["MainLocationX"]));
            }
            set {
                this["MainLocationX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("160")]
        public int MainLocationY {
            get {
                return ((int)(this["MainLocationY"]));
            }
            set {
                this["MainLocationY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("320")]
        public int SettingsLocationX {
            get {
                return ((int)(this["SettingsLocationX"]));
            }
            set {
                this["SettingsLocationX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("320")]
        public int SettingsLocationY {
            get {
                return ((int)(this["SettingsLocationY"]));
            }
            set {
                this["SettingsLocationY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FT")]
        public string UnitsAltitude {
            get {
                return ((string)(this["UnitsAltitude"]));
            }
            set {
                this["UnitsAltitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("KT")]
        public string UnitsSpeed {
            get {
                return ((string)(this["UnitsSpeed"]));
            }
            set {
                this["UnitsSpeed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NM")]
        public string UnitsDistance {
            get {
                return ((string)(this["UnitsDistance"]));
            }
            set {
                this["UnitsDistance"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HemisphereNESW {
            get {
                return ((bool)(this["HemisphereNESW"]));
            }
            set {
                this["HemisphereNESW"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DMS")]
        public string LatLonFormat {
            get {
                return ((string)(this["LatLonFormat"]));
            }
            set {
                this["LatLonFormat"] = value;
            }
        }
    }
}
