using System;

namespace app_transf_bancaria
{
    public class Conta
    {   //Atributos do Classe - Objeto
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private TipoConta TipoConta { get; set; }

        public Conta (TipoConta tipoconta, double saldo, double credito, string nome)
        {   //Método construtor
            this.TipoConta = tipoconta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        public bool Sacar(double valorSaque)
        {
            //Validação de saldo suficiente/insuficiente
            if (this.Saldo - valorSaque < (this.Credito *-1))
            {
                Console.WriteLine("Saldo insufuciente!");
                return false;
            }

            this.Saldo -= valorSaque;
            Console.WriteLine("Saque realizado com sucesso!\nSaldo atual da ",
                              "conta {0} é {1}", this.Nome, this.Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        //Método ToString, muito usado para gravar logs.
        public override string ToString()
        {   //Este médoto sobrescreve o método nativo - override, retorna string
            string retorno = "";
            retorno += "Tipoconta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Credito " + this.Credito + " | ";
            return retorno;
        }
    }
}