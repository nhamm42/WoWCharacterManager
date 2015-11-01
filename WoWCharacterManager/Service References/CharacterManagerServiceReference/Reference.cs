﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WoWCharacterManager.CharacterManagerServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CharacterManagerServiceReference.ICharacterManagerService")]
    public interface ICharacterManagerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterManagerService/GetData", ReplyAction="http://tempuri.org/ICharacterManagerService/GetDataResponse")]
        string GetData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterManagerService/GetData", ReplyAction="http://tempuri.org/ICharacterManagerService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterManagerService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICharacterManagerService/GetDataUsingDataContractResponse")]
        CharacterManagerService.CompositeType GetDataUsingDataContract(CharacterManagerService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterManagerService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICharacterManagerService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<CharacterManagerService.CompositeType> GetDataUsingDataContractAsync(CharacterManagerService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterManagerService/GetFactions", ReplyAction="http://tempuri.org/ICharacterManagerService/GetFactionsResponse")]
        CharacterManagerService.Models.Faction[] GetFactions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterManagerService/GetFactions", ReplyAction="http://tempuri.org/ICharacterManagerService/GetFactionsResponse")]
        System.Threading.Tasks.Task<CharacterManagerService.Models.Faction[]> GetFactionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterManagerService/GetRaces", ReplyAction="http://tempuri.org/ICharacterManagerService/GetRacesResponse")]
        CharacterManagerService.Models.Race[] GetRaces();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterManagerService/GetRaces", ReplyAction="http://tempuri.org/ICharacterManagerService/GetRacesResponse")]
        System.Threading.Tasks.Task<CharacterManagerService.Models.Race[]> GetRacesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterManagerService/GetClasses", ReplyAction="http://tempuri.org/ICharacterManagerService/GetClassesResponse")]
        CharacterManagerService.Models.Class[] GetClasses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterManagerService/GetClasses", ReplyAction="http://tempuri.org/ICharacterManagerService/GetClassesResponse")]
        System.Threading.Tasks.Task<CharacterManagerService.Models.Class[]> GetClassesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICharacterManagerServiceChannel : WoWCharacterManager.CharacterManagerServiceReference.ICharacterManagerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CharacterManagerServiceClient : System.ServiceModel.ClientBase<WoWCharacterManager.CharacterManagerServiceReference.ICharacterManagerService>, WoWCharacterManager.CharacterManagerServiceReference.ICharacterManagerService {
        
        public CharacterManagerServiceClient() {
        }
        
        public CharacterManagerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CharacterManagerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CharacterManagerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CharacterManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(string value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(string value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public CharacterManagerService.CompositeType GetDataUsingDataContract(CharacterManagerService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<CharacterManagerService.CompositeType> GetDataUsingDataContractAsync(CharacterManagerService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public CharacterManagerService.Models.Faction[] GetFactions() {
            return base.Channel.GetFactions();
        }
        
        public System.Threading.Tasks.Task<CharacterManagerService.Models.Faction[]> GetFactionsAsync() {
            return base.Channel.GetFactionsAsync();
        }
        
        public CharacterManagerService.Models.Race[] GetRaces() {
            return base.Channel.GetRaces();
        }
        
        public System.Threading.Tasks.Task<CharacterManagerService.Models.Race[]> GetRacesAsync() {
            return base.Channel.GetRacesAsync();
        }
        
        public CharacterManagerService.Models.Class[] GetClasses() {
            return base.Channel.GetClasses();
        }
        
        public System.Threading.Tasks.Task<CharacterManagerService.Models.Class[]> GetClassesAsync() {
            return base.Channel.GetClassesAsync();
        }
    }
}
