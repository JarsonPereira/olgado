using Olgado.Domain.Entidades;
using Olgado.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Infra.Respositorio
{
    public class ClassificacaoRepositorio : IClassificacaoRepositorio
    {

        public IEnumerable<Classificacao> ObterTodos()
        {
            List<Classificacao> classificacoes = new List<Classificacao>();

            #region  Lista de classificacoes
            classificacoes.Add(new Classificacao("Novilha"));
            classificacoes.Add(new Classificacao("Bezerro"));
            classificacoes.Add(new Classificacao("Bezerra"));
            classificacoes.Add(new Classificacao("Vaca"));
            classificacoes.Add(new Classificacao("Garrote"));
            classificacoes.Add(new Classificacao("Touro"));
            classificacoes.Add(new Classificacao("Boi"));
            classificacoes.Add(new Classificacao("Tourinho"));
            classificacoes.Add(new Classificacao("Vaca Parida"));
            classificacoes.Add(new Classificacao("Vaca Prenha"));
            #endregion

            return classificacoes;
        }


    }
}
