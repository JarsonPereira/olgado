using Dapper;
using Olgado.Domain.Entidades;
using Olgado.Domain.Repositorio;
using Olgado.Infra.Contexto;
using System;
using System.Collections.Generic;

namespace Olgado.Infra.Respositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly IDb _Db;

        public Usuario BuscarPorId(Guid id)
        {
            using (var con = _Db.GetCon())
            {
                string sql = "Select From Usuario Where Id= @Id";
                var BuscarPorId = con.QuerySingleOrDefault<Usuario>(sql, new { id });
                return BuscarPorId;
            }
        }

        public void Editar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(Guid id)
        {
            string sql = "Delete From Usuario Where Id=@Id";

            using (var con = _Db.GetCon())
            {
                return con.Execute(sql, new { id }) > 0;

            }

        }

        public IEnumerable<Usuario> ListarTodos()
        {
            using (var con = _Db.GetCon())
            {
                string sql = @"SELECT  * FROM  Usuario";
                var ListaDePessoa = con.Query<Usuario>(sql);
                return ListaDePessoa;
            }

        }

        public void Salvar(Usuario usuario)
        {
            using (var con = _Db.GetCon())
            {
                string sql = @"Insert Into Usuario" +
                              "(Id" +
                            ",Nome" +
                            ",SobreNome" +
                            ",Senha" +
                            ",Email" +
                            ",Telefone" +
                            ",InformacoesContato" +
                            ",PerfilCompra" +
                            ",PerfilVenda)" +
                            "VALUES" +
                             "(@Id" +
                            ",@Nome" +
                            ",@SobreNome" +
                            ",@Senha" +
                            ",@Email" +
                            ",@Telefone" +
                            ",@InformacoesContato" +
                            ",@PerfilCompra" +
                            ",@PerfilVenda)";
                con.Execute(sql, new
                {
                    Id = usuario.ID,
                    Nome = usuario.Nome,
                    SobreNome = usuario.Sobrenome,
                    Senha = usuario.Senha,
                    Email = usuario.Email,
                    Telefone = usuario.Telefone,
                    InformacoesContato = usuario.InformacoesContato,
                    PerfilCompra = usuario.PerfilCompra,
                    PerfilVenda = usuario.PerfilVenda

                });
            }
        }
    }
}

