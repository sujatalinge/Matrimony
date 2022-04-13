﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CARINSURE.WEB.CarInsuranceService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InsuranceProviders", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class InsuranceProviders : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HeadquarterField;
        
        private int RatingsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Headquarter {
            get {
                return this.HeadquarterField;
            }
            set {
                if ((object.ReferenceEquals(this.HeadquarterField, value) != true)) {
                    this.HeadquarterField = value;
                    this.RaisePropertyChanged("Headquarter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Ratings {
            get {
                return this.RatingsField;
            }
            set {
                if ((this.RatingsField.Equals(value) != true)) {
                    this.RatingsField = value;
                    this.RaisePropertyChanged("Ratings");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InsuranceProviderPolicies", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class InsuranceProviderPolicies : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PolicyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaturityField;
        
        private int PriceField;
        
        private int CompanyIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CARINSURE.WEB.CarInsuranceService.InsuranceProviders ProviderField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string PolicyName {
            get {
                return this.PolicyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PolicyNameField, value) != true)) {
                    this.PolicyNameField = value;
                    this.RaisePropertyChanged("PolicyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Maturity {
            get {
                return this.MaturityField;
            }
            set {
                if ((object.ReferenceEquals(this.MaturityField, value) != true)) {
                    this.MaturityField = value;
                    this.RaisePropertyChanged("Maturity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int CompanyId {
            get {
                return this.CompanyIdField;
            }
            set {
                if ((this.CompanyIdField.Equals(value) != true)) {
                    this.CompanyIdField = value;
                    this.RaisePropertyChanged("CompanyId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public CARINSURE.WEB.CarInsuranceService.InsuranceProviders Provider {
            get {
                return this.ProviderField;
            }
            set {
                if ((object.ReferenceEquals(this.ProviderField, value) != true)) {
                    this.ProviderField = value;
                    this.RaisePropertyChanged("Provider");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarInsuranceService.CarinsureSoap")]
    public interface CarinsureSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        CARINSURE.WEB.CarInsuranceService.HelloWorldResponse HelloWorld(CARINSURE.WEB.CarInsuranceService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<CARINSURE.WEB.CarInsuranceService.HelloWorldResponse> HelloWorldAsync(CARINSURE.WEB.CarInsuranceService.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name GetInsuranceProvidersResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInsuranceProviders", ReplyAction="*")]
        CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersResponse GetInsuranceProviders(CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInsuranceProviders", ReplyAction="*")]
        System.Threading.Tasks.Task<CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersResponse> GetInsuranceProvidersAsync(CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllPoliciesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllPolicies", ReplyAction="*")]
        CARINSURE.WEB.CarInsuranceService.GetAllPoliciesResponse GetAllPolicies(CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllPolicies", ReplyAction="*")]
        System.Threading.Tasks.Task<CARINSURE.WEB.CarInsuranceService.GetAllPoliciesResponse> GetAllPoliciesAsync(CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public CARINSURE.WEB.CarInsuranceService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(CARINSURE.WEB.CarInsuranceService.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public CARINSURE.WEB.CarInsuranceService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(CARINSURE.WEB.CarInsuranceService.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInsuranceProvidersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInsuranceProviders", Namespace="http://tempuri.org/", Order=0)]
        public CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequestBody Body;
        
        public GetInsuranceProvidersRequest() {
        }
        
        public GetInsuranceProvidersRequest(CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetInsuranceProvidersRequestBody {
        
        public GetInsuranceProvidersRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInsuranceProvidersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInsuranceProvidersResponse", Namespace="http://tempuri.org/", Order=0)]
        public CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersResponseBody Body;
        
        public GetInsuranceProvidersResponse() {
        }
        
        public GetInsuranceProvidersResponse(CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetInsuranceProvidersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CARINSURE.WEB.CarInsuranceService.InsuranceProviders[] GetInsuranceProvidersResult;
        
        public GetInsuranceProvidersResponseBody() {
        }
        
        public GetInsuranceProvidersResponseBody(CARINSURE.WEB.CarInsuranceService.InsuranceProviders[] GetInsuranceProvidersResult) {
            this.GetInsuranceProvidersResult = GetInsuranceProvidersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllPoliciesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllPolicies", Namespace="http://tempuri.org/", Order=0)]
        public CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequestBody Body;
        
        public GetAllPoliciesRequest() {
        }
        
        public GetAllPoliciesRequest(CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllPoliciesRequestBody {
        
        public GetAllPoliciesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllPoliciesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllPoliciesResponse", Namespace="http://tempuri.org/", Order=0)]
        public CARINSURE.WEB.CarInsuranceService.GetAllPoliciesResponseBody Body;
        
        public GetAllPoliciesResponse() {
        }
        
        public GetAllPoliciesResponse(CARINSURE.WEB.CarInsuranceService.GetAllPoliciesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllPoliciesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CARINSURE.WEB.CarInsuranceService.InsuranceProviderPolicies[] GetAllPoliciesResult;
        
        public GetAllPoliciesResponseBody() {
        }
        
        public GetAllPoliciesResponseBody(CARINSURE.WEB.CarInsuranceService.InsuranceProviderPolicies[] GetAllPoliciesResult) {
            this.GetAllPoliciesResult = GetAllPoliciesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CarinsureSoapChannel : CARINSURE.WEB.CarInsuranceService.CarinsureSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarinsureSoapClient : System.ServiceModel.ClientBase<CARINSURE.WEB.CarInsuranceService.CarinsureSoap>, CARINSURE.WEB.CarInsuranceService.CarinsureSoap {
        
        public CarinsureSoapClient() {
        }
        
        public CarinsureSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarinsureSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarinsureSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarinsureSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CARINSURE.WEB.CarInsuranceService.HelloWorldResponse CARINSURE.WEB.CarInsuranceService.CarinsureSoap.HelloWorld(CARINSURE.WEB.CarInsuranceService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            CARINSURE.WEB.CarInsuranceService.HelloWorldRequest inValue = new CARINSURE.WEB.CarInsuranceService.HelloWorldRequest();
            inValue.Body = new CARINSURE.WEB.CarInsuranceService.HelloWorldRequestBody();
            CARINSURE.WEB.CarInsuranceService.HelloWorldResponse retVal = ((CARINSURE.WEB.CarInsuranceService.CarinsureSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CARINSURE.WEB.CarInsuranceService.HelloWorldResponse> CARINSURE.WEB.CarInsuranceService.CarinsureSoap.HelloWorldAsync(CARINSURE.WEB.CarInsuranceService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<CARINSURE.WEB.CarInsuranceService.HelloWorldResponse> HelloWorldAsync() {
            CARINSURE.WEB.CarInsuranceService.HelloWorldRequest inValue = new CARINSURE.WEB.CarInsuranceService.HelloWorldRequest();
            inValue.Body = new CARINSURE.WEB.CarInsuranceService.HelloWorldRequestBody();
            return ((CARINSURE.WEB.CarInsuranceService.CarinsureSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersResponse CARINSURE.WEB.CarInsuranceService.CarinsureSoap.GetInsuranceProviders(CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequest request) {
            return base.Channel.GetInsuranceProviders(request);
        }
        
        public CARINSURE.WEB.CarInsuranceService.InsuranceProviders[] GetInsuranceProviders() {
            CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequest inValue = new CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequest();
            inValue.Body = new CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequestBody();
            CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersResponse retVal = ((CARINSURE.WEB.CarInsuranceService.CarinsureSoap)(this)).GetInsuranceProviders(inValue);
            return retVal.Body.GetInsuranceProvidersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersResponse> CARINSURE.WEB.CarInsuranceService.CarinsureSoap.GetInsuranceProvidersAsync(CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequest request) {
            return base.Channel.GetInsuranceProvidersAsync(request);
        }
        
        public System.Threading.Tasks.Task<CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersResponse> GetInsuranceProvidersAsync() {
            CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequest inValue = new CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequest();
            inValue.Body = new CARINSURE.WEB.CarInsuranceService.GetInsuranceProvidersRequestBody();
            return ((CARINSURE.WEB.CarInsuranceService.CarinsureSoap)(this)).GetInsuranceProvidersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CARINSURE.WEB.CarInsuranceService.GetAllPoliciesResponse CARINSURE.WEB.CarInsuranceService.CarinsureSoap.GetAllPolicies(CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequest request) {
            return base.Channel.GetAllPolicies(request);
        }
        
        public CARINSURE.WEB.CarInsuranceService.InsuranceProviderPolicies[] GetAllPolicies() {
            CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequest inValue = new CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequest();
            inValue.Body = new CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequestBody();
            CARINSURE.WEB.CarInsuranceService.GetAllPoliciesResponse retVal = ((CARINSURE.WEB.CarInsuranceService.CarinsureSoap)(this)).GetAllPolicies(inValue);
            return retVal.Body.GetAllPoliciesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CARINSURE.WEB.CarInsuranceService.GetAllPoliciesResponse> CARINSURE.WEB.CarInsuranceService.CarinsureSoap.GetAllPoliciesAsync(CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequest request) {
            return base.Channel.GetAllPoliciesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CARINSURE.WEB.CarInsuranceService.GetAllPoliciesResponse> GetAllPoliciesAsync() {
            CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequest inValue = new CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequest();
            inValue.Body = new CARINSURE.WEB.CarInsuranceService.GetAllPoliciesRequestBody();
            return ((CARINSURE.WEB.CarInsuranceService.CarinsureSoap)(this)).GetAllPoliciesAsync(inValue);
        }
    }
}