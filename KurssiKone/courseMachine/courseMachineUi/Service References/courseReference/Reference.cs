﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace courseMachineUi.courseReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="create", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.course")]
    [System.SerializableAttribute()]
    public partial class create : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="courseClass", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.course")]
    [System.SerializableAttribute()]
    public partial class courseClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid companyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid courseIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime createdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid creatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string currencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int durationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string durationUnitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string informationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
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
        public System.Guid company {
            get {
                return this.companyField;
            }
            set {
                if ((this.companyField.Equals(value) != true)) {
                    this.companyField = value;
                    this.RaisePropertyChanged("company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid courseId {
            get {
                return this.courseIdField;
            }
            set {
                if ((this.courseIdField.Equals(value) != true)) {
                    this.courseIdField = value;
                    this.RaisePropertyChanged("courseId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime created {
            get {
                return this.createdField;
            }
            set {
                if ((this.createdField.Equals(value) != true)) {
                    this.createdField = value;
                    this.RaisePropertyChanged("created");
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
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                if ((object.ReferenceEquals(this.currencyField, value) != true)) {
                    this.currencyField = value;
                    this.RaisePropertyChanged("currency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int duration {
            get {
                return this.durationField;
            }
            set {
                if ((this.durationField.Equals(value) != true)) {
                    this.durationField = value;
                    this.RaisePropertyChanged("duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string durationUnit {
            get {
                return this.durationUnitField;
            }
            set {
                if ((object.ReferenceEquals(this.durationUnitField, value) != true)) {
                    this.durationUnitField = value;
                    this.RaisePropertyChanged("durationUnit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string img {
            get {
                return this.imgField;
            }
            set {
                if ((object.ReferenceEquals(this.imgField, value) != true)) {
                    this.imgField = value;
                    this.RaisePropertyChanged("img");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string information {
            get {
                return this.informationField;
            }
            set {
                if ((object.ReferenceEquals(this.informationField, value) != true)) {
                    this.informationField = value;
                    this.RaisePropertyChanged("information");
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
        public int price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="courseUpdate", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.course")]
    [System.SerializableAttribute()]
    public partial class courseUpdate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string currencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int durationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string durationUnitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string informationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
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
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                if ((object.ReferenceEquals(this.currencyField, value) != true)) {
                    this.currencyField = value;
                    this.RaisePropertyChanged("currency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int duration {
            get {
                return this.durationField;
            }
            set {
                if ((this.durationField.Equals(value) != true)) {
                    this.durationField = value;
                    this.RaisePropertyChanged("duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string durationUnit {
            get {
                return this.durationUnitField;
            }
            set {
                if ((object.ReferenceEquals(this.durationUnitField, value) != true)) {
                    this.durationUnitField = value;
                    this.RaisePropertyChanged("durationUnit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string information {
            get {
                return this.informationField;
            }
            set {
                if ((object.ReferenceEquals(this.informationField, value) != true)) {
                    this.informationField = value;
                    this.RaisePropertyChanged("information");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="courseDelete", Namespace="http://schemas.datacontract.org/2004/07/courseBackGround.course")]
    [System.SerializableAttribute()]
    public partial class courseDelete : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid courseIdField;
        
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
        public System.Guid courseId {
            get {
                return this.courseIdField;
            }
            set {
                if ((this.courseIdField.Equals(value) != true)) {
                    this.courseIdField = value;
                    this.RaisePropertyChanged("courseId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="courseReference.Icourse")]
    public interface Icourse {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/checkCourse", ReplyAction="http://tempuri.org/Icourse/checkCourseResponse")]
        int checkCourse(string course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/checkCourse", ReplyAction="http://tempuri.org/Icourse/checkCourseResponse")]
        System.Threading.Tasks.Task<int> checkCourseAsync(string course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/imgToByte", ReplyAction="http://tempuri.org/Icourse/imgToByteResponse")]
        byte[] imgToByte(System.Drawing.Image img);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/imgToByte", ReplyAction="http://tempuri.org/Icourse/imgToByteResponse")]
        System.Threading.Tasks.Task<byte[]> imgToByteAsync(System.Drawing.Image img);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/createCourseString", ReplyAction="http://tempuri.org/Icourse/createCourseStringResponse")]
        string createCourseString(string name, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/createCourseString", ReplyAction="http://tempuri.org/Icourse/createCourseStringResponse")]
        System.Threading.Tasks.Task<string> createCourseStringAsync(string name, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/createCourse", ReplyAction="http://tempuri.org/Icourse/createCourseResponse")]
        string createCourse(courseMachineUi.courseReference.create use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/createCourse", ReplyAction="http://tempuri.org/Icourse/createCourseResponse")]
        System.Threading.Tasks.Task<string> createCourseAsync(courseMachineUi.courseReference.create use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/courseInfo", ReplyAction="http://tempuri.org/Icourse/courseInfoResponse")]
        courseMachineUi.courseReference.courseClass courseInfo(string course, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/courseInfo", ReplyAction="http://tempuri.org/Icourse/courseInfoResponse")]
        System.Threading.Tasks.Task<courseMachineUi.courseReference.courseClass> courseInfoAsync(string course, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/fetchCourses", ReplyAction="http://tempuri.org/Icourse/fetchCoursesResponse")]
        courseMachineUi.courseReference.courseClass[] fetchCourses(int fetch, int jump);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/fetchCourses", ReplyAction="http://tempuri.org/Icourse/fetchCoursesResponse")]
        System.Threading.Tasks.Task<courseMachineUi.courseReference.courseClass[]> fetchCoursesAsync(int fetch, int jump);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/updateString", ReplyAction="http://tempuri.org/Icourse/updateStringResponse")]
        string updateString(string id, courseMachineUi.courseReference.courseUpdate course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/updateString", ReplyAction="http://tempuri.org/Icourse/updateStringResponse")]
        System.Threading.Tasks.Task<string> updateStringAsync(string id, courseMachineUi.courseReference.courseUpdate course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/update", ReplyAction="http://tempuri.org/Icourse/updateResponse")]
        string update(System.Guid id, courseMachineUi.courseReference.courseUpdate course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/update", ReplyAction="http://tempuri.org/Icourse/updateResponse")]
        System.Threading.Tasks.Task<string> updateAsync(System.Guid id, courseMachineUi.courseReference.courseUpdate course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/deleteString", ReplyAction="http://tempuri.org/Icourse/deleteStringResponse")]
        string deleteString(string courseId, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/deleteString", ReplyAction="http://tempuri.org/Icourse/deleteStringResponse")]
        System.Threading.Tasks.Task<string> deleteStringAsync(string courseId, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/delete", ReplyAction="http://tempuri.org/Icourse/deleteResponse")]
        string delete(courseMachineUi.courseReference.courseDelete use);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Icourse/delete", ReplyAction="http://tempuri.org/Icourse/deleteResponse")]
        System.Threading.Tasks.Task<string> deleteAsync(courseMachineUi.courseReference.courseDelete use);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IcourseChannel : courseMachineUi.courseReference.Icourse, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IcourseClient : System.ServiceModel.ClientBase<courseMachineUi.courseReference.Icourse>, courseMachineUi.courseReference.Icourse {
        
        public IcourseClient() {
        }
        
        public IcourseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IcourseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IcourseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IcourseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int checkCourse(string course) {
            return base.Channel.checkCourse(course);
        }
        
        public System.Threading.Tasks.Task<int> checkCourseAsync(string course) {
            return base.Channel.checkCourseAsync(course);
        }
        
        public byte[] imgToByte(System.Drawing.Image img) {
            return base.Channel.imgToByte(img);
        }
        
        public System.Threading.Tasks.Task<byte[]> imgToByteAsync(System.Drawing.Image img) {
            return base.Channel.imgToByteAsync(img);
        }
        
        public string createCourseString(string name, string user) {
            return base.Channel.createCourseString(name, user);
        }
        
        public System.Threading.Tasks.Task<string> createCourseStringAsync(string name, string user) {
            return base.Channel.createCourseStringAsync(name, user);
        }
        
        public string createCourse(courseMachineUi.courseReference.create use) {
            return base.Channel.createCourse(use);
        }
        
        public System.Threading.Tasks.Task<string> createCourseAsync(courseMachineUi.courseReference.create use) {
            return base.Channel.createCourseAsync(use);
        }
        
        public courseMachineUi.courseReference.courseClass courseInfo(string course, string user) {
            return base.Channel.courseInfo(course, user);
        }
        
        public System.Threading.Tasks.Task<courseMachineUi.courseReference.courseClass> courseInfoAsync(string course, string user) {
            return base.Channel.courseInfoAsync(course, user);
        }
        
        public courseMachineUi.courseReference.courseClass[] fetchCourses(int fetch, int jump) {
            return base.Channel.fetchCourses(fetch, jump);
        }
        
        public System.Threading.Tasks.Task<courseMachineUi.courseReference.courseClass[]> fetchCoursesAsync(int fetch, int jump) {
            return base.Channel.fetchCoursesAsync(fetch, jump);
        }
        
        public string updateString(string id, courseMachineUi.courseReference.courseUpdate course) {
            return base.Channel.updateString(id, course);
        }
        
        public System.Threading.Tasks.Task<string> updateStringAsync(string id, courseMachineUi.courseReference.courseUpdate course) {
            return base.Channel.updateStringAsync(id, course);
        }
        
        public string update(System.Guid id, courseMachineUi.courseReference.courseUpdate course) {
            return base.Channel.update(id, course);
        }
        
        public System.Threading.Tasks.Task<string> updateAsync(System.Guid id, courseMachineUi.courseReference.courseUpdate course) {
            return base.Channel.updateAsync(id, course);
        }
        
        public string deleteString(string courseId, string user) {
            return base.Channel.deleteString(courseId, user);
        }
        
        public System.Threading.Tasks.Task<string> deleteStringAsync(string courseId, string user) {
            return base.Channel.deleteStringAsync(courseId, user);
        }
        
        public string delete(courseMachineUi.courseReference.courseDelete use) {
            return base.Channel.delete(use);
        }
        
        public System.Threading.Tasks.Task<string> deleteAsync(courseMachineUi.courseReference.courseDelete use) {
            return base.Channel.deleteAsync(use);
        }
    }
}