﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AServiceSistemaSolar.wsSistemaSolar {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsSistemaSolar.IServiceSistemaSolar")]
    public interface IServiceSistemaSolar {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSistemaSolar/GetData", ReplyAction="http://tempuri.org/IServiceSistemaSolar/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSistemaSolar/GetData", ReplyAction="http://tempuri.org/IServiceSistemaSolar/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSistemaSolar/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceSistemaSolar/GetDataUsingDataContractResponse")]
        WsSistemaSolar.CompositeType GetDataUsingDataContract(WsSistemaSolar.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSistemaSolar/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceSistemaSolar/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WsSistemaSolar.CompositeType> GetDataUsingDataContractAsync(WsSistemaSolar.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSistemaSolarChannel : AServiceSistemaSolar.wsSistemaSolar.IServiceSistemaSolar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSistemaSolarClient : System.ServiceModel.ClientBase<AServiceSistemaSolar.wsSistemaSolar.IServiceSistemaSolar>, AServiceSistemaSolar.wsSistemaSolar.IServiceSistemaSolar {
        
        public ServiceSistemaSolarClient() {
        }
        
        public ServiceSistemaSolarClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSistemaSolarClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSistemaSolarClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSistemaSolarClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WsSistemaSolar.CompositeType GetDataUsingDataContract(WsSistemaSolar.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WsSistemaSolar.CompositeType> GetDataUsingDataContractAsync(WsSistemaSolar.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
