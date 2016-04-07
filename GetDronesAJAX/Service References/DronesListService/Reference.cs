﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetDronesAJAX.DronesListService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DronesListService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetManufacturerList", ReplyAction="http://tempuri.org/IService1/GetManufacturerListResponse")]
        System.Text.StringBuilder GetManufacturerList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetManufacturerList", ReplyAction="http://tempuri.org/IService1/GetManufacturerListResponse")]
        System.Threading.Tasks.Task<System.Text.StringBuilder> GetManufacturerListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetModelSizeList", ReplyAction="http://tempuri.org/IService1/GetModelSizeListResponse")]
        System.Text.StringBuilder GetModelSizeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetModelSizeList", ReplyAction="http://tempuri.org/IService1/GetModelSizeListResponse")]
        System.Threading.Tasks.Task<System.Text.StringBuilder> GetModelSizeListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDrones", ReplyAction="http://tempuri.org/IService1/GetDronesResponse")]
        System.Text.StringBuilder GetDrones();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDrones", ReplyAction="http://tempuri.org/IService1/GetDronesResponse")]
        System.Threading.Tasks.Task<System.Text.StringBuilder> GetDronesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDroneById", ReplyAction="http://tempuri.org/IService1/GetDroneByIdResponse")]
        string GetDroneById(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDroneById", ReplyAction="http://tempuri.org/IService1/GetDroneByIdResponse")]
        System.Threading.Tasks.Task<string> GetDroneByIdAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDronesByManufacturerId", ReplyAction="http://tempuri.org/IService1/GetDronesByManufacturerIdResponse")]
        string GetDronesByManufacturerId(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDronesByManufacturerId", ReplyAction="http://tempuri.org/IService1/GetDronesByManufacturerIdResponse")]
        System.Threading.Tasks.Task<string> GetDronesByManufacturerIdAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDronesByModelSizeId", ReplyAction="http://tempuri.org/IService1/GetDronesByModelSizeIdResponse")]
        string GetDronesByModelSizeId(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDronesByModelSizeId", ReplyAction="http://tempuri.org/IService1/GetDronesByModelSizeIdResponse")]
        System.Threading.Tasks.Task<string> GetDronesByModelSizeIdAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : GetDronesAJAX.DronesListService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<GetDronesAJAX.DronesListService.IService1>, GetDronesAJAX.DronesListService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Text.StringBuilder GetManufacturerList() {
            return base.Channel.GetManufacturerList();
        }
        
        public System.Threading.Tasks.Task<System.Text.StringBuilder> GetManufacturerListAsync() {
            return base.Channel.GetManufacturerListAsync();
        }
        
        public System.Text.StringBuilder GetModelSizeList() {
            return base.Channel.GetModelSizeList();
        }
        
        public System.Threading.Tasks.Task<System.Text.StringBuilder> GetModelSizeListAsync() {
            return base.Channel.GetModelSizeListAsync();
        }
        
        public System.Text.StringBuilder GetDrones() {
            return base.Channel.GetDrones();
        }
        
        public System.Threading.Tasks.Task<System.Text.StringBuilder> GetDronesAsync() {
            return base.Channel.GetDronesAsync();
        }
        
        public string GetDroneById(string value) {
            return base.Channel.GetDroneById(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDroneByIdAsync(string value) {
            return base.Channel.GetDroneByIdAsync(value);
        }
        
        public string GetDronesByManufacturerId(string value) {
            return base.Channel.GetDronesByManufacturerId(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDronesByManufacturerIdAsync(string value) {
            return base.Channel.GetDronesByManufacturerIdAsync(value);
        }
        
        public string GetDronesByModelSizeId(string value) {
            return base.Channel.GetDronesByModelSizeId(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDronesByModelSizeIdAsync(string value) {
            return base.Channel.GetDronesByModelSizeIdAsync(value);
        }
    }
}
