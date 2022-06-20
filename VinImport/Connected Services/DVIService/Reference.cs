﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VinImport.DVIService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://dvimonitor.pilotdrift.dk/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dvimonitor.pilotdrift.dk/", ConfigurationName="DVIService.monitorSoap")]
    public interface monitorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockTemp", ReplyAction="*")]
        double StockTemp();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<double> StockTempAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockHumidity", ReplyAction="*")]
        double StockHumidity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockHumidity", ReplyAction="*")]
        System.Threading.Tasks.Task<double> StockHumidityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/OutdoorTemp", ReplyAction="*")]
        double OutdoorTemp();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/OutdoorTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<double> OutdoorTempAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/OutdoorHumidity", ReplyAction="*")]
        double OutdoorHumidity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/OutdoorHumidity", ReplyAction="*")]
        System.Threading.Tasks.Task<double> OutdoorHumidityAsync();
        
        // CODEGEN: Generating message contract since element name StockItemsUnderMinResult from namespace http://dvimonitor.pilotdrift.dk/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsUnderMin", ReplyAction="*")]
        VinImport.DVIService.StockItemsUnderMinResponse StockItemsUnderMin(VinImport.DVIService.StockItemsUnderMinRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsUnderMin", ReplyAction="*")]
        System.Threading.Tasks.Task<VinImport.DVIService.StockItemsUnderMinResponse> StockItemsUnderMinAsync(VinImport.DVIService.StockItemsUnderMinRequest request);
        
        // CODEGEN: Generating message contract since element name StockItemsOverMaxResult from namespace http://dvimonitor.pilotdrift.dk/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsOverMax", ReplyAction="*")]
        VinImport.DVIService.StockItemsOverMaxResponse StockItemsOverMax(VinImport.DVIService.StockItemsOverMaxRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsOverMax", ReplyAction="*")]
        System.Threading.Tasks.Task<VinImport.DVIService.StockItemsOverMaxResponse> StockItemsOverMaxAsync(VinImport.DVIService.StockItemsOverMaxRequest request);
        
        // CODEGEN: Generating message contract since element name StockItemsMostSoldResult from namespace http://dvimonitor.pilotdrift.dk/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsMostSold", ReplyAction="*")]
        VinImport.DVIService.StockItemsMostSoldResponse StockItemsMostSold(VinImport.DVIService.StockItemsMostSoldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsMostSold", ReplyAction="*")]
        System.Threading.Tasks.Task<VinImport.DVIService.StockItemsMostSoldResponse> StockItemsMostSoldAsync(VinImport.DVIService.StockItemsMostSoldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsUnderMinRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsUnderMin", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public VinImport.DVIService.StockItemsUnderMinRequestBody Body;
        
        public StockItemsUnderMinRequest() {
        }
        
        public StockItemsUnderMinRequest(VinImport.DVIService.StockItemsUnderMinRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsUnderMinRequestBody {
        
        public StockItemsUnderMinRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsUnderMinResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsUnderMinResponse", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public VinImport.DVIService.StockItemsUnderMinResponseBody Body;
        
        public StockItemsUnderMinResponse() {
        }
        
        public StockItemsUnderMinResponse(VinImport.DVIService.StockItemsUnderMinResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.pilotdrift.dk/")]
    public partial class StockItemsUnderMinResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public VinImport.DVIService.ArrayOfString StockItemsUnderMinResult;
        
        public StockItemsUnderMinResponseBody() {
        }
        
        public StockItemsUnderMinResponseBody(VinImport.DVIService.ArrayOfString StockItemsUnderMinResult) {
            this.StockItemsUnderMinResult = StockItemsUnderMinResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsOverMaxRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsOverMax", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public VinImport.DVIService.StockItemsOverMaxRequestBody Body;
        
        public StockItemsOverMaxRequest() {
        }
        
        public StockItemsOverMaxRequest(VinImport.DVIService.StockItemsOverMaxRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsOverMaxRequestBody {
        
        public StockItemsOverMaxRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsOverMaxResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsOverMaxResponse", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public VinImport.DVIService.StockItemsOverMaxResponseBody Body;
        
        public StockItemsOverMaxResponse() {
        }
        
        public StockItemsOverMaxResponse(VinImport.DVIService.StockItemsOverMaxResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.pilotdrift.dk/")]
    public partial class StockItemsOverMaxResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public VinImport.DVIService.ArrayOfString StockItemsOverMaxResult;
        
        public StockItemsOverMaxResponseBody() {
        }
        
        public StockItemsOverMaxResponseBody(VinImport.DVIService.ArrayOfString StockItemsOverMaxResult) {
            this.StockItemsOverMaxResult = StockItemsOverMaxResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsMostSoldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsMostSold", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public VinImport.DVIService.StockItemsMostSoldRequestBody Body;
        
        public StockItemsMostSoldRequest() {
        }
        
        public StockItemsMostSoldRequest(VinImport.DVIService.StockItemsMostSoldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsMostSoldRequestBody {
        
        public StockItemsMostSoldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsMostSoldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsMostSoldResponse", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public VinImport.DVIService.StockItemsMostSoldResponseBody Body;
        
        public StockItemsMostSoldResponse() {
        }
        
        public StockItemsMostSoldResponse(VinImport.DVIService.StockItemsMostSoldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.pilotdrift.dk/")]
    public partial class StockItemsMostSoldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public VinImport.DVIService.ArrayOfString StockItemsMostSoldResult;
        
        public StockItemsMostSoldResponseBody() {
        }
        
        public StockItemsMostSoldResponseBody(VinImport.DVIService.ArrayOfString StockItemsMostSoldResult) {
            this.StockItemsMostSoldResult = StockItemsMostSoldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface monitorSoapChannel : VinImport.DVIService.monitorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class monitorSoapClient : System.ServiceModel.ClientBase<VinImport.DVIService.monitorSoap>, VinImport.DVIService.monitorSoap {
        
        public monitorSoapClient() {
        }
        
        public monitorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public monitorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public monitorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public monitorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double StockTemp() {
            return base.Channel.StockTemp();
        }
        
        public System.Threading.Tasks.Task<double> StockTempAsync() {
            return base.Channel.StockTempAsync();
        }
        
        public double StockHumidity() {
            return base.Channel.StockHumidity();
        }
        
        public System.Threading.Tasks.Task<double> StockHumidityAsync() {
            return base.Channel.StockHumidityAsync();
        }
        
        public double OutdoorTemp() {
            return base.Channel.OutdoorTemp();
        }
        
        public System.Threading.Tasks.Task<double> OutdoorTempAsync() {
            return base.Channel.OutdoorTempAsync();
        }
        
        public double OutdoorHumidity() {
            return base.Channel.OutdoorHumidity();
        }
        
        public System.Threading.Tasks.Task<double> OutdoorHumidityAsync() {
            return base.Channel.OutdoorHumidityAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VinImport.DVIService.StockItemsUnderMinResponse VinImport.DVIService.monitorSoap.StockItemsUnderMin(VinImport.DVIService.StockItemsUnderMinRequest request) {
            return base.Channel.StockItemsUnderMin(request);
        }
        
        public VinImport.DVIService.ArrayOfString StockItemsUnderMin() {
            VinImport.DVIService.StockItemsUnderMinRequest inValue = new VinImport.DVIService.StockItemsUnderMinRequest();
            inValue.Body = new VinImport.DVIService.StockItemsUnderMinRequestBody();
            VinImport.DVIService.StockItemsUnderMinResponse retVal = ((VinImport.DVIService.monitorSoap)(this)).StockItemsUnderMin(inValue);
            return retVal.Body.StockItemsUnderMinResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VinImport.DVIService.StockItemsUnderMinResponse> VinImport.DVIService.monitorSoap.StockItemsUnderMinAsync(VinImport.DVIService.StockItemsUnderMinRequest request) {
            return base.Channel.StockItemsUnderMinAsync(request);
        }
        
        public System.Threading.Tasks.Task<VinImport.DVIService.StockItemsUnderMinResponse> StockItemsUnderMinAsync() {
            VinImport.DVIService.StockItemsUnderMinRequest inValue = new VinImport.DVIService.StockItemsUnderMinRequest();
            inValue.Body = new VinImport.DVIService.StockItemsUnderMinRequestBody();
            return ((VinImport.DVIService.monitorSoap)(this)).StockItemsUnderMinAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VinImport.DVIService.StockItemsOverMaxResponse VinImport.DVIService.monitorSoap.StockItemsOverMax(VinImport.DVIService.StockItemsOverMaxRequest request) {
            return base.Channel.StockItemsOverMax(request);
        }
        
        public VinImport.DVIService.ArrayOfString StockItemsOverMax() {
            VinImport.DVIService.StockItemsOverMaxRequest inValue = new VinImport.DVIService.StockItemsOverMaxRequest();
            inValue.Body = new VinImport.DVIService.StockItemsOverMaxRequestBody();
            VinImport.DVIService.StockItemsOverMaxResponse retVal = ((VinImport.DVIService.monitorSoap)(this)).StockItemsOverMax(inValue);
            return retVal.Body.StockItemsOverMaxResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VinImport.DVIService.StockItemsOverMaxResponse> VinImport.DVIService.monitorSoap.StockItemsOverMaxAsync(VinImport.DVIService.StockItemsOverMaxRequest request) {
            return base.Channel.StockItemsOverMaxAsync(request);
        }
        
        public System.Threading.Tasks.Task<VinImport.DVIService.StockItemsOverMaxResponse> StockItemsOverMaxAsync() {
            VinImport.DVIService.StockItemsOverMaxRequest inValue = new VinImport.DVIService.StockItemsOverMaxRequest();
            inValue.Body = new VinImport.DVIService.StockItemsOverMaxRequestBody();
            return ((VinImport.DVIService.monitorSoap)(this)).StockItemsOverMaxAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VinImport.DVIService.StockItemsMostSoldResponse VinImport.DVIService.monitorSoap.StockItemsMostSold(VinImport.DVIService.StockItemsMostSoldRequest request) {
            return base.Channel.StockItemsMostSold(request);
        }
        
        public VinImport.DVIService.ArrayOfString StockItemsMostSold() {
            VinImport.DVIService.StockItemsMostSoldRequest inValue = new VinImport.DVIService.StockItemsMostSoldRequest();
            inValue.Body = new VinImport.DVIService.StockItemsMostSoldRequestBody();
            VinImport.DVIService.StockItemsMostSoldResponse retVal = ((VinImport.DVIService.monitorSoap)(this)).StockItemsMostSold(inValue);
            return retVal.Body.StockItemsMostSoldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VinImport.DVIService.StockItemsMostSoldResponse> VinImport.DVIService.monitorSoap.StockItemsMostSoldAsync(VinImport.DVIService.StockItemsMostSoldRequest request) {
            return base.Channel.StockItemsMostSoldAsync(request);
        }
        
        public System.Threading.Tasks.Task<VinImport.DVIService.StockItemsMostSoldResponse> StockItemsMostSoldAsync() {
            VinImport.DVIService.StockItemsMostSoldRequest inValue = new VinImport.DVIService.StockItemsMostSoldRequest();
            inValue.Body = new VinImport.DVIService.StockItemsMostSoldRequestBody();
            return ((VinImport.DVIService.monitorSoap)(this)).StockItemsMostSoldAsync(inValue);
        }
    }
}