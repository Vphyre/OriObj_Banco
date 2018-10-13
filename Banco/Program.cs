using System;
using System.Globalization;


namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaBanco Cliente1;
            double deposito;
            Console.WriteLine("Digite o Numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Cliente1 = new SistemaBanco(conta, nome);

            Console.WriteLine("Haverá depósito inicial(s/n): ");
            string Escolha = Console.ReadLine();


            if (Escolha == "s")
            {
                Console.WriteLine("Digite o valor do deposito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Cliente1.FazerDeposito(deposito);

            }


            //Console.WriteLine("Conta criada!");
            //Console.WriteLine("Conta: " + Cliente1.NumConta + ", Titular: " + Cliente1.Nome + ", Saldo: " + Cliente1.SaldoConta);

            Console.WriteLine(Cliente1);

            Console.WriteLine("Digite um valor para deposito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Cliente1.FazerDeposito(deposito);

            Console.WriteLine(Cliente1);

            Console.WriteLine("Digite um valor para Saque: ");
            Double Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Cliente1.FazerSaque(Saque);

            Console.WriteLine(Cliente1);

            Console.ReadKey();
        }
    }
}
