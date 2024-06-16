/*
 * Created by SharpDevelop.
 * User: othon
 * Date: 12/06/2024
 * Time: 13:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabalho_Consultoria
{
    struct Paciente
    {
        // Struct para ficha de Cliente
        public string nome;
        public string idade;
        public string cpf;
        public string email;
        public string telefone;
        public string dataCadastro;
        public string ultimaVez;
    }

    class Program
    {
        static Paciente[] clientes = new Paciente[100]; // Array para armazenar os clientes cadastrados
        static int totalClientes = 0; // Contador para o total de clientes cadastrados

        static void Main(string[] args)
        {
            // Tela inicial
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("|                                                 SEJA BEM-VINDO  !!!                                                  |");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);
            Console.Clear();

            // Chamando o Login
            Login();
        }
		static void Login()
		{
		    Console.Clear();
		    Console.WriteLine("================================================= Login  ====================================================");
		
		    Console.Write("Nome: ");
		    string nome = Console.ReadLine();
		
		    Console.Write("Senha: ");
		    string senha = Console.ReadLine();
		
		    if (nome == "Vitor" || nome == "Bianca" || nome == "João")
		    {
		        if (senha == "1234" || senha == "adm123" || senha == "senai2024")
		        {
		            Console.WriteLine("Login bem-sucedido!");
		            Console.Clear();
		            Menu();
		            return;
		        }
		        else
		        {
		            Console.WriteLine("Senha incorreta.");
		        }
		    }
		    else
		    {
		        Console.WriteLine("Nome de usuário não permitido.");
		    }
		
		    Console.Write("Pressione qualquer tecla para continuar . . . ");
		    Console.ReadKey(true);
		}

        static void Menu()
        {
            bool retornando = true;
            while (retornando)
            {
                Console.Clear();
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("|                                                Menu de opções                                                       |");
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("|1 - Cadastrar Cliente                                                                                                |");
                Console.WriteLine("|2 - Registro                                                                                                         |");
                Console.WriteLine("|3 - Sair                                                                                                             |");
                Console.WriteLine("=======================================================================================================================");
                Console.Write("Escolha uma opção: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        CadastrarCliente();
                        break;
                    case "2":
                        MostrarRegistros();
                        break;
                    case "3":
                        retornando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Console.Write("Pressione qualquer tecla para continuar . . . ");
                        Console.ReadKey(true);
                        break;
                }
            }
        }

        static void CadastrarCliente()
        {
            Console.Clear();
            Paciente cliente;

            Console.WriteLine("================================================= Cadastro de Cliente =================================================");

            Console.Write("Nome do Cliente: ");
            cliente.nome = Console.ReadLine();

            Console.Write("Idade: ");
            cliente.idade = Console.ReadLine();

            Console.Write("CPF: ");
            cliente.cpf = Console.ReadLine();

            Console.Write("Email: ");
            cliente.email = Console.ReadLine();

            Console.Write("Telefone: ");
            cliente.telefone = Console.ReadLine();

            cliente.dataCadastro = DateTime.Now.ToString("dd/MM/yyyy");
            cliente.ultimaVez = cliente.dataCadastro; // Inicialmente, a última visita é a mesma do cadastro

            clientes[totalClientes] = cliente; // Adiciona o cliente ao array de clientes
            totalClientes++; // Incrementa o contador de clientes

            Console.WriteLine("Cadastro realizado com sucesso!");
            Console.Write("Pressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);
        }

        static void MostrarRegistros()
        {
            Console.Clear();
            Console.WriteLine("================================================= Registro de Clientes =================================================");
            if (totalClientes == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado ainda.");
            }
            else
            {
                for (int i = 0; i < totalClientes; i++)
                {
                    Console.WriteLine("================================================= Cliente " + (i + 1) + " =================================================");
                    Console.WriteLine("Nome: " + clientes[i].nome);
                    Console.WriteLine("Idade: " + clientes[i].idade);
                    Console.WriteLine("CPF: " + clientes[i].cpf);
                    Console.WriteLine("Email: " + clientes[i].email);
                    Console.WriteLine("Telefone: " + clientes[i].telefone);
                    Console.WriteLine("Vendedor: Vitor");
                    Console.WriteLine("Data de Cadastro: " + clientes[i].dataCadastro);
                    Console.WriteLine("Última vez: " + clientes[i].ultimaVez);
                }
            }
            Console.Write("Pressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);
        }
    }
}

            