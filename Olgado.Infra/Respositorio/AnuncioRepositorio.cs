using Dapper;
using Olgado.Domain.Entidades;
using Olgado.Domain.Repositorio;
using Olgado.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Olgado.Infra.Respositorio
{
    public class AnuncioRepositorio : IAnuncioRepositorio
    {
        public static List<Anuncio> anuncios = new List<Anuncio>()
        {
            new Anuncio("5 cabeças",
                new List<string>() { "/Content/olgado/img/boi-01.jpg" },new Domain.ValueObjects.Localizacao()
                {
                    CEP= "7782390",
                    UF="TO",
                    Municipio="Araguaina"
                }
                , new Animal(new Raca("Nelore"), new Classificacao("Gado"), "90@", 3, 899.99M, 120.200M), (899.99M * 3), Domain.Enum.TipoAnuncio.Gratuito),
            new Anuncio("200 cabeças de gado Nelore",
               new List<string>() { "/Content/olgado/img/boi-02.jpg" },
               new Domain.ValueObjects.Localizacao()
               {
                   CEP = "7782390",
                   UF = "TO",
                   Municipio = "Palmas"
               }
               , new Animal(new Raca("Nelore"),new Classificacao("Boi") ,"90@", 300, 899.99M, 120.200M), 899.99M * 300, Domain.Enum.TipoAnuncio.Gratuito)
        };
        private readonly IDb _Db;

        public AnuncioRepositorio()
        {
           
        }

        public Anuncio BuscarPorId(Guid id)
        {
            return anuncios.Where(x => x.ID == id).FirstOrDefault();
        }

        public void Editar(Anuncio anuncio)
        {
            var anuncioRemover = BuscarPorId(anuncio.ID);
            anuncios.Remove(anuncioRemover);
            anuncios.Add(anuncio);

        }

        public bool Excluir(Guid id)
        {
            return anuncios.Remove(BuscarPorId(id));
        }

        public IEnumerable<Anuncio> ListarTodos()
        {
            return anuncios;
        }

        public void Salvar(Anuncio anuncio)
        {
            anuncios.Add(anuncio);
            //using (var con = _Db.GetCon())
            //{
            //    string sql = @"Insert Into Anuncio" +
            //                  "(Id" +
            //                ",IdUsuario" +
            //                ",Descricao" +
            //                ",Localizacao" +
            //                "Valor)"+
            //                "VALUES" +
            //                 "(@Id" +
            //                ",@IdUsuario" +
            //                ",@Descricao" +
            //                ",@Localizacao" +
            //                ",@Valor);" +
            //                "Insert Into Animal" +
            //                  "(Id" +
            //                ",Raca" +
            //                ",Filiacao" +
            //                ",Arroba" +
            //                ",Quantidade" +
            //                ",Valor" +
            //                ",Peso)"+
            //                "VALUES" +
            //                 "(@Id" +
            //                ",@Raca" +
            //                ",@Filiacao" +
            //                ",@Arroba" +
            //                ",@Quantidade" +
            //                ",@Valor)";
            //    con.Execute(sql, new
            //    {
            //        Id = anuncio.ID,
            //        IdUsuario = anuncio.IDUsuario,
            //        Descricao = anuncio.Descricao,
            //        Localizacao = anuncio.Localizacao,
            //        Valor = anuncio.Valor,



            //    });
        }
    }
}

