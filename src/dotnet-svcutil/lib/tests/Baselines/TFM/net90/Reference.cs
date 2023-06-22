//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net90_NS
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BinLibrary", Namespace="http://schemas.datacontract.org/2004/07/BinLib")]
    public partial class BinLibrary : object
    {
        
        private string ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TypeReuseCompositeType", Namespace="http://schemas.datacontract.org/2004/07/TypesLib")]
    public partial class TypeReuseCompositeType : object
    {
        
        private bool BoolValueField;
        
        private string StringValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue
        {
            get
            {
                return this.BoolValueField;
            }
            set
            {
                this.BoolValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue
        {
            get
            {
                return this.StringValueField;
            }
            set
            {
                this.StringValueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="net90_NS.ITypeReuseSvc")]
    public interface ITypeReuseSvc
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITypeReuseSvc/GetData", ReplyAction="http://tempuri.org/ITypeReuseSvc/GetDataResponse")]
        System.Threading.Tasks.Task<net90_NS.BinLibrary> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITypeReuseSvc/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ITypeReuseSvc/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<net90_NS.TypeReuseCompositeType> GetDataUsingDataContractAsync(net90_NS.TypeReuseCompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    public interface ITypeReuseSvcChannel : net90_NS.ITypeReuseSvc, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    public partial class TypeReuseSvcClient : System.ServiceModel.ClientBase<net90_NS.ITypeReuseSvc>, net90_NS.ITypeReuseSvc
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public TypeReuseSvcClient() : 
                base(TypeReuseSvcClient.GetDefaultBinding(), TypeReuseSvcClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ITypeReuseSvc.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TypeReuseSvcClient(EndpointConfiguration endpointConfiguration) : 
                base(TypeReuseSvcClient.GetBindingForEndpoint(endpointConfiguration), TypeReuseSvcClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TypeReuseSvcClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(TypeReuseSvcClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TypeReuseSvcClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(TypeReuseSvcClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TypeReuseSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<net90_NS.BinLibrary> GetDataAsync(int value)
        {
            return base.Channel.GetDataAsync(value);
        }
        
        public System.Threading.Tasks.Task<net90_NS.TypeReuseCompositeType> GetDataUsingDataContractAsync(net90_NS.TypeReuseCompositeType composite)
        {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ITypeReuseSvc))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ITypeReuseSvc))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:51074/TypeReuseSvc.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return TypeReuseSvcClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ITypeReuseSvc);
        }
        
        public static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return TypeReuseSvcClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ITypeReuseSvc);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ITypeReuseSvc,
        }
    }
}