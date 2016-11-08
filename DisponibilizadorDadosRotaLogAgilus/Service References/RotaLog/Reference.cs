﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DisponibilizadorDadosRotaLogAgilus.RotaLog {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://jointecnologia.com/", ConfigurationName="RotaLog.WebServiceRotaSoap")]
    public interface WebServiceRotaSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jointecnologia.com/IncluiColeta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string IncluiColeta(
                    string sLogin, 
                    string sSenha, 
                    string cliCPF, 
                    string cliRG, 
                    string cliNome, 
                    System.DateTime cliDataNascimento, 
                    char cliSexo, 
                    string cliTelefone1, 
                    string cliTelefone2, 
                    string cliTelefone3, 
                    string cliEndereco, 
                    string cliComplemento, 
                    string cliBairro, 
                    string cliCidade, 
                    string cliUF, 
                    string cliCEP, 
                    string cliPontoReferencia, 
                    System.DateTime colDataAgendamento, 
                    char colTurnoAgendamento, 
                    int colQuantFolhas, 
                    int colCodTipoDocumento, 
                    string colNumeroAdesao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jointecnologia.com/IncluiColeta", ReplyAction="*")]
        System.Threading.Tasks.Task<string> IncluiColetaAsync(
                    string sLogin, 
                    string sSenha, 
                    string cliCPF, 
                    string cliRG, 
                    string cliNome, 
                    System.DateTime cliDataNascimento, 
                    char cliSexo, 
                    string cliTelefone1, 
                    string cliTelefone2, 
                    string cliTelefone3, 
                    string cliEndereco, 
                    string cliComplemento, 
                    string cliBairro, 
                    string cliCidade, 
                    string cliUF, 
                    string cliCEP, 
                    string cliPontoReferencia, 
                    System.DateTime colDataAgendamento, 
                    char colTurnoAgendamento, 
                    int colQuantFolhas, 
                    int colCodTipoDocumento, 
                    string colNumeroAdesao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jointecnologia.com/ConsultaFasesColeta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ConsultaFasesColeta(string sLogin, string sSenha, int CodigoColeta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jointecnologia.com/ConsultaFasesColeta", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ConsultaFasesColetaAsync(string sLogin, string sSenha, int CodigoColeta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jointecnologia.com/ConsultaCaminhoDocumentos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ConsultaCaminhoDocumentos(string sLogin, string sSenha, int CodigoColeta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jointecnologia.com/ConsultaCaminhoDocumentos", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ConsultaCaminhoDocumentosAsync(string sLogin, string sSenha, int CodigoColeta);
        
        // CODEGEN: Parameter 'Arquivo' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://jointecnologia.com/UploadArquivo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoResponse UploadArquivo(DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jointecnologia.com/UploadArquivo", ReplyAction="*")]
        System.Threading.Tasks.Task<DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoResponse> UploadArquivoAsync(DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UploadArquivo", WrapperNamespace="http://jointecnologia.com/", IsWrapped=true)]
    public partial class UploadArquivoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jointecnologia.com/", Order=0)]
        public string sLogin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jointecnologia.com/", Order=1)]
        public string sSenha;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jointecnologia.com/", Order=2)]
        public int CodigoColeta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jointecnologia.com/", Order=3)]
        public string sDescricaoArquivo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jointecnologia.com/", Order=4)]
        public string sNomeOriginalArquivo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jointecnologia.com/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Arquivo;
        
        public UploadArquivoRequest() {
        }
        
        public UploadArquivoRequest(string sLogin, string sSenha, int CodigoColeta, string sDescricaoArquivo, string sNomeOriginalArquivo, byte[] Arquivo) {
            this.sLogin = sLogin;
            this.sSenha = sSenha;
            this.CodigoColeta = CodigoColeta;
            this.sDescricaoArquivo = sDescricaoArquivo;
            this.sNomeOriginalArquivo = sNomeOriginalArquivo;
            this.Arquivo = Arquivo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UploadArquivoResponse", WrapperNamespace="http://jointecnologia.com/", IsWrapped=true)]
    public partial class UploadArquivoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jointecnologia.com/", Order=0)]
        public string UploadArquivoResult;
        
        public UploadArquivoResponse() {
        }
        
        public UploadArquivoResponse(string UploadArquivoResult) {
            this.UploadArquivoResult = UploadArquivoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceRotaSoapChannel : DisponibilizadorDadosRotaLogAgilus.RotaLog.WebServiceRotaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceRotaSoapClient : System.ServiceModel.ClientBase<DisponibilizadorDadosRotaLogAgilus.RotaLog.WebServiceRotaSoap>, DisponibilizadorDadosRotaLogAgilus.RotaLog.WebServiceRotaSoap {
        
        public WebServiceRotaSoapClient() {
        }
        
        public WebServiceRotaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceRotaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceRotaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceRotaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string IncluiColeta(
                    string sLogin, 
                    string sSenha, 
                    string cliCPF, 
                    string cliRG, 
                    string cliNome, 
                    System.DateTime cliDataNascimento, 
                    char cliSexo, 
                    string cliTelefone1, 
                    string cliTelefone2, 
                    string cliTelefone3, 
                    string cliEndereco, 
                    string cliComplemento, 
                    string cliBairro, 
                    string cliCidade, 
                    string cliUF, 
                    string cliCEP, 
                    string cliPontoReferencia, 
                    System.DateTime colDataAgendamento, 
                    char colTurnoAgendamento, 
                    int colQuantFolhas, 
                    int colCodTipoDocumento, 
                    string colNumeroAdesao) {
            return base.Channel.IncluiColeta(sLogin, sSenha, cliCPF, cliRG, cliNome, cliDataNascimento, cliSexo, cliTelefone1, cliTelefone2, cliTelefone3, cliEndereco, cliComplemento, cliBairro, cliCidade, cliUF, cliCEP, cliPontoReferencia, colDataAgendamento, colTurnoAgendamento, colQuantFolhas, colCodTipoDocumento, colNumeroAdesao);
        }
        
        public System.Threading.Tasks.Task<string> IncluiColetaAsync(
                    string sLogin, 
                    string sSenha, 
                    string cliCPF, 
                    string cliRG, 
                    string cliNome, 
                    System.DateTime cliDataNascimento, 
                    char cliSexo, 
                    string cliTelefone1, 
                    string cliTelefone2, 
                    string cliTelefone3, 
                    string cliEndereco, 
                    string cliComplemento, 
                    string cliBairro, 
                    string cliCidade, 
                    string cliUF, 
                    string cliCEP, 
                    string cliPontoReferencia, 
                    System.DateTime colDataAgendamento, 
                    char colTurnoAgendamento, 
                    int colQuantFolhas, 
                    int colCodTipoDocumento, 
                    string colNumeroAdesao) {
            return base.Channel.IncluiColetaAsync(sLogin, sSenha, cliCPF, cliRG, cliNome, cliDataNascimento, cliSexo, cliTelefone1, cliTelefone2, cliTelefone3, cliEndereco, cliComplemento, cliBairro, cliCidade, cliUF, cliCEP, cliPontoReferencia, colDataAgendamento, colTurnoAgendamento, colQuantFolhas, colCodTipoDocumento, colNumeroAdesao);
        }
        
        public System.Data.DataSet ConsultaFasesColeta(string sLogin, string sSenha, int CodigoColeta) {
            return base.Channel.ConsultaFasesColeta(sLogin, sSenha, CodigoColeta);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ConsultaFasesColetaAsync(string sLogin, string sSenha, int CodigoColeta) {
            return base.Channel.ConsultaFasesColetaAsync(sLogin, sSenha, CodigoColeta);
        }
        
        public System.Data.DataSet ConsultaCaminhoDocumentos(string sLogin, string sSenha, int CodigoColeta) {
            return base.Channel.ConsultaCaminhoDocumentos(sLogin, sSenha, CodigoColeta);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ConsultaCaminhoDocumentosAsync(string sLogin, string sSenha, int CodigoColeta) {
            return base.Channel.ConsultaCaminhoDocumentosAsync(sLogin, sSenha, CodigoColeta);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoResponse DisponibilizadorDadosRotaLogAgilus.RotaLog.WebServiceRotaSoap.UploadArquivo(DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoRequest request) {
            return base.Channel.UploadArquivo(request);
        }
        
        public string UploadArquivo(string sLogin, string sSenha, int CodigoColeta, string sDescricaoArquivo, string sNomeOriginalArquivo, byte[] Arquivo) {
            DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoRequest inValue = new DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoRequest();
            inValue.sLogin = sLogin;
            inValue.sSenha = sSenha;
            inValue.CodigoColeta = CodigoColeta;
            inValue.sDescricaoArquivo = sDescricaoArquivo;
            inValue.sNomeOriginalArquivo = sNomeOriginalArquivo;
            inValue.Arquivo = Arquivo;
            DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoResponse retVal = ((DisponibilizadorDadosRotaLogAgilus.RotaLog.WebServiceRotaSoap)(this)).UploadArquivo(inValue);
            return retVal.UploadArquivoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoResponse> DisponibilizadorDadosRotaLogAgilus.RotaLog.WebServiceRotaSoap.UploadArquivoAsync(DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoRequest request) {
            return base.Channel.UploadArquivoAsync(request);
        }
        
        public System.Threading.Tasks.Task<DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoResponse> UploadArquivoAsync(string sLogin, string sSenha, int CodigoColeta, string sDescricaoArquivo, string sNomeOriginalArquivo, byte[] Arquivo) {
            DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoRequest inValue = new DisponibilizadorDadosRotaLogAgilus.RotaLog.UploadArquivoRequest();
            inValue.sLogin = sLogin;
            inValue.sSenha = sSenha;
            inValue.CodigoColeta = CodigoColeta;
            inValue.sDescricaoArquivo = sDescricaoArquivo;
            inValue.sNomeOriginalArquivo = sNomeOriginalArquivo;
            inValue.Arquivo = Arquivo;
            return ((DisponibilizadorDadosRotaLogAgilus.RotaLog.WebServiceRotaSoap)(this)).UploadArquivoAsync(inValue);
        }
    }
}