﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace PnP_Character_Nexus
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[14];
            _typeNameTable[0] = "PnP_Character_Nexus.CharacterEdit";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "Windows.Storage.Pickers.FolderPicker";
            _typeNameTable[4] = "Object";
            _typeNameTable[5] = "Windows.Storage.Pickers.PickerViewMode";
            _typeNameTable[6] = "System.Enum";
            _typeNameTable[7] = "System.ValueType";
            _typeNameTable[8] = "Windows.Storage.Pickers.PickerLocationId";
            _typeNameTable[9] = "String";
            _typeNameTable[10] = "System.Collections.Generic.IList`1<String>";
            _typeNameTable[11] = "Windows.Foundation.Collections.ValueSet";
            _typeNameTable[12] = "PnP_Character_Nexus.Views.Start";
            _typeNameTable[13] = "PnP_Character_Nexus.Views.WelcomeScreen";

            _typeTable = new global::System.Type[14];
            _typeTable[0] = typeof(global::PnP_Character_Nexus.CharacterEdit);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::Windows.Storage.Pickers.FolderPicker);
            _typeTable[4] = typeof(global::System.Object);
            _typeTable[5] = typeof(global::Windows.Storage.Pickers.PickerViewMode);
            _typeTable[6] = typeof(global::System.Enum);
            _typeTable[7] = typeof(global::System.ValueType);
            _typeTable[8] = typeof(global::Windows.Storage.Pickers.PickerLocationId);
            _typeTable[9] = typeof(global::System.String);
            _typeTable[10] = typeof(global::System.Collections.Generic.IList<global::System.String>);
            _typeTable[11] = typeof(global::Windows.Foundation.Collections.ValueSet);
            _typeTable[12] = typeof(global::PnP_Character_Nexus.Views.Start);
            _typeTable[13] = typeof(global::PnP_Character_Nexus.Views.WelcomeScreen);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_CharacterEdit() { return new global::PnP_Character_Nexus.CharacterEdit(); }
        private object Activate_3_FolderPicker() { return new global::Windows.Storage.Pickers.FolderPicker(); }
        private object Activate_11_ValueSet() { return new global::Windows.Foundation.Collections.ValueSet(); }
        private object Activate_12_Start() { return new global::PnP_Character_Nexus.Views.Start(); }
        private object Activate_13_WelcomeScreen() { return new global::PnP_Character_Nexus.Views.WelcomeScreen(); }
        private void VectorAdd_10_IList(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::System.String>)instance;
            var newItem = (global::System.String)item;
            collection.Add(newItem);
        }
        private void MapAdd_11_ValueSet(object instance, object key, object item)
        {
            var collection = (global::System.Collections.Generic.IDictionary<global::System.String, global::System.Object>)instance;
            var newKey = (global::System.String)key;
            var newItem = (global::System.Object)item;
            collection.Add(newKey, newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  PnP_Character_Nexus.CharacterEdit
                userType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_CharacterEdit;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Windows.Storage.Pickers.FolderPicker
                userType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_3_FolderPicker;
                userType.AddMemberName("ViewMode");
                userType.AddMemberName("SuggestedStartLocation");
                userType.AddMemberName("SettingsIdentifier");
                userType.AddMemberName("CommitButtonText");
                userType.AddMemberName("FileTypeFilter");
                userType.AddMemberName("ContinuationData");
                xamlType = userType;
                break;

            case 4:   //  Object
                xamlType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 5:   //  Windows.Storage.Pickers.PickerViewMode
                userType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
                userType.AddEnumValue("List", global::Windows.Storage.Pickers.PickerViewMode.List);
                userType.AddEnumValue("Thumbnail", global::Windows.Storage.Pickers.PickerViewMode.Thumbnail);
                xamlType = userType;
                break;

            case 6:   //  System.Enum
                userType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                xamlType = userType;
                break;

            case 7:   //  System.ValueType
                userType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 8:   //  Windows.Storage.Pickers.PickerLocationId
                userType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
                userType.AddEnumValue("DocumentsLibrary", global::Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary);
                userType.AddEnumValue("ComputerFolder", global::Windows.Storage.Pickers.PickerLocationId.ComputerFolder);
                userType.AddEnumValue("Desktop", global::Windows.Storage.Pickers.PickerLocationId.Desktop);
                userType.AddEnumValue("Downloads", global::Windows.Storage.Pickers.PickerLocationId.Downloads);
                userType.AddEnumValue("HomeGroup", global::Windows.Storage.Pickers.PickerLocationId.HomeGroup);
                userType.AddEnumValue("MusicLibrary", global::Windows.Storage.Pickers.PickerLocationId.MusicLibrary);
                userType.AddEnumValue("PicturesLibrary", global::Windows.Storage.Pickers.PickerLocationId.PicturesLibrary);
                userType.AddEnumValue("VideosLibrary", global::Windows.Storage.Pickers.PickerLocationId.VideosLibrary);
                userType.AddEnumValue("Objects3D", global::Windows.Storage.Pickers.PickerLocationId.Objects3D);
                userType.AddEnumValue("Unspecified", global::Windows.Storage.Pickers.PickerLocationId.Unspecified);
                xamlType = userType;
                break;

            case 9:   //  String
                xamlType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  System.Collections.Generic.IList`1<String>
                userType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType(this, typeName, type, null);
                userType.CollectionAdd = VectorAdd_10_IList;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 11:   //  Windows.Foundation.Collections.ValueSet
                userType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.DictionaryAdd = MapAdd_11_ValueSet;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 12:   //  PnP_Character_Nexus.Views.Start
                userType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_Start;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  PnP_Character_Nexus.Views.WelcomeScreen
                userType = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_WelcomeScreen;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_FolderPicker_ViewMode(object instance)
        {
            var that = (global::Windows.Storage.Pickers.FolderPicker)instance;
            return that.ViewMode;
        }
        private void set_0_FolderPicker_ViewMode(object instance, object Value)
        {
            var that = (global::Windows.Storage.Pickers.FolderPicker)instance;
            that.ViewMode = (global::Windows.Storage.Pickers.PickerViewMode)Value;
        }
        private object get_1_FolderPicker_SuggestedStartLocation(object instance)
        {
            var that = (global::Windows.Storage.Pickers.FolderPicker)instance;
            return that.SuggestedStartLocation;
        }
        private void set_1_FolderPicker_SuggestedStartLocation(object instance, object Value)
        {
            var that = (global::Windows.Storage.Pickers.FolderPicker)instance;
            that.SuggestedStartLocation = (global::Windows.Storage.Pickers.PickerLocationId)Value;
        }
        private object get_2_FolderPicker_SettingsIdentifier(object instance)
        {
            var that = (global::Windows.Storage.Pickers.FolderPicker)instance;
            return that.SettingsIdentifier;
        }
        private void set_2_FolderPicker_SettingsIdentifier(object instance, object Value)
        {
            var that = (global::Windows.Storage.Pickers.FolderPicker)instance;
            that.SettingsIdentifier = (global::System.String)Value;
        }
        private object get_3_FolderPicker_CommitButtonText(object instance)
        {
            var that = (global::Windows.Storage.Pickers.FolderPicker)instance;
            return that.CommitButtonText;
        }
        private void set_3_FolderPicker_CommitButtonText(object instance, object Value)
        {
            var that = (global::Windows.Storage.Pickers.FolderPicker)instance;
            that.CommitButtonText = (global::System.String)Value;
        }
        private object get_4_FolderPicker_FileTypeFilter(object instance)
        {
            var that = (global::Windows.Storage.Pickers.FolderPicker)instance;
            return that.FileTypeFilter;
        }
        private object get_5_FolderPicker_ContinuationData(object instance)
        {
            var that = (global::Windows.Storage.Pickers.FolderPicker)instance;
            return that.ContinuationData;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlMember xamlMember = null;
            global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Windows.Storage.Pickers.FolderPicker.ViewMode":
                userType = (global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.Storage.Pickers.FolderPicker");
                xamlMember = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlMember(this, "ViewMode", "Windows.Storage.Pickers.PickerViewMode");
                xamlMember.Getter = get_0_FolderPicker_ViewMode;
                xamlMember.Setter = set_0_FolderPicker_ViewMode;
                break;
            case "Windows.Storage.Pickers.FolderPicker.SuggestedStartLocation":
                userType = (global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.Storage.Pickers.FolderPicker");
                xamlMember = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlMember(this, "SuggestedStartLocation", "Windows.Storage.Pickers.PickerLocationId");
                xamlMember.Getter = get_1_FolderPicker_SuggestedStartLocation;
                xamlMember.Setter = set_1_FolderPicker_SuggestedStartLocation;
                break;
            case "Windows.Storage.Pickers.FolderPicker.SettingsIdentifier":
                userType = (global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.Storage.Pickers.FolderPicker");
                xamlMember = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlMember(this, "SettingsIdentifier", "String");
                xamlMember.Getter = get_2_FolderPicker_SettingsIdentifier;
                xamlMember.Setter = set_2_FolderPicker_SettingsIdentifier;
                break;
            case "Windows.Storage.Pickers.FolderPicker.CommitButtonText":
                userType = (global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.Storage.Pickers.FolderPicker");
                xamlMember = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlMember(this, "CommitButtonText", "String");
                xamlMember.Getter = get_3_FolderPicker_CommitButtonText;
                xamlMember.Setter = set_3_FolderPicker_CommitButtonText;
                break;
            case "Windows.Storage.Pickers.FolderPicker.FileTypeFilter":
                userType = (global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.Storage.Pickers.FolderPicker");
                xamlMember = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlMember(this, "FileTypeFilter", "System.Collections.Generic.IList`1<String>");
                xamlMember.Getter = get_4_FolderPicker_FileTypeFilter;
                xamlMember.SetIsReadOnly();
                break;
            case "Windows.Storage.Pickers.FolderPicker.ContinuationData":
                userType = (global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.Storage.Pickers.FolderPicker");
                xamlMember = new global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlMember(this, "ContinuationData", "Windows.Foundation.Collections.ValueSet");
                xamlMember.Getter = get_5_FolderPicker_ContinuationData;
                xamlMember.SetIsReadOnly();
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlSystemBaseType
    {
        global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::PnP_Character_Nexus.PnP_Character_Nexus_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}
