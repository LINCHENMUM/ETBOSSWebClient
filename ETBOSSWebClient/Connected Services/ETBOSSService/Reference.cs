﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETBOSSWebClient.ETBOSSService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/ETBOSSService")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DobField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.DateTime Dob {
            get {
                return this.DobField;
            }
            set {
                if ((this.DobField.Equals(value) != true)) {
                    this.DobField = value;
                    this.RaisePropertyChanged("Dob");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ETBOSSService.IETBOSSService")]
    public interface IETBOSSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IETBOSSService/GetCustomerName", ReplyAction="http://tempuri.org/IETBOSSService/GetCustomerNameResponse")]
        string GetCustomerName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IETBOSSService/GetCustomerName", ReplyAction="http://tempuri.org/IETBOSSService/GetCustomerNameResponse")]
        System.Threading.Tasks.Task<string> GetCustomerNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IETBOSSService/GetEmployee", ReplyAction="http://tempuri.org/IETBOSSService/GetEmployeeResponse")]
        ETBOSSWebClient.ETBOSSService.Employee GetEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IETBOSSService/GetEmployee", ReplyAction="http://tempuri.org/IETBOSSService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<ETBOSSWebClient.ETBOSSService.Employee> GetEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IETBOSSService/SaveEmployee", ReplyAction="http://tempuri.org/IETBOSSService/SaveEmployeeResponse")]
        void SaveEmployee(ETBOSSWebClient.ETBOSSService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IETBOSSService/SaveEmployee", ReplyAction="http://tempuri.org/IETBOSSService/SaveEmployeeResponse")]
        System.Threading.Tasks.Task SaveEmployeeAsync(ETBOSSWebClient.ETBOSSService.Employee employee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IETBOSSServiceChannel : ETBOSSWebClient.ETBOSSService.IETBOSSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ETBOSSServiceClient : System.ServiceModel.ClientBase<ETBOSSWebClient.ETBOSSService.IETBOSSService>, ETBOSSWebClient.ETBOSSService.IETBOSSService {
        
        public ETBOSSServiceClient() {
        }
        
        public ETBOSSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ETBOSSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ETBOSSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ETBOSSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetCustomerName(string name) {
            return base.Channel.GetCustomerName(name);
        }
        
        public System.Threading.Tasks.Task<string> GetCustomerNameAsync(string name) {
            return base.Channel.GetCustomerNameAsync(name);
        }
        
        public ETBOSSWebClient.ETBOSSService.Employee GetEmployee(int id) {
            return base.Channel.GetEmployee(id);
        }
        
        public System.Threading.Tasks.Task<ETBOSSWebClient.ETBOSSService.Employee> GetEmployeeAsync(int id) {
            return base.Channel.GetEmployeeAsync(id);
        }
        
        public void SaveEmployee(ETBOSSWebClient.ETBOSSService.Employee employee) {
            base.Channel.SaveEmployee(employee);
        }
        
        public System.Threading.Tasks.Task SaveEmployeeAsync(ETBOSSWebClient.ETBOSSService.Employee employee) {
            return base.Channel.SaveEmployeeAsync(employee);
        }
    }
}
