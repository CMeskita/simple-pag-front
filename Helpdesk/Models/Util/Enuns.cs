using System.ComponentModel;

namespace Helpdesk.Models.Util
{
    #region helpdesk
    public enum status_cliente
    {
        [Description("Indeterminado")] Undefined = 0,   
        [Description("Ativo")] Ativo = 1,  
        [Description("Pendente")] Pendente = 2,         
        [Description("Inativo")] Inativo = 3,              
        [Description("EXperiencia")] EXperiencia = 4,       
        
    }
    public enum tipo_atendimento
    {
        [Description("Indeterminado")] Undefined = 0,
        [Description("Incidente")] Incidente = 1,
        [Description("Problema")] Problema = 2,
        [Description("Duvidas")] Duvidas = 3,
        [Description("Aprendizado")] Aprendizado = 2,
        [Description("Outros")] Outros = 3
    }
    public enum status_atendimento
    {
        [Description("Concluido")] Concluido = 0,
        [Description("Atendimento")] Atendimento = 1,
        [Description("Aguardadno")] Aguardadno = 2,

    }
    public enum tipo_arquivo
    {
        [Description("TXT")] TXT = 0,
        [Description("PDF")] PDF = 1,
        [Description("EXCEL")] EXCEL = 2,
        [Description("IMAGEM")] IMAGEM = 3,
        [Description("OUTRO")] OUTRO = 4,

    }
    public enum alert_type
    {
        [Description("Indeterminado")] Undefined = 0,
        [Description("Erro Crítico")] CriticalError = 1,
        [Description("Erro")] Error = 2,
        [Description("Alerta")] Warning = 3,
        [Description("Informação")] Info = 4
    }
    public enum notification_channel_type
    {
        [Description("Indeterminado")] Undefined = 0,
        [Description("Email")] Email = 1,
        [Description("SMS")] SMS = 2,
        [Description("Push")] Push = 3,
        [Description("Webhook")] Webhook = 4
    }
    #endregion
}
