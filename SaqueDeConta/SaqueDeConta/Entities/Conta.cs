using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaqueDeConta.Entities
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteDeSaque { get; set; }

        public Conta()
        {

        }

        public Conta(int numero, string titular, double saldo, double limiteDeSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            if (LimiteDeSaque < saque)
            {
                throw new DomainException("Limite para saque excedido! ");
            }
            else if (Saldo <= 0 || saque > Saldo)
            {
                throw new DomainException("Não há saldo suficiente para realizar o saque! ");
            }
            else
            {
                Saldo -= saque;
            }
        }

        public override string ToString()
        {
            return "Novo saldo da conta: "
                + Saldo.ToString("F2");
        }
    }
}
