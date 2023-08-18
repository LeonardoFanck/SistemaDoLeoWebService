﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Esse código foi gerado por uma ferramenta.
//
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConfiguracoesGerais", Namespace="http://schemas.datacontract.org/2004/07/WEBServiceWCF.Classes")]
    public partial class ConfiguracoesGerais : object
    {
        
        private bool getSetAlterarValorItemField;
        
        private double getSetMaxDescontoItensPedidoField;
        
        private double getSetMaxDescontoPedidoField;
        
        private bool getSetVendaItemNegativoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool getSetAlterarValorItem
        {
            get
            {
                return this.getSetAlterarValorItemField;
            }
            set
            {
                this.getSetAlterarValorItemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double getSetMaxDescontoItensPedido
        {
            get
            {
                return this.getSetMaxDescontoItensPedidoField;
            }
            set
            {
                this.getSetMaxDescontoItensPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double getSetMaxDescontoPedido
        {
            get
            {
                return this.getSetMaxDescontoPedidoField;
            }
            set
            {
                this.getSetMaxDescontoPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool getSetVendaItemNegativo
        {
            get
            {
                return this.getSetVendaItemNegativoField;
            }
            set
            {
                this.getSetVendaItemNegativoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getNomeOperador", ReplyAction="http://tempuri.org/IService1/getNomeOperadorResponse")]
        System.Threading.Tasks.Task<string> getNomeOperadorAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerificaOperador", ReplyAction="http://tempuri.org/IService1/VerificaOperadorResponse")]
        System.Threading.Tasks.Task<int> VerificaOperadorAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerificaLogin", ReplyAction="http://tempuri.org/IService1/VerificaLoginResponse")]
        System.Threading.Tasks.Task<int> VerificaLoginAsync(int ID, int senha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNome", ReplyAction="http://tempuri.org/IService1/GetNomeResponse")]
        System.Threading.Tasks.Task<string> GetNomeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDadosConfiguracoesGerais", ReplyAction="http://tempuri.org/IService1/GetDadosConfiguracoesGeraisResponse")]
        System.Threading.Tasks.Task<ServiceReference1.ConfiguracoesGerais> GetDadosConfiguracoesGeraisAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SalvarConfiguracoesGerais", ReplyAction="http://tempuri.org/IService1/SalvarConfiguracoesGeraisResponse")]
        System.Threading.Tasks.Task<int> SalvarConfiguracoesGeraisAsync(ServiceReference1.ConfiguracoesGerais config);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IService1Channel : ServiceReference1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference1.IService1>, ServiceReference1.IService1
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
        /// </summary>
        /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
        /// <param name="clientCredentials">As credenciais do cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> getNomeOperadorAsync(int ID)
        {
            return base.Channel.getNomeOperadorAsync(ID);
        }
        
        public System.Threading.Tasks.Task<int> VerificaOperadorAsync(int ID)
        {
            return base.Channel.VerificaOperadorAsync(ID);
        }
        
        public System.Threading.Tasks.Task<int> VerificaLoginAsync(int ID, int senha)
        {
            return base.Channel.VerificaLoginAsync(ID, senha);
        }
        
        public System.Threading.Tasks.Task<string> GetNomeAsync(int id)
        {
            return base.Channel.GetNomeAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ConfiguracoesGerais> GetDadosConfiguracoesGeraisAsync()
        {
            return base.Channel.GetDadosConfiguracoesGeraisAsync();
        }
        
        public System.Threading.Tasks.Task<int> SalvarConfiguracoesGeraisAsync(ServiceReference1.ConfiguracoesGerais config)
        {
            return base.Channel.SalvarConfiguracoesGeraisAsync(config);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:55569/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}
