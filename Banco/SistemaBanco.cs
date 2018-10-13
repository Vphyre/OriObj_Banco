using System.Globalization;
namespace Banco
{
    class SistemaBanco
    {
        public int NumConta{ get; private set; }
        public string Nome { get; set; }
        public double Deposito { get; private set; }
        public double SaldoConta { get; private set; }

        //Construtor
        public SistemaBanco(int NumConta, string Nome, double SaldoConta)
        {

            this.NumConta = NumConta;
            this.Nome = Nome;
            this.SaldoConta = SaldoConta;
            
        }

        //Sobrecarga
        public SistemaBanco(int NumConta, string Nome)
        {

            this.NumConta = NumConta;
            this.Nome = Nome;
            this.SaldoConta = 0;
        }
        //fazer deposito
        public void FazerDeposito(double Valor)
        {
            SaldoConta += Valor;
        }

        //fazer saque
        public void FazerSaque(double Valor)
        {
            SaldoConta -= (Valor + 5);
        }


        public override string ToString()
        {
            return "Conta: "
                +
                NumConta
                + ", Titular: "
                + Nome
                + " Saldo: $ "
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
                
                


        }
    }
}
