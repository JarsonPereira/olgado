using Olgado.Shared.Entidades;

namespace Olgado.Domain.Entidades
{
    public class Classificacao:Entidade
    {
        public Classificacao(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; private set; }
    }
}
