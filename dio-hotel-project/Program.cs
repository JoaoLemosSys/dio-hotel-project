// See https://aka.ms/new-console-template for more information
namespace dio_hotel_project;

class Program
{
    static void Main(string[] args)
    {

        List<Reserva> reservas = new List<Reserva>();

        int opcao;
        bool sair = false;

        while (sair != true)
        {

            Console.WriteLine("Reservas");
            Console.WriteLine("(0) Nova reserva");
            Console.WriteLine("(1) Listar reservas");
            Console.WriteLine("(2) Sair");
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 0:
                    reservas.Add(NovaReserva());
                    break;

                case 1:

                    Console.WriteLine("===================================");
                    foreach (var reserva in reservas)
                    {
                        Console.WriteLine($"{reserva.Suite.TipoSuite} | {reserva.CalcularValorDiaria()} - {reserva.Hospedes[0].Nome} ");
                    }
                    Console.WriteLine("===================================");

                    break;

                case 2:
                    sair = true;
                    break;

            }
        };

    }



    static Reserva NovaReserva()
    {

        List<Pessoa> hospedes = new List<Pessoa>();
        Console.WriteLine("Nova Reserva");
        Console.WriteLine("Informações da Suite");

        Console.Write("Tipo de suite: ");
        string _tipoSuite = Console.ReadLine();

        Console.Write("Capacidade: ");
        int _capacidade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Valor da Diária: ");
        decimal _valorDiaria = Convert.ToDecimal(Console.ReadLine());

        Suite suite = new Suite();
        suite.Capacidade = _capacidade;
        suite.ValorDiaria = _valorDiaria;
        suite.TipoSuite = _tipoSuite;

        bool sair_hosp = false;
        do
        {
            Console.WriteLine("Hospedes:");
            
            Console.Write("Numero de hospedes: ");
            int numhospedes = Convert.ToInt32(Console.ReadLine());

            if (numhospedes <= suite.Capacidade)
            {
                for (int i = 0; i < numhospedes; i++)
                {
                    Console.WriteLine($"Cadastrar {i + 1} hospede:");
                    Console.Write("Nome: ");
                    String _nome = Console.ReadLine();
                    Console.Write("Sobrenome: ");
                    String _sobrenome = Console.ReadLine();
                    hospedes.Add(new Pessoa(_nome, _sobrenome));

                }
                sair_hosp = true;
            }
            else
            {
                Console.WriteLine($"O numero de hospedes é maior que a capacidade da suite. Capacidade: {suite.Capacidade}\n ");
            }
        } while (!sair_hosp);
        
        Reserva reserva = new Reserva();

        Console.Write("Números de dias:");
        int _diasReservados = Convert.ToInt32(Console.ReadLine());

        reserva.DiasReservados = _diasReservados;
        reserva.CadastrarSuite(suite);
        reserva.CadastraHospedes(hospedes);
        return reserva;


    }

    static void CalcularDiaria()
    {



    }
}
