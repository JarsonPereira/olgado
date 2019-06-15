using Olgado.Domain.Enum;
using Olgado.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Domain.Entidades
{
    public class Usuario:Entidade
    {
        public Usuario(string nome, string sobrenome, string senha, string email, PerfilUsuarioComprador perfilCompra, PerfilUsuarioVendedor perfilVenda)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Senha = senha;
            Email = email;
            PerfilCompra = perfilCompra;
            PerfilVenda = perfilVenda;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public PerfilUsuarioComprador PerfilCompra { get; private set; }
        public PerfilUsuarioVendedor PerfilVenda { get; private set; }
    }
}
