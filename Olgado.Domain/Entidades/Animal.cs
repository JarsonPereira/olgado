using Olgado.Domain.ValueObjects;
using Olgado.Shared.Entidades;

namespace Olgado.Domain.Entidades
{
    public class Animal:Entidade
    {
        public Animal(Raca raca, Filiacao filiacao, string arroba, decimal quantidade, decimal valor, decimal peso)
        {
            Raca = raca;
            Filiacao = filiacao;
            Arroba = arroba;
            Quantidade = quantidade;
            Valor = valor;
            Peso = peso;
        }

        public Raca Raca { get; private set; }
        public Filiacao Filiacao { get; private set; }
        public string Arroba { get; private set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; private set; }
        public decimal Peso { get; private set; }
    }
}
