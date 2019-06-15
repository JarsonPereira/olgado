using Olgado.Domain.Enum;
using Olgado.Shared.Entidades;


namespace Olgado.Domain.Entidades
{
    public class Usuario:Entidade
    {

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string InformacoesContato { get; private set; }
        public PerfilUsuarioComprador PerfilCompra { get; private set; }
        public PerfilUsuarioVendedor PerfilVenda { get; private set; }
    }
}
