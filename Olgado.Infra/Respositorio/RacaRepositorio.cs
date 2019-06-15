using Olgado.Domain.Entidades;
using Olgado.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Infra.Respositorio
{
    public class RacaRepositorio : IRacaRepositorio, IDisposable
    {

        public IEnumerable<Raca> ObterTodos()
        {
            List<Raca> racas = new List<Raca>();
            #region Racas
            racas.Add(new Raca("Aberdeen Angus"));
            racas.Add(new Raca("Outros"));
            racas.Add(new Raca("Senepol"));
            racas.Add(new Raca("Girolando"));
            racas.Add(new Raca("Brahman"));
            racas.Add(new Raca("Tabapuã"));
            racas.Add(new Raca("Red Angus"));
            racas.Add(new Raca("Guzerá"));
            racas.Add(new Raca("Brangus"));
            racas.Add(new Raca("Gir"));
            racas.Add(new Raca("Canchim"));
            racas.Add(new Raca("Holandês"));
            racas.Add(new Raca("Diversos"));
            racas.Add(new Raca("Jersey"));
            racas.Add(new Raca("Simental"));
            racas.Add(new Raca("Braford"));
            racas.Add(new Raca("Outros"));
            racas.Add(new Raca("Charolês"));
            racas.Add(new Raca("Hereford"));
            racas.Add(new Raca("Pardo Suiço"));
            racas.Add(new Raca("Marchigiana"));
            racas.Add(new Raca("Bonsmara"));
            racas.Add(new Raca("Caracu"));
            racas.Add(new Raca("Devon"));
            racas.Add(new Raca("Sindi"));
            racas.Add(new Raca("Indubrasil"));
            racas.Add(new Raca("Normando"));
            racas.Add(new Raca("Blond D'aquitaine "));
            racas.Add(new Raca("Guernsey"));
            racas.Add(new Raca("Red Poll"));
            racas.Add(new Raca("Blonel"));
            racas.Add(new Raca("Limonsin"));
            racas.Add(new Raca("Jersolando"));
            #endregion

            return racas;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
