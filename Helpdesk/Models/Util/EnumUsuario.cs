using System.ComponentModel;

namespace Helpdesk.Models.Util
{
    public enum status_perfil
    {
        [Description("Suporte")] Suporte = 0,
        [Description("Técnico")] Técnico = 1,
        [Description("Desenvolvidor")] Desenvolvidor = 2,
        [Description("Administrador de Sistema")] AdministradorSistema = 2,

    }
    public enum status_setor
    {
        [Description("Concluido")] TecnologiaIT = 0,
        [Description("Atendimento")] Atendimento = 1,
        [Description("Aguardadno")] Aguardadno = 2,

    }
}
