using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab1
{
    public abstract class Veiculos : IVeiculo
    {
        public abstract void SetMarca(string nome);
        public abstract void SetModelo(string nome);
        public abstract void SetValor(double valor);
        public abstract string GetMarca();
        public abstract string GetModelo();
        public abstract double GetPreco();
    }
}
