using FluentValidation;
using System.Text.Json;
using VipSgs.Application.Utils;

namespace VipSgs.Services.Services
{
    public abstract class BaseService
    {
        protected void Validate<TV, TM>(TV validacao, TM viewModel) where TV : AbstractValidator<TM>
        {
            var validador = validacao.Validate(viewModel);

            if (validador.IsValid) return;

            throw CustomException.ErroValidacao(JsonSerializer.Serialize(validador.Errors));
        }

        protected void EntidadeNaoEncontrada(string mensagem)
        {
            throw CustomException.EntityNotFound(JsonSerializer.Serialize(new { erro = mensagem }));
        }
    }
}