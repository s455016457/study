﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTest.WebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        private bool IsVipField;
        
        private System.DateTime CreatedStampField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public bool IsVip {
            get {
                return this.IsVipField;
            }
            set {
                if ((this.IsVipField.Equals(value) != true)) {
                    this.IsVipField = value;
                    this.RaisePropertyChanged("IsVip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.DateTime CreatedStamp {
            get {
                return this.CreatedStampField;
            }
            set {
                if ((this.CreatedStampField.Equals(value) != true)) {
                    this.CreatedStampField = value;
                    this.RaisePropertyChanged("CreatedStamp");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebService.StudentServiceSoap")]
    public interface StudentServiceSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 HelloWorldResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        UnitTest.WebService.HelloWorldResponse HelloWorld(UnitTest.WebService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitTest.WebService.HelloWorldResponse> HelloWorldAsync(UnitTest.WebService.HelloWorldRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 GetStudentResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStudent", ReplyAction="*")]
        UnitTest.WebService.GetStudentResponse GetStudent(UnitTest.WebService.GetStudentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStudent", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitTest.WebService.GetStudentResponse> GetStudentAsync(UnitTest.WebService.GetStudentRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 GetStudentListResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStudentList", ReplyAction="*")]
        UnitTest.WebService.GetStudentListResponse GetStudentList(UnitTest.WebService.GetStudentListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStudentList", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitTest.WebService.GetStudentListResponse> GetStudentListAsync(UnitTest.WebService.GetStudentListRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public UnitTest.WebService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(UnitTest.WebService.HelloWorldRequestBody Body) {
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
        public UnitTest.WebService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(UnitTest.WebService.HelloWorldResponseBody Body) {
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
    public partial class GetStudentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudent", Namespace="http://tempuri.org/", Order=0)]
        public UnitTest.WebService.GetStudentRequestBody Body;
        
        public GetStudentRequest() {
        }
        
        public GetStudentRequest(UnitTest.WebService.GetStudentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetStudentRequestBody {
        
        public GetStudentRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudentResponse", Namespace="http://tempuri.org/", Order=0)]
        public UnitTest.WebService.GetStudentResponseBody Body;
        
        public GetStudentResponse() {
        }
        
        public GetStudentResponse(UnitTest.WebService.GetStudentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStudentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public UnitTest.WebService.Student GetStudentResult;
        
        public GetStudentResponseBody() {
        }
        
        public GetStudentResponseBody(UnitTest.WebService.Student GetStudentResult) {
            this.GetStudentResult = GetStudentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudentListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudentList", Namespace="http://tempuri.org/", Order=0)]
        public UnitTest.WebService.GetStudentListRequestBody Body;
        
        public GetStudentListRequest() {
        }
        
        public GetStudentListRequest(UnitTest.WebService.GetStudentListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetStudentListRequestBody {
        
        public GetStudentListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudentListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudentListResponse", Namespace="http://tempuri.org/", Order=0)]
        public UnitTest.WebService.GetStudentListResponseBody Body;
        
        public GetStudentListResponse() {
        }
        
        public GetStudentListResponse(UnitTest.WebService.GetStudentListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStudentListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.Generic.List<UnitTest.WebService.Student> GetStudentListResult;
        
        public GetStudentListResponseBody() {
        }
        
        public GetStudentListResponseBody(System.Collections.Generic.List<UnitTest.WebService.Student> GetStudentListResult) {
            this.GetStudentListResult = GetStudentListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StudentServiceSoapChannel : UnitTest.WebService.StudentServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentServiceSoapClient : System.ServiceModel.ClientBase<UnitTest.WebService.StudentServiceSoap>, UnitTest.WebService.StudentServiceSoap {
        
        public StudentServiceSoapClient() {
        }
        
        public StudentServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitTest.WebService.HelloWorldResponse UnitTest.WebService.StudentServiceSoap.HelloWorld(UnitTest.WebService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            UnitTest.WebService.HelloWorldRequest inValue = new UnitTest.WebService.HelloWorldRequest();
            inValue.Body = new UnitTest.WebService.HelloWorldRequestBody();
            UnitTest.WebService.HelloWorldResponse retVal = ((UnitTest.WebService.StudentServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitTest.WebService.HelloWorldResponse> UnitTest.WebService.StudentServiceSoap.HelloWorldAsync(UnitTest.WebService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitTest.WebService.HelloWorldResponse> HelloWorldAsync() {
            UnitTest.WebService.HelloWorldRequest inValue = new UnitTest.WebService.HelloWorldRequest();
            inValue.Body = new UnitTest.WebService.HelloWorldRequestBody();
            return ((UnitTest.WebService.StudentServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitTest.WebService.GetStudentResponse UnitTest.WebService.StudentServiceSoap.GetStudent(UnitTest.WebService.GetStudentRequest request) {
            return base.Channel.GetStudent(request);
        }
        
        public UnitTest.WebService.Student GetStudent() {
            UnitTest.WebService.GetStudentRequest inValue = new UnitTest.WebService.GetStudentRequest();
            inValue.Body = new UnitTest.WebService.GetStudentRequestBody();
            UnitTest.WebService.GetStudentResponse retVal = ((UnitTest.WebService.StudentServiceSoap)(this)).GetStudent(inValue);
            return retVal.Body.GetStudentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitTest.WebService.GetStudentResponse> UnitTest.WebService.StudentServiceSoap.GetStudentAsync(UnitTest.WebService.GetStudentRequest request) {
            return base.Channel.GetStudentAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitTest.WebService.GetStudentResponse> GetStudentAsync() {
            UnitTest.WebService.GetStudentRequest inValue = new UnitTest.WebService.GetStudentRequest();
            inValue.Body = new UnitTest.WebService.GetStudentRequestBody();
            return ((UnitTest.WebService.StudentServiceSoap)(this)).GetStudentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitTest.WebService.GetStudentListResponse UnitTest.WebService.StudentServiceSoap.GetStudentList(UnitTest.WebService.GetStudentListRequest request) {
            return base.Channel.GetStudentList(request);
        }
        
        public System.Collections.Generic.List<UnitTest.WebService.Student> GetStudentList() {
            UnitTest.WebService.GetStudentListRequest inValue = new UnitTest.WebService.GetStudentListRequest();
            inValue.Body = new UnitTest.WebService.GetStudentListRequestBody();
            UnitTest.WebService.GetStudentListResponse retVal = ((UnitTest.WebService.StudentServiceSoap)(this)).GetStudentList(inValue);
            return retVal.Body.GetStudentListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitTest.WebService.GetStudentListResponse> UnitTest.WebService.StudentServiceSoap.GetStudentListAsync(UnitTest.WebService.GetStudentListRequest request) {
            return base.Channel.GetStudentListAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitTest.WebService.GetStudentListResponse> GetStudentListAsync() {
            UnitTest.WebService.GetStudentListRequest inValue = new UnitTest.WebService.GetStudentListRequest();
            inValue.Body = new UnitTest.WebService.GetStudentListRequestBody();
            return ((UnitTest.WebService.StudentServiceSoap)(this)).GetStudentListAsync(inValue);
        }
    }
}