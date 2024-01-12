using SaqueDeConta.Entities;
using System;

namespace SaqueDeConta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta: ");
                Console.Write("Numero da conta: ");
                int numConta = int.Parse(Console.ReadLine());
                Console.Write("Entre com o titular da conta: ");
                string titular = Console.ReadLine();
                Console.Write("Entre com o saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                Console.Write("Entre com o limite de saque: ");
                double limiteSaque = double.Parse(Console.ReadLine());

                Conta conta = new Conta(numConta, titular, saldo, limiteSaque);

                Console.WriteLine();
                Console.Write("Entre com a quantidade para saque: ");
                double saque = double.Parse(Console.ReadLine());
                conta.Saque(saque);

                Console.WriteLine();
                Console.WriteLine(conta.ToString());
            } 
            catch (DomainException e)
            {
                Console.WriteLine("Erro na transação: " + e.Message);
            }
            catch(Exception e) 
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}