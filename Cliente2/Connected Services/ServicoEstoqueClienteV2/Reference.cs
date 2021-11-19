﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente2.ServicoEstoqueClienteV2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produto", Namespace="http://schemas.datacontract.org/2004/07/EstoqueProduto")]
    [System.SerializableAttribute()]
    public partial class Produto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstoqueProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroProdutoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoProduto {
            get {
                return this.DescricaoProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoProdutoField, value) != true)) {
                    this.DescricaoProdutoField = value;
                    this.RaisePropertyChanged("DescricaoProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstoqueProduto {
            get {
                return this.EstoqueProdutoField;
            }
            set {
                if ((this.EstoqueProdutoField.Equals(value) != true)) {
                    this.EstoqueProdutoField = value;
                    this.RaisePropertyChanged("EstoqueProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto {
            get {
                return this.NomeProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeProdutoField, value) != true)) {
                    this.NomeProdutoField = value;
                    this.RaisePropertyChanged("NomeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroProduto {
            get {
                return this.NumeroProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroProdutoField, value) != true)) {
                    this.NumeroProdutoField = value;
                    this.RaisePropertyChanged("NumeroProduto");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/01", ConfigurationName="ServicoEstoqueClienteV2.IServicoEstoque")]
    public interface IServicoEstoque {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutosResponse")]
        string[] ListarProdutos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutosResponse")]
        System.Threading.Tasks.Task<string[]> ListarProdutosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProdutoResponse")]
        bool IncluirProduto(Cliente2.ServicoEstoqueClienteV2.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProdutoResponse")]
        System.Threading.Tasks.Task<bool> IncluirProdutoAsync(Cliente2.ServicoEstoqueClienteV2.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProdutoResponse")]
        bool RemoverProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProdutoResponse")]
        System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProdutoResponse")]
        Cliente2.ServicoEstoqueClienteV2.Produto VerProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProdutoResponse")]
        System.Threading.Tasks.Task<Cliente2.ServicoEstoqueClienteV2.Produto> VerProdutoAsync(string NumeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstoqueChannel : Cliente2.ServicoEstoqueClienteV2.IServicoEstoque, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstoqueClient : System.ServiceModel.ClientBase<Cliente2.ServicoEstoqueClienteV2.IServicoEstoque>, Cliente2.ServicoEstoqueClienteV2.IServicoEstoque {
        
        public ServicoEstoqueClient() {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ListarProdutos() {
            return base.Channel.ListarProdutos();
        }
        
        public System.Threading.Tasks.Task<string[]> ListarProdutosAsync() {
            return base.Channel.ListarProdutosAsync();
        }
        
        public bool IncluirProduto(Cliente2.ServicoEstoqueClienteV2.Produto produto) {
            return base.Channel.IncluirProduto(produto);
        }
        
        public System.Threading.Tasks.Task<bool> IncluirProdutoAsync(Cliente2.ServicoEstoqueClienteV2.Produto produto) {
            return base.Channel.IncluirProdutoAsync(produto);
        }
        
        public bool RemoverProduto(string NumeroProduto) {
            return base.Channel.RemoverProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto) {
            return base.Channel.RemoverProdutoAsync(NumeroProduto);
        }
        
        public int ConsultarEstoque(string NumeroProduto) {
            return base.Channel.ConsultarEstoque(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto) {
            return base.Channel.ConsultarEstoqueAsync(NumeroProduto);
        }
        
        public bool AdicionarEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.AdicionarEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.AdicionarEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public bool RemoverEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public Cliente2.ServicoEstoqueClienteV2.Produto VerProduto(string NumeroProduto) {
            return base.Channel.VerProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<Cliente2.ServicoEstoqueClienteV2.Produto> VerProdutoAsync(string NumeroProduto) {
            return base.Channel.VerProdutoAsync(NumeroProduto);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/02", ConfigurationName="ServicoEstoqueClienteV2.IServicoEstoqueV2")]
    public interface IServicoEstoqueV2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstoqueV2Channel : Cliente2.ServicoEstoqueClienteV2.IServicoEstoqueV2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstoqueV2Client : System.ServiceModel.ClientBase<Cliente2.ServicoEstoqueClienteV2.IServicoEstoqueV2>, Cliente2.ServicoEstoqueClienteV2.IServicoEstoqueV2 {
        
        public ServicoEstoqueV2Client() {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueV2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AdicionarEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.AdicionarEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.AdicionarEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public bool RemoverEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public int ConsultarEstoque(string NumeroProduto) {
            return base.Channel.ConsultarEstoque(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto) {
            return base.Channel.ConsultarEstoqueAsync(NumeroProduto);
        }
    }
}
