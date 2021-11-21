using System;

namespace app_transf_bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Walfrank Corrêa");
            
            Console.WriteLine("\n{0}", minhaConta.ToString());
        }
    }
}