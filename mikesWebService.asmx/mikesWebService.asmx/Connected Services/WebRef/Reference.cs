﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mikesWebService.asmx.WebRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfInt", Namespace="http://tempuri.org/", ItemName="int")]
    [System.SerializableAttribute()]
    public class ArrayOfInt : System.Collections.Generic.List<int> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebRef.WebDev1ServiceSoap")]
    public interface WebDev1ServiceSoap {
        
        // CODEGEN: Generating message contract since element name BikesStudioServiceResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BikesStudioService", ReplyAction="*")]
        mikesWebService.asmx.WebRef.BikesStudioServiceResponse BikesStudioService(mikesWebService.asmx.WebRef.BikesStudioServiceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BikesStudioService", ReplyAction="*")]
        System.Threading.Tasks.Task<mikesWebService.asmx.WebRef.BikesStudioServiceResponse> BikesStudioServiceAsync(mikesWebService.asmx.WebRef.BikesStudioServiceRequest request);
        
        // CODEGEN: Generating message contract since element name numBikes from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DesiredAmountOfBikes", ReplyAction="*")]
        mikesWebService.asmx.WebRef.DesiredAmountOfBikesResponse DesiredAmountOfBikes(mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DesiredAmountOfBikes", ReplyAction="*")]
        System.Threading.Tasks.Task<mikesWebService.asmx.WebRef.DesiredAmountOfBikesResponse> DesiredAmountOfBikesAsync(mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BikesStudioServiceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BikesStudioService", Namespace="http://tempuri.org/", Order=0)]
        public mikesWebService.asmx.WebRef.BikesStudioServiceRequestBody Body;
        
        public BikesStudioServiceRequest() {
        }
        
        public BikesStudioServiceRequest(mikesWebService.asmx.WebRef.BikesStudioServiceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class BikesStudioServiceRequestBody {
        
        public BikesStudioServiceRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BikesStudioServiceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BikesStudioServiceResponse", Namespace="http://tempuri.org/", Order=0)]
        public mikesWebService.asmx.WebRef.BikesStudioServiceResponseBody Body;
        
        public BikesStudioServiceResponse() {
        }
        
        public BikesStudioServiceResponse(mikesWebService.asmx.WebRef.BikesStudioServiceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BikesStudioServiceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BikesStudioServiceResult;
        
        public BikesStudioServiceResponseBody() {
        }
        
        public BikesStudioServiceResponseBody(string BikesStudioServiceResult) {
            this.BikesStudioServiceResult = BikesStudioServiceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DesiredAmountOfBikesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DesiredAmountOfBikes", Namespace="http://tempuri.org/", Order=0)]
        public mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequestBody Body;
        
        public DesiredAmountOfBikesRequest() {
        }
        
        public DesiredAmountOfBikesRequest(mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DesiredAmountOfBikesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public mikesWebService.asmx.WebRef.ArrayOfInt numBikes;
        
        public DesiredAmountOfBikesRequestBody() {
        }
        
        public DesiredAmountOfBikesRequestBody(mikesWebService.asmx.WebRef.ArrayOfInt numBikes) {
            this.numBikes = numBikes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DesiredAmountOfBikesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DesiredAmountOfBikesResponse", Namespace="http://tempuri.org/", Order=0)]
        public mikesWebService.asmx.WebRef.DesiredAmountOfBikesResponseBody Body;
        
        public DesiredAmountOfBikesResponse() {
        }
        
        public DesiredAmountOfBikesResponse(mikesWebService.asmx.WebRef.DesiredAmountOfBikesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DesiredAmountOfBikesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int DesiredAmountOfBikesResult;
        
        public DesiredAmountOfBikesResponseBody() {
        }
        
        public DesiredAmountOfBikesResponseBody(int DesiredAmountOfBikesResult) {
            this.DesiredAmountOfBikesResult = DesiredAmountOfBikesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebDev1ServiceSoapChannel : mikesWebService.asmx.WebRef.WebDev1ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebDev1ServiceSoapClient : System.ServiceModel.ClientBase<mikesWebService.asmx.WebRef.WebDev1ServiceSoap>, mikesWebService.asmx.WebRef.WebDev1ServiceSoap {
        
        public WebDev1ServiceSoapClient() {
        }
        
        public WebDev1ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebDev1ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebDev1ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebDev1ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        mikesWebService.asmx.WebRef.BikesStudioServiceResponse mikesWebService.asmx.WebRef.WebDev1ServiceSoap.BikesStudioService(mikesWebService.asmx.WebRef.BikesStudioServiceRequest request) {
            return base.Channel.BikesStudioService(request);
        }
        
        public string BikesStudioService() {
            mikesWebService.asmx.WebRef.BikesStudioServiceRequest inValue = new mikesWebService.asmx.WebRef.BikesStudioServiceRequest();
            inValue.Body = new mikesWebService.asmx.WebRef.BikesStudioServiceRequestBody();
            mikesWebService.asmx.WebRef.BikesStudioServiceResponse retVal = ((mikesWebService.asmx.WebRef.WebDev1ServiceSoap)(this)).BikesStudioService(inValue);
            return retVal.Body.BikesStudioServiceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<mikesWebService.asmx.WebRef.BikesStudioServiceResponse> mikesWebService.asmx.WebRef.WebDev1ServiceSoap.BikesStudioServiceAsync(mikesWebService.asmx.WebRef.BikesStudioServiceRequest request) {
            return base.Channel.BikesStudioServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<mikesWebService.asmx.WebRef.BikesStudioServiceResponse> BikesStudioServiceAsync() {
            mikesWebService.asmx.WebRef.BikesStudioServiceRequest inValue = new mikesWebService.asmx.WebRef.BikesStudioServiceRequest();
            inValue.Body = new mikesWebService.asmx.WebRef.BikesStudioServiceRequestBody();
            return ((mikesWebService.asmx.WebRef.WebDev1ServiceSoap)(this)).BikesStudioServiceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        mikesWebService.asmx.WebRef.DesiredAmountOfBikesResponse mikesWebService.asmx.WebRef.WebDev1ServiceSoap.DesiredAmountOfBikes(mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequest request) {
            return base.Channel.DesiredAmountOfBikes(request);
        }
        
        public int DesiredAmountOfBikes(mikesWebService.asmx.WebRef.ArrayOfInt numBikes) {
            mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequest inValue = new mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequest();
            inValue.Body = new mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequestBody();
            inValue.Body.numBikes = numBikes;
            mikesWebService.asmx.WebRef.DesiredAmountOfBikesResponse retVal = ((mikesWebService.asmx.WebRef.WebDev1ServiceSoap)(this)).DesiredAmountOfBikes(inValue);
            return retVal.Body.DesiredAmountOfBikesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<mikesWebService.asmx.WebRef.DesiredAmountOfBikesResponse> mikesWebService.asmx.WebRef.WebDev1ServiceSoap.DesiredAmountOfBikesAsync(mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequest request) {
            return base.Channel.DesiredAmountOfBikesAsync(request);
        }
        
        public System.Threading.Tasks.Task<mikesWebService.asmx.WebRef.DesiredAmountOfBikesResponse> DesiredAmountOfBikesAsync(mikesWebService.asmx.WebRef.ArrayOfInt numBikes) {
            mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequest inValue = new mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequest();
            inValue.Body = new mikesWebService.asmx.WebRef.DesiredAmountOfBikesRequestBody();
            inValue.Body.numBikes = numBikes;
            return ((mikesWebService.asmx.WebRef.WebDev1ServiceSoap)(this)).DesiredAmountOfBikesAsync(inValue);
        }
    }
}
