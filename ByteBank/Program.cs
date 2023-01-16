using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoAndre = new ContaCorrente();

            contaDoAndre.Titular = "Andre Silva";
            contaDoAndre.numero_agencia = 15;
            contaDoAndre.conta = "1010-x";
            contaDoAndre.saldo = 100;



            Console.WriteLine("Saldo da conta corrente: " + contaDoAndre.saldo );

            contaDoAndre.Depositar(100);

            Console.WriteLine("Saldo da conta corrente: " + contaDoAndre.saldo);

            if (contaDoAndre.Saque(50) == true)
            {
                Console.WriteLine("Saldo apos o saque: " + contaDoAndre.saldo);
            }
            else
            {
                Console.WriteLine("Saque Invalido.");
            }
     



        }
    }
}
