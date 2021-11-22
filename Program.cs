using System;
using System.Collections.Generic;

namespace app_transf_bancaria
{
    class Program
    {
        //Coleção-Collection-Lista para armazenar as contas em memória
        static List<Conta> listContas = new List<Conta>();
       
        static void Main(string[] args)
        {            
            string opcaoDoUsuario = obterOpcaoUsuario();

            while (opcaoDoUsuario.ToUpper() != "X")
            {
                switch (opcaoDoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        CriarConta();                        
                        break;
                    case "3":
                        //Transferir();
                        break;
                    case "4":
                        //Sacar();
                        break;
                    case "5":
                        //Depositar();
                        break;
                    case "L":
                        //LimparTela();
                        break;
                    //case "X":
                        //Saindo();
                    //    break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoDoUsuario = obterOpcaoUsuario();
            }
            Console.WriteLine("\n * WWW Global Bank agradece! *");
        }

        private static void CriarConta()
        {   //Recebe os dados do cliente e armazena nas variáveis.
            Console.WriteLine("Criar nova conta");
            Console.WriteLine("Informe o tipo de conta:");
            Console.WriteLine("1 - Pessoa Física");
            Console.WriteLine("2 - Pessoa Jurídica");

            int tipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome completo do cliente:");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial");
            double saldoInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o limite de crédito");
            double limiteCredito = double.Parse(Console.ReadLine());

            //Armazena os dados da conta(das variáveis) no novo objeto novaConta
            Conta novaConta = new Conta(tipoconta: (TipoConta)tipoConta,
                                    nome: nomeCliente,
                                    saldo: saldoInicial,
                                    credito: limiteCredito);

            //Adiciona/armazena os dados/atributos do objeto novaConta na lista listContas
            listContas.Add(novaConta);
                     
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listando contas");

            if (listContas.Count == 0)
            {
                Console.WriteLine("Não existe conta cadastrada");
                return;
            }
            //Lê a lista de contas listContas e mostra as contas cadastradas por indice.
            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.WriteLine("\n#{0} - ", i);
                Console.WriteLine("{0}\n", conta);
            }
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("     * WWW Global Bank *");
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("Venha fazer parte da globalização e do Metaverso!!!");
            Console.WriteLine();
            Console.WriteLine("Informe uma das opção para proseguir:");
            Console.WriteLine();

            Console.WriteLine("1 - Listar contas.");
            Console.WriteLine("2 - Criar nova conta.");
            Console.WriteLine("3 - Fazer transferência.");
            Console.WriteLine("4 - Efetuar saque.");
            Console.WriteLine("5 - Fazer depósito.");
            Console.WriteLine("L - Limpar tela.");
            Console.WriteLine("X - Sair.");
            Console.WriteLine();

            string opcaoDoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine(opcaoDoUsuario);
            return opcaoDoUsuario;
        }
    }
}