using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab1
{
    class Veiculo : Veiculos
    {
        private string marca;
        private string modelo;
        private double preco;

        public override void SetMarca(string nome){
           marca = nome;
        }

        public override void SetModelo(string nome)
        {
            modelo = nome;
        }

        public override void SetValor(double valor)
        {
            preco = valor;
        }

        public string GetMarca()
        {
            return marca;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public double GetPreco()
        {
            return preco;
        }
    }
}
