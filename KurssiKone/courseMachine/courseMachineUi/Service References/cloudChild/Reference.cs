﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace courseMachineUi.cloudChild {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="childClass", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.child")]
    [System.SerializableAttribute()]
    public partial class childClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid childIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid creatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private courseMachineUi.cloudChild.parameterClass[] parameterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid parentIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid childId {
            get {
                return this.childIdField;
            }
            set {
                if ((this.childIdField.Equals(value) != true)) {
                    this.childIdField = value;
                    this.RaisePropertyChanged("childId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid creator {
            get {
                return this.creatorField;
            }
            set {
                if ((this.creatorField.Equals(value) != true)) {
                    this.creatorField = value;
                    this.RaisePropertyChanged("creator");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public courseMachineUi.cloudChild.parameterClass[] parameter {
            get {
                return this.parameterField;
            }
            set {
                if ((object.ReferenceEquals(this.parameterField, value) != true)) {
                    this.parameterField = value;
                    this.RaisePropertyChanged("parameter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid parentId {
            get {
                return this.parentIdField;
            }
            set {
                if ((this.parentIdField.Equals(value) != true)) {
                    this.parentIdField = value;
                    this.RaisePropertyChanged("parentId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="parameterClass", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.parameter")]
    [System.SerializableAttribute()]
    public partial class parameterClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid childIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid creatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int orderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid parameterIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string valueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid childId {
            get {
                return this.childIdField;
            }
            set {
                if ((this.childIdField.Equals(value) != true)) {
                    this.childIdField = value;
                    this.RaisePropertyChanged("childId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid creator {
            get {
                return this.creatorField;
            }
            set {
                if ((this.creatorField.Equals(value) != true)) {
                    this.creatorField = value;
                    this.RaisePropertyChanged("creator");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int order {
            get {
                return this.orderField;
            }
            set {
                if ((this.orderField.Equals(value) != true)) {
                    this.orderField = value;
                    this.RaisePropertyChanged("order");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid parameterId {
            get {
                return this.parameterIdField;
            }
            set {
                if ((this.parameterIdField.Equals(value) != true)) {
                    this.parameterIdField = value;
                    this.RaisePropertyChanged("parameterId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                if ((object.ReferenceEquals(this.typeField, value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string value {
            get {
                return this.valueField;
            }
            set {
                if ((object.ReferenceEquals(this.valueField, value) != true)) {
                    this.valueField = value;
                    this.RaisePropertyChanged("value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="childCreate", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.child")]
    [System.SerializableAttribute()]
    public partial class childCreate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid parentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid userIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid parentId {
            get {
                return this.parentIdField;
            }
            set {
                if ((this.parentIdField.Equals(value) != true)) {
                    this.parentIdField = value;
                    this.RaisePropertyChanged("parentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid userId {
            get {
                return this.userIdField;
            }
            set {
                if ((this.userIdField.Equals(value) != true)) {
                    this.userIdField = value;
                    this.RaisePropertyChanged("userId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="childUpdater", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.child")]
    [System.SerializableAttribute()]
    public partial class childUpdater : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid childIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid parentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid userIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid childId {
            get {
                return this.childIdField;
            }
            set {
                if ((this.childIdField.Equals(value) != true)) {
                    this.childIdField = value;
                    this.RaisePropertyChanged("childId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid parentId {
            get {
                return this.parentIdField;
            }
            set {
                if ((this.parentIdField.Equals(value) != true)) {
                    this.parentIdField = value;
                    this.RaisePropertyChanged("parentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid userId {
            get {
                return this.userIdField;
            }
            set {
                if ((this.userIdField.Equals(value) != true)) {
                    this.userIdField = value;
                    this.RaisePropertyChanged("userId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="childDelete", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.child")]
    [System.SerializableAttribute()]
    public partial class childDelete : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid childIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid userField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid childId {
            get {
                return this.childIdField;
            }
            set {
                if ((this.childIdField.Equals(value) != true)) {
                    this.childIdField = value;
                    this.RaisePropertyChanged("childId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid user {
            get {
                return this.userField;
            }
            set {
                if ((this.userField.Equals(value) != true)) {
                    this.userField = value;
                    this.RaisePropertyChanged("user");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="childDeleteAll", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.child")]
    [System.SerializableAttribute()]
    public partial class childDeleteAll : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid parentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid userField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid parentId {
            get {
                return this.parentIdField;
            }
            set {
                if ((this.parentIdField.Equals(value) != true)) {
                    this.parentIdField = value;
                    this.RaisePropertyChanged("parentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid user {
            get {
                return this.userField;
            }
            set {
                if ((this.userField.Equals(value) != true)) {
                    this.userField = value;
                    this.RaisePropertyChanged("user");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="cloudChild.Ichild")]
    public interface Ichild {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/readString", ReplyAction="http://tempuri.org/Ichild/readStringResponse")]
        courseMachineUi.cloudChild.childClass[] readString(string parent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/readString", ReplyAction="http://tempuri.org/Ichild/readStringResponse")]
        System.Threading.Tasks.Task<courseMachineUi.cloudChild.childClass[]> readStringAsync(string parent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/read", ReplyAction="http://tempuri.org/Ichild/readResponse")]
        courseMachineUi.cloudChild.childClass[] read(System.Guid parent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/read", ReplyAction="http://tempuri.org/Ichild/readResponse")]
        System.Threading.Tasks.Task<courseMachineUi.cloudChild.childClass[]> readAsync(System.Guid parent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/createString", ReplyAction="http://tempuri.org/Ichild/createStringResponse")]
        string createString(string parentId, string name, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/createString", ReplyAction="http://tempuri.org/Ichild/createStringResponse")]
        System.Threading.Tasks.Task<string> createStringAsync(string parentId, string name, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/create", ReplyAction="http://tempuri.org/Ichild/createResponse")]
        string create(courseMachineUi.cloudChild.childCreate user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/create", ReplyAction="http://tempuri.org/Ichild/createResponse")]
        System.Threading.Tasks.Task<string> createAsync(courseMachineUi.cloudChild.childCreate user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/updateString", ReplyAction="http://tempuri.org/Ichild/updateStringResponse")]
        string updateString(string childId, string name, string user, string parentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/updateString", ReplyAction="http://tempuri.org/Ichild/updateStringResponse")]
        System.Threading.Tasks.Task<string> updateStringAsync(string childId, string name, string user, string parentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/update", ReplyAction="http://tempuri.org/Ichild/updateResponse")]
        string update(courseMachineUi.cloudChild.childUpdater child);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/update", ReplyAction="http://tempuri.org/Ichild/updateResponse")]
        System.Threading.Tasks.Task<string> updateAsync(courseMachineUi.cloudChild.childUpdater child);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/deleteString", ReplyAction="http://tempuri.org/Ichild/deleteStringResponse")]
        string deleteString(string childId, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/deleteString", ReplyAction="http://tempuri.org/Ichild/deleteStringResponse")]
        System.Threading.Tasks.Task<string> deleteStringAsync(string childId, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/delete", ReplyAction="http://tempuri.org/Ichild/deleteResponse")]
        string delete(courseMachineUi.cloudChild.childDelete use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/delete", ReplyAction="http://tempuri.org/Ichild/deleteResponse")]
        System.Threading.Tasks.Task<string> deleteAsync(courseMachineUi.cloudChild.childDelete use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/deleteAllString", ReplyAction="http://tempuri.org/Ichild/deleteAllStringResponse")]
        string deleteAllString(string parentId, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/deleteAllString", ReplyAction="http://tempuri.org/Ichild/deleteAllStringResponse")]
        System.Threading.Tasks.Task<string> deleteAllStringAsync(string parentId, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/deleteAll", ReplyAction="http://tempuri.org/Ichild/deleteAllResponse")]
        string deleteAll(courseMachineUi.cloudChild.childDeleteAll use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ichild/deleteAll", ReplyAction="http://tempuri.org/Ichild/deleteAllResponse")]
        System.Threading.Tasks.Task<string> deleteAllAsync(courseMachineUi.cloudChild.childDeleteAll use);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IchildChannel : courseMachineUi.cloudChild.Ichild, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IchildClient : System.ServiceModel.ClientBase<courseMachineUi.cloudChild.Ichild>, courseMachineUi.cloudChild.Ichild {
        
        public IchildClient() {
        }
        
        public IchildClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IchildClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IchildClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IchildClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public courseMachineUi.cloudChild.childClass[] readString(string parent) {
            return base.Channel.readString(parent);
        }
        
        public System.Threading.Tasks.Task<courseMachineUi.cloudChild.childClass[]> readStringAsync(string parent) {
            return base.Channel.readStringAsync(parent);
        }
        
        public courseMachineUi.cloudChild.childClass[] read(System.Guid parent) {
            return base.Channel.read(parent);
        }
        
        public System.Threading.Tasks.Task<courseMachineUi.cloudChild.childClass[]> readAsync(System.Guid parent) {
            return base.Channel.readAsync(parent);
        }
        
        public string createString(string parentId, string name, string user) {
            return base.Channel.createString(parentId, name, user);
        }
        
        public System.Threading.Tasks.Task<string> createStringAsync(string parentId, string name, string user) {
            return base.Channel.createStringAsync(parentId, name, user);
        }
        
        public string create(courseMachineUi.cloudChild.childCreate user) {
            return base.Channel.create(user);
        }
        
        public System.Threading.Tasks.Task<string> createAsync(courseMachineUi.cloudChild.childCreate user) {
            return base.Channel.createAsync(user);
        }
        
        public string updateString(string childId, string name, string user, string parentId) {
            return base.Channel.updateString(childId, name, user, parentId);
        }
        
        public System.Threading.Tasks.Task<string> updateStringAsync(string childId, string name, string user, string parentId) {
            return base.Channel.updateStringAsync(childId, name, user, parentId);
        }
        
        public string update(courseMachineUi.cloudChild.childUpdater child) {
            return base.Channel.update(child);
        }
        
        public System.Threading.Tasks.Task<string> updateAsync(courseMachineUi.cloudChild.childUpdater child) {
            return base.Channel.updateAsync(child);
        }
        
        public string deleteString(string childId, string user) {
            return base.Channel.deleteString(childId, user);
        }
        
        public System.Threading.Tasks.Task<string> deleteStringAsync(string childId, string user) {
            return base.Channel.deleteStringAsync(childId, user);
        }
        
        public string delete(courseMachineUi.cloudChild.childDelete use) {
            return base.Channel.delete(use);
        }
        
        public System.Threading.Tasks.Task<string> deleteAsync(courseMachineUi.cloudChild.childDelete use) {
            return base.Channel.deleteAsync(use);
        }
        
        public string deleteAllString(string parentId, string user) {
            return base.Channel.deleteAllString(parentId, user);
        }
        
        public System.Threading.Tasks.Task<string> deleteAllStringAsync(string parentId, string user) {
            return base.Channel.deleteAllStringAsync(parentId, user);
        }
        
        public string deleteAll(courseMachineUi.cloudChild.childDeleteAll use) {
            return base.Channel.deleteAll(use);
        }
        
        public System.Threading.Tasks.Task<string> deleteAllAsync(courseMachineUi.cloudChild.childDeleteAll use) {
            return base.Channel.deleteAllAsync(use);
        }
    }
}
