using Dapper;
using Olgado.Domain.Entidades;
using Olgado.Domain.Repositorio;
using Olgado.Infra.Contexto;
using System;
using System.Collections.Generic;

namespace Olgado.Infra.Respositorio
{
    class AnuncioRepositorio : IAnuncioRepositorio
    {
        private readonly IDb _Db;

        public Anuncio BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Anuncio anuncio)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Anuncio> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Anuncio anuncio)
        {
            using (var con = _Db.GetCon())
            {
                string sql = @"Insert Into Anuncio" +
                              "(Id" +
                            ",IdUsuario" +
                            ",Descricao" +
                            ",Localizacao" +
                            "Valor)"+
                            "VALUES" +
                             "(@Id" +
                            ",@IdUsuario" +
                            ",@Descricao" +
                            ",@Localizacao" +
                            ",@Valor);" +
                            "Insert Into Animal" +
                              "(Id" +
                            ",Raca" +
                            ",Filiacao" +
                            ",Arroba" +
                            ",Quantidade" +
                            ",Valor" +
                            ",Peso)"+
                            "VALUES" +
                             "(@Id" +
                            ",@Raca" +
                            ",@Filiacao" +
                            ",@Arroba" +
                            ",@Quantidade" +
                            ",@Valor)";
                con.Execute(sql, new
                {
                    Id = anuncio.ID,
                    IdUsuario = anuncio.IDUsuario,
                    Descricao = anuncio.Descricao,
                    Localizacao = anuncio.Localizacao,
                    Valor = anuncio.Valor,



                });
            }
        }
    }

}