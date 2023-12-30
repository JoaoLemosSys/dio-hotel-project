using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dio_hotel_project
{
    internal class Reserva
    {
        private List<Pessoa> hospedes=new  List<Pessoa>();
        private Suite suite;
        private int diasReservados;

        public int DiasReservados { get => diasReservados; set => diasReservados = value; }
        internal List<Pessoa> Hospedes { get => hospedes; }
        internal Suite Suite { get => suite;}


      public  void CadastraHospedes(List<Pessoa> hospedes)
        {

            foreach (var pessoa in hospedes)
            {
                this.hospedes.Add(pessoa);
            }
            
        }

        public void CadastrarSuite(Suite suite)
        {
            this.suite = suite;
        }
    
        public int ObterQuantidadeHospedes()
        {

            return this.Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal TotalReserva = this.diasReservados * suite.ValorDiaria;

            if (TotalReserva > 10)
                TotalReserva = TotalReserva - (TotalReserva * (decimal)0.10);

            return TotalReserva;
        }


    }
}
