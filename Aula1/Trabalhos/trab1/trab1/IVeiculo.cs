using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab1
{
    interface IVeiculo
    {
        void SetMarca(string nome);
        void SetModelo(string nome);
        void SetValor(double valor);
    }
}
