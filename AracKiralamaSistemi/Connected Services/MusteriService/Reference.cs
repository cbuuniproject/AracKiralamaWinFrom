﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AracKiralamaSistemi.MusteriService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Musteri", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Musteri : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int musteriIdField;
        
        private int kullaniciIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string adField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string soyadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AracKiralamaSistemi.MusteriService.Kullanici kullaniciField;
        
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
        public int musteriId {
            get {
                return this.musteriIdField;
            }
            set {
                if ((this.musteriIdField.Equals(value) != true)) {
                    this.musteriIdField = value;
                    this.RaisePropertyChanged("musteriId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int kullaniciId {
            get {
                return this.kullaniciIdField;
            }
            set {
                if ((this.kullaniciIdField.Equals(value) != true)) {
                    this.kullaniciIdField = value;
                    this.RaisePropertyChanged("kullaniciId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ad {
            get {
                return this.adField;
            }
            set {
                if ((object.ReferenceEquals(this.adField, value) != true)) {
                    this.adField = value;
                    this.RaisePropertyChanged("ad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string soyad {
            get {
                return this.soyadField;
            }
            set {
                if ((object.ReferenceEquals(this.soyadField, value) != true)) {
                    this.soyadField = value;
                    this.RaisePropertyChanged("soyad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public AracKiralamaSistemi.MusteriService.Kullanici kullanici {
            get {
                return this.kullaniciField;
            }
            set {
                if ((object.ReferenceEquals(this.kullaniciField, value) != true)) {
                    this.kullaniciField = value;
                    this.RaisePropertyChanged("kullanici");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Kullanici", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Kullanici : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int kullaniciIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kullaniciAdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parolaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kullaniciTuruField;
        
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
        public int kullaniciId {
            get {
                return this.kullaniciIdField;
            }
            set {
                if ((this.kullaniciIdField.Equals(value) != true)) {
                    this.kullaniciIdField = value;
                    this.RaisePropertyChanged("kullaniciId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string kullaniciAd {
            get {
                return this.kullaniciAdField;
            }
            set {
                if ((object.ReferenceEquals(this.kullaniciAdField, value) != true)) {
                    this.kullaniciAdField = value;
                    this.RaisePropertyChanged("kullaniciAd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string parola {
            get {
                return this.parolaField;
            }
            set {
                if ((object.ReferenceEquals(this.parolaField, value) != true)) {
                    this.parolaField = value;
                    this.RaisePropertyChanged("parola");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string kullaniciTuru {
            get {
                return this.kullaniciTuruField;
            }
            set {
                if ((object.ReferenceEquals(this.kullaniciTuruField, value) != true)) {
                    this.kullaniciTuruField = value;
                    this.RaisePropertyChanged("kullaniciTuru");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MusteriService.MusteriWebServiceSoap")]
    public interface MusteriWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name entity from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertMusteri", ReplyAction="*")]
        AracKiralamaSistemi.MusteriService.InsertMusteriResponse InsertMusteri(AracKiralamaSistemi.MusteriService.InsertMusteriRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertMusteri", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralamaSistemi.MusteriService.InsertMusteriResponse> InsertMusteriAsync(AracKiralamaSistemi.MusteriService.InsertMusteriRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteMusteri", ReplyAction="*")]
        bool DeleteMusteri(int musteriId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteMusteri", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteMusteriAsync(int musteriId);
        
        // CODEGEN: Generating message contract since element name SelectAllMusterisResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectAllMusteris", ReplyAction="*")]
        AracKiralamaSistemi.MusteriService.SelectAllMusterisResponse SelectAllMusteris(AracKiralamaSistemi.MusteriService.SelectAllMusterisRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectAllMusteris", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralamaSistemi.MusteriService.SelectAllMusterisResponse> SelectAllMusterisAsync(AracKiralamaSistemi.MusteriService.SelectAllMusterisRequest request);
        
        // CODEGEN: Generating message contract since element name SelectMusteriByIdResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectMusteriById", ReplyAction="*")]
        AracKiralamaSistemi.MusteriService.SelectMusteriByIdResponse SelectMusteriById(AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectMusteriById", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralamaSistemi.MusteriService.SelectMusteriByIdResponse> SelectMusteriByIdAsync(AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertMusteriRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertMusteri", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralamaSistemi.MusteriService.InsertMusteriRequestBody Body;
        
        public InsertMusteriRequest() {
        }
        
        public InsertMusteriRequest(AracKiralamaSistemi.MusteriService.InsertMusteriRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertMusteriRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralamaSistemi.MusteriService.Musteri entity;
        
        public InsertMusteriRequestBody() {
        }
        
        public InsertMusteriRequestBody(AracKiralamaSistemi.MusteriService.Musteri entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertMusteriResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertMusteriResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralamaSistemi.MusteriService.InsertMusteriResponseBody Body;
        
        public InsertMusteriResponse() {
        }
        
        public InsertMusteriResponse(AracKiralamaSistemi.MusteriService.InsertMusteriResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertMusteriResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool InsertMusteriResult;
        
        public InsertMusteriResponseBody() {
        }
        
        public InsertMusteriResponseBody(bool InsertMusteriResult) {
            this.InsertMusteriResult = InsertMusteriResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectAllMusterisRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectAllMusteris", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralamaSistemi.MusteriService.SelectAllMusterisRequestBody Body;
        
        public SelectAllMusterisRequest() {
        }
        
        public SelectAllMusterisRequest(AracKiralamaSistemi.MusteriService.SelectAllMusterisRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SelectAllMusterisRequestBody {
        
        public SelectAllMusterisRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectAllMusterisResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectAllMusterisResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralamaSistemi.MusteriService.SelectAllMusterisResponseBody Body;
        
        public SelectAllMusterisResponse() {
        }
        
        public SelectAllMusterisResponse(AracKiralamaSistemi.MusteriService.SelectAllMusterisResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelectAllMusterisResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralamaSistemi.MusteriService.Musteri[] SelectAllMusterisResult;
        
        public SelectAllMusterisResponseBody() {
        }
        
        public SelectAllMusterisResponseBody(AracKiralamaSistemi.MusteriService.Musteri[] SelectAllMusterisResult) {
            this.SelectAllMusterisResult = SelectAllMusterisResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectMusteriByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectMusteriById", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequestBody Body;
        
        public SelectMusteriByIdRequest() {
        }
        
        public SelectMusteriByIdRequest(AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelectMusteriByIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int musteriId;
        
        public SelectMusteriByIdRequestBody() {
        }
        
        public SelectMusteriByIdRequestBody(int musteriId) {
            this.musteriId = musteriId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectMusteriByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectMusteriByIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralamaSistemi.MusteriService.SelectMusteriByIdResponseBody Body;
        
        public SelectMusteriByIdResponse() {
        }
        
        public SelectMusteriByIdResponse(AracKiralamaSistemi.MusteriService.SelectMusteriByIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelectMusteriByIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralamaSistemi.MusteriService.Musteri SelectMusteriByIdResult;
        
        public SelectMusteriByIdResponseBody() {
        }
        
        public SelectMusteriByIdResponseBody(AracKiralamaSistemi.MusteriService.Musteri SelectMusteriByIdResult) {
            this.SelectMusteriByIdResult = SelectMusteriByIdResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MusteriWebServiceSoapChannel : AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MusteriWebServiceSoapClient : System.ServiceModel.ClientBase<AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap>, AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap {
        
        public MusteriWebServiceSoapClient() {
        }
        
        public MusteriWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MusteriWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusteriWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusteriWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralamaSistemi.MusteriService.InsertMusteriResponse AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap.InsertMusteri(AracKiralamaSistemi.MusteriService.InsertMusteriRequest request) {
            return base.Channel.InsertMusteri(request);
        }
        
        public bool InsertMusteri(AracKiralamaSistemi.MusteriService.Musteri entity) {
            AracKiralamaSistemi.MusteriService.InsertMusteriRequest inValue = new AracKiralamaSistemi.MusteriService.InsertMusteriRequest();
            inValue.Body = new AracKiralamaSistemi.MusteriService.InsertMusteriRequestBody();
            inValue.Body.entity = entity;
            AracKiralamaSistemi.MusteriService.InsertMusteriResponse retVal = ((AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap)(this)).InsertMusteri(inValue);
            return retVal.Body.InsertMusteriResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralamaSistemi.MusteriService.InsertMusteriResponse> AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap.InsertMusteriAsync(AracKiralamaSistemi.MusteriService.InsertMusteriRequest request) {
            return base.Channel.InsertMusteriAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralamaSistemi.MusteriService.InsertMusteriResponse> InsertMusteriAsync(AracKiralamaSistemi.MusteriService.Musteri entity) {
            AracKiralamaSistemi.MusteriService.InsertMusteriRequest inValue = new AracKiralamaSistemi.MusteriService.InsertMusteriRequest();
            inValue.Body = new AracKiralamaSistemi.MusteriService.InsertMusteriRequestBody();
            inValue.Body.entity = entity;
            return ((AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap)(this)).InsertMusteriAsync(inValue);
        }
        
        public bool DeleteMusteri(int musteriId) {
            return base.Channel.DeleteMusteri(musteriId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteMusteriAsync(int musteriId) {
            return base.Channel.DeleteMusteriAsync(musteriId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralamaSistemi.MusteriService.SelectAllMusterisResponse AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap.SelectAllMusteris(AracKiralamaSistemi.MusteriService.SelectAllMusterisRequest request) {
            return base.Channel.SelectAllMusteris(request);
        }
        
        public AracKiralamaSistemi.MusteriService.Musteri[] SelectAllMusteris() {
            AracKiralamaSistemi.MusteriService.SelectAllMusterisRequest inValue = new AracKiralamaSistemi.MusteriService.SelectAllMusterisRequest();
            inValue.Body = new AracKiralamaSistemi.MusteriService.SelectAllMusterisRequestBody();
            AracKiralamaSistemi.MusteriService.SelectAllMusterisResponse retVal = ((AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap)(this)).SelectAllMusteris(inValue);
            return retVal.Body.SelectAllMusterisResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralamaSistemi.MusteriService.SelectAllMusterisResponse> AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap.SelectAllMusterisAsync(AracKiralamaSistemi.MusteriService.SelectAllMusterisRequest request) {
            return base.Channel.SelectAllMusterisAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralamaSistemi.MusteriService.SelectAllMusterisResponse> SelectAllMusterisAsync() {
            AracKiralamaSistemi.MusteriService.SelectAllMusterisRequest inValue = new AracKiralamaSistemi.MusteriService.SelectAllMusterisRequest();
            inValue.Body = new AracKiralamaSistemi.MusteriService.SelectAllMusterisRequestBody();
            return ((AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap)(this)).SelectAllMusterisAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralamaSistemi.MusteriService.SelectMusteriByIdResponse AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap.SelectMusteriById(AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequest request) {
            return base.Channel.SelectMusteriById(request);
        }
        
        public AracKiralamaSistemi.MusteriService.Musteri SelectMusteriById(int musteriId) {
            AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequest inValue = new AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequest();
            inValue.Body = new AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequestBody();
            inValue.Body.musteriId = musteriId;
            AracKiralamaSistemi.MusteriService.SelectMusteriByIdResponse retVal = ((AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap)(this)).SelectMusteriById(inValue);
            return retVal.Body.SelectMusteriByIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralamaSistemi.MusteriService.SelectMusteriByIdResponse> AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap.SelectMusteriByIdAsync(AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequest request) {
            return base.Channel.SelectMusteriByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralamaSistemi.MusteriService.SelectMusteriByIdResponse> SelectMusteriByIdAsync(int musteriId) {
            AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequest inValue = new AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequest();
            inValue.Body = new AracKiralamaSistemi.MusteriService.SelectMusteriByIdRequestBody();
            inValue.Body.musteriId = musteriId;
            return ((AracKiralamaSistemi.MusteriService.MusteriWebServiceSoap)(this)).SelectMusteriByIdAsync(inValue);
        }
    }
}
