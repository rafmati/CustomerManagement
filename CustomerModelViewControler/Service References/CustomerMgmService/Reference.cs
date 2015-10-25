﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerModelViewControler.CustomerMgmService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerData", Namespace="http://schemas.datacontract.org/2004/07/CustomerMgmService.Contracts.Messages")]
    [System.SerializableAttribute()]
    public partial class CustomerData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PersonalNumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TotalDebtField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Note {
            get {
                return this.NoteField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteField, value) != true)) {
                    this.NoteField = value;
                    this.RaisePropertyChanged("Note");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PersonalNum {
            get {
                return this.PersonalNumField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalNumField, value) != true)) {
                    this.PersonalNumField = value;
                    this.RaisePropertyChanged("PersonalNum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TotalDebt {
            get {
                return this.TotalDebtField;
            }
            set {
                if ((this.TotalDebtField.Equals(value) != true)) {
                    this.TotalDebtField = value;
                    this.RaisePropertyChanged("TotalDebt");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerMgmService.ICustomerMgmService")]
    public interface ICustomerMgmService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerMgmService/Add", ReplyAction="http://tempuri.org/ICustomerMgmService/AddResponse")]
        bool Add(CustomerModelViewControler.CustomerMgmService.CustomerData data_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerMgmService/Add", ReplyAction="http://tempuri.org/ICustomerMgmService/AddResponse")]
        System.Threading.Tasks.Task<bool> AddAsync(CustomerModelViewControler.CustomerMgmService.CustomerData data_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerMgmService/Update", ReplyAction="http://tempuri.org/ICustomerMgmService/UpdateResponse")]
        bool Update(CustomerModelViewControler.CustomerMgmService.CustomerData data_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerMgmService/Update", ReplyAction="http://tempuri.org/ICustomerMgmService/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(CustomerModelViewControler.CustomerMgmService.CustomerData data_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerMgmService/UserLogin", ReplyAction="http://tempuri.org/ICustomerMgmService/UserLoginResponse")]
        bool UserLogin(string userName_, string userPassword_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerMgmService/UserLogin", ReplyAction="http://tempuri.org/ICustomerMgmService/UserLoginResponse")]
        System.Threading.Tasks.Task<bool> UserLoginAsync(string userName_, string userPassword_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerMgmService/GetCustomers", ReplyAction="http://tempuri.org/ICustomerMgmService/GetCustomersResponse")]
        CustomerModelViewControler.CustomerMgmService.CustomerData[] GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerMgmService/GetCustomers", ReplyAction="http://tempuri.org/ICustomerMgmService/GetCustomersResponse")]
        System.Threading.Tasks.Task<CustomerModelViewControler.CustomerMgmService.CustomerData[]> GetCustomersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerMgmServiceChannel : CustomerModelViewControler.CustomerMgmService.ICustomerMgmService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerMgmServiceClient : System.ServiceModel.ClientBase<CustomerModelViewControler.CustomerMgmService.ICustomerMgmService>, CustomerModelViewControler.CustomerMgmService.ICustomerMgmService {
        
        public CustomerMgmServiceClient() {
        }
        
        public CustomerMgmServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerMgmServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerMgmServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerMgmServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Add(CustomerModelViewControler.CustomerMgmService.CustomerData data_) {
            return base.Channel.Add(data_);
        }
        
        public System.Threading.Tasks.Task<bool> AddAsync(CustomerModelViewControler.CustomerMgmService.CustomerData data_) {
            return base.Channel.AddAsync(data_);
        }
        
        public bool Update(CustomerModelViewControler.CustomerMgmService.CustomerData data_) {
            return base.Channel.Update(data_);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(CustomerModelViewControler.CustomerMgmService.CustomerData data_) {
            return base.Channel.UpdateAsync(data_);
        }
        
        public bool UserLogin(string userName_, string userPassword_) {
            return base.Channel.UserLogin(userName_, userPassword_);
        }
        
        public System.Threading.Tasks.Task<bool> UserLoginAsync(string userName_, string userPassword_) {
            return base.Channel.UserLoginAsync(userName_, userPassword_);
        }
        
        public CustomerModelViewControler.CustomerMgmService.CustomerData[] GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<CustomerModelViewControler.CustomerMgmService.CustomerData[]> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
    }
}