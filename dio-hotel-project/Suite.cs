using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dio_hotel_project
{
    internal class Suite
    {

        String tipoSuite;
        int capacidade;
        decimal valorDiaria;

        public string TipoSuite { get => tipoSuite; set => tipoSuite = value; }
        public int Capacidade { get => capacidade; set => capacidade = value; }
        public decimal ValorDiaria { get => valorDiaria; set => valorDiaria = value; }
    }
}
