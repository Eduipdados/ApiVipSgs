using System.ComponentModel;

namespace VipSgs.Application.Enuns
{
    public enum DocSignErro
    {
        [Description("Não foi possivel identificar um Contrato em andamento para a inscrição informada!")]
        EnvelopeNaoCadastrado = -99,
        [Description("Contrato já assinado anteriormente!")]
        EnvelopeJaAssinado = -101,
        [Description("Erro ao criar envelope!")]
        ErroCriarEnvelope = -200,
    }
}
