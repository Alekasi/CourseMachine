﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace courseMachineUi.parameterReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="parameterClass", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.parameter")]
    [System.SerializableAttribute()]
    public partial class parameterClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string additional_1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string additional_2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string additional_3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string additional_4Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid childIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid creatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string orderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid parameterIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
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
        public string additional_1 {
            get {
                return this.additional_1Field;
            }
            set {
                if ((object.ReferenceEquals(this.additional_1Field, value) != true)) {
                    this.additional_1Field = value;
                    this.RaisePropertyChanged("additional_1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string additional_2 {
            get {
                return this.additional_2Field;
            }
            set {
                if ((object.ReferenceEquals(this.additional_2Field, value) != true)) {
                    this.additional_2Field = value;
                    this.RaisePropertyChanged("additional_2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string additional_3 {
            get {
                return this.additional_3Field;
            }
            set {
                if ((object.ReferenceEquals(this.additional_3Field, value) != true)) {
                    this.additional_3Field = value;
                    this.RaisePropertyChanged("additional_3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string additional_4 {
            get {
                return this.additional_4Field;
            }
            set {
                if ((object.ReferenceEquals(this.additional_4Field, value) != true)) {
                    this.additional_4Field = value;
                    this.RaisePropertyChanged("additional_4");
                }
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
        public string order {
            get {
                return this.orderField;
            }
            set {
                if ((object.ReferenceEquals(this.orderField, value) != true)) {
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
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="parametercreate", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.parameter")]
    [System.SerializableAttribute()]
    public partial class parametercreate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid childIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid creatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string typeField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="parameterDelete", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.parameter")]
    [System.SerializableAttribute()]
    public partial class parameterDelete : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid creatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid parameterIdField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="parameterDeleteAll", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.parameter")]
    [System.SerializableAttribute()]
    public partial class parameterDeleteAll : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid childIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid creatorField;
        
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="parameterReference.Iparameter")]
    public interface Iparameter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/readString", ReplyAction="http://tempuri.org/Iparameter/readStringResponse")]
        courseMachineUi.parameterReference.parameterClass[] readString(string childId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/readString", ReplyAction="http://tempuri.org/Iparameter/readStringResponse")]
        System.Threading.Tasks.Task<courseMachineUi.parameterReference.parameterClass[]> readStringAsync(string childId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/read", ReplyAction="http://tempuri.org/Iparameter/readResponse")]
        courseMachineUi.parameterReference.parameterClass[] read(System.Guid childId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/read", ReplyAction="http://tempuri.org/Iparameter/readResponse")]
        System.Threading.Tasks.Task<courseMachineUi.parameterReference.parameterClass[]> readAsync(System.Guid childId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/createString", ReplyAction="http://tempuri.org/Iparameter/createStringResponse")]
        string createString(string type, string childId, string creator);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/createString", ReplyAction="http://tempuri.org/Iparameter/createStringResponse")]
        System.Threading.Tasks.Task<string> createStringAsync(string type, string childId, string creator);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/create", ReplyAction="http://tempuri.org/Iparameter/createResponse")]
        string create(courseMachineUi.parameterReference.parametercreate use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/create", ReplyAction="http://tempuri.org/Iparameter/createResponse")]
        System.Threading.Tasks.Task<string> createAsync(courseMachineUi.parameterReference.parametercreate use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/updateString", ReplyAction="http://tempuri.org/Iparameter/updateStringResponse")]
        string updateString(string childId, string parameterId, string creator, string type, string value, string order, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/updateString", ReplyAction="http://tempuri.org/Iparameter/updateStringResponse")]
        System.Threading.Tasks.Task<string> updateStringAsync(string childId, string parameterId, string creator, string type, string value, string order, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/update", ReplyAction="http://tempuri.org/Iparameter/updateResponse")]
        string update(courseMachineUi.parameterReference.parameterClass[] use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/update", ReplyAction="http://tempuri.org/Iparameter/updateResponse")]
        System.Threading.Tasks.Task<string> updateAsync(courseMachineUi.parameterReference.parameterClass[] use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/deleteString", ReplyAction="http://tempuri.org/Iparameter/deleteStringResponse")]
        string deleteString(string creator, string parameterId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/deleteString", ReplyAction="http://tempuri.org/Iparameter/deleteStringResponse")]
        System.Threading.Tasks.Task<string> deleteStringAsync(string creator, string parameterId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/delete", ReplyAction="http://tempuri.org/Iparameter/deleteResponse")]
        string delete(courseMachineUi.parameterReference.parameterDelete use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/delete", ReplyAction="http://tempuri.org/Iparameter/deleteResponse")]
        System.Threading.Tasks.Task<string> deleteAsync(courseMachineUi.parameterReference.parameterDelete use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/deleteAllString", ReplyAction="http://tempuri.org/Iparameter/deleteAllStringResponse")]
        string deleteAllString(string creator, string childId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/deleteAllString", ReplyAction="http://tempuri.org/Iparameter/deleteAllStringResponse")]
        System.Threading.Tasks.Task<string> deleteAllStringAsync(string creator, string childId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/deleteAll", ReplyAction="http://tempuri.org/Iparameter/deleteAllResponse")]
        string deleteAll(courseMachineUi.parameterReference.parameterDeleteAll use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iparameter/deleteAll", ReplyAction="http://tempuri.org/Iparameter/deleteAllResponse")]
        System.Threading.Tasks.Task<string> deleteAllAsync(courseMachineUi.parameterReference.parameterDeleteAll use);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IparameterChannel : courseMachineUi.parameterReference.Iparameter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IparameterClient : System.ServiceModel.ClientBase<courseMachineUi.parameterReference.Iparameter>, courseMachineUi.parameterReference.Iparameter {
        
        public IparameterClient() {
        }
        
        public IparameterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IparameterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IparameterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IparameterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public courseMachineUi.parameterReference.parameterClass[] readString(string childId) {
            return base.Channel.readString(childId);
        }
        
        public System.Threading.Tasks.Task<courseMachineUi.parameterReference.parameterClass[]> readStringAsync(string childId) {
            return base.Channel.readStringAsync(childId);
        }
        
        public courseMachineUi.parameterReference.parameterClass[] read(System.Guid childId) {
            return base.Channel.read(childId);
        }
        
        public System.Threading.Tasks.Task<courseMachineUi.parameterReference.parameterClass[]> readAsync(System.Guid childId) {
            return base.Channel.readAsync(childId);
        }
        
        public string createString(string type, string childId, string creator) {
            return base.Channel.createString(type, childId, creator);
        }
        
        public System.Threading.Tasks.Task<string> createStringAsync(string type, string childId, string creator) {
            return base.Channel.createStringAsync(type, childId, creator);
        }
        
        public string create(courseMachineUi.parameterReference.parametercreate use) {
            return base.Channel.create(use);
        }
        
        public System.Threading.Tasks.Task<string> createAsync(courseMachineUi.parameterReference.parametercreate use) {
            return base.Channel.createAsync(use);
        }
        
        public string updateString(string childId, string parameterId, string creator, string type, string value, string order, string status) {
            return base.Channel.updateString(childId, parameterId, creator, type, value, order, status);
        }
        
        public System.Threading.Tasks.Task<string> updateStringAsync(string childId, string parameterId, string creator, string type, string value, string order, string status) {
            return base.Channel.updateStringAsync(childId, parameterId, creator, type, value, order, status);
        }
        
        public string update(courseMachineUi.parameterReference.parameterClass[] use) {
            return base.Channel.update(use);
        }
        
        public System.Threading.Tasks.Task<string> updateAsync(courseMachineUi.parameterReference.parameterClass[] use) {
            return base.Channel.updateAsync(use);
        }
        
        public string deleteString(string creator, string parameterId) {
            return base.Channel.deleteString(creator, parameterId);
        }
        
        public System.Threading.Tasks.Task<string> deleteStringAsync(string creator, string parameterId) {
            return base.Channel.deleteStringAsync(creator, parameterId);
        }
        
        public string delete(courseMachineUi.parameterReference.parameterDelete use) {
            return base.Channel.delete(use);
        }
        
        public System.Threading.Tasks.Task<string> deleteAsync(courseMachineUi.parameterReference.parameterDelete use) {
            return base.Channel.deleteAsync(use);
        }
        
        public string deleteAllString(string creator, string childId) {
            return base.Channel.deleteAllString(creator, childId);
        }
        
        public System.Threading.Tasks.Task<string> deleteAllStringAsync(string creator, string childId) {
            return base.Channel.deleteAllStringAsync(creator, childId);
        }
        
        public string deleteAll(courseMachineUi.parameterReference.parameterDeleteAll use) {
            return base.Channel.deleteAll(use);
        }
        
        public System.Threading.Tasks.Task<string> deleteAllAsync(courseMachineUi.parameterReference.parameterDeleteAll use) {
            return base.Channel.deleteAllAsync(use);
        }
    }
}
