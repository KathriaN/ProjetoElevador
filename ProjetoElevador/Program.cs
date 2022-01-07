using System;
using ProjetoElevador.Model;

namespace ProjetoElevador
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SEJA BEM VINDO A APLICAÇÃO ELEVADOR!\n");
            
            //Instância da classe Elevador

            Elevador elevador = new Elevador();
            
            //Chamada do método inicializar
            elevador.Inicializar();

            //Variável que define a continuação da aplicação
            bool continuar = true;
            
            do
            {
                //Menu de Opções do Elevador
                Console.WriteLine(@"    O que deseja fazer?
                                    1 - Adicionar uma pessoa no elevador.
                                    2 - Remover uma pessoa no elevador.
                                    3 - Subir um andar.
                                    4 - Descer um andar.
                                    5 - Sair da Aplicação.

                                    ");
                string escolha = Console.ReadLine();
                Console.Clear();

                //Verificação da escolha do usuário
                switch (escolha)
                {
                    case "1":
                        {
                            Console.WriteLine("\nVocê escolheu adicionar uma pessoa no elevador.\n");
                            elevador.Entrar();
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("\nVocê escolheu retirar uma pessoa no elevador.\n");
                            elevador.Sair();
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("\nVocê escolheu subir um andar no prédio.\n");
                            elevador.Subir();
                        }
                        break;
                    case "4":
                        {
                            Console.WriteLine("\nVocê escolheu descer um andar no prédio.\n");
                            elevador.Descer();
                        }
                        break;
                    case "5":
                        {
                            Console.WriteLine("\nVocê escolheu sair da aplicação.\n");
                            continuar = false;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("OPÇÃO INVÁLIDA!\n");
                        }
                        break;
                }
            }
            while (continuar == true);

        }
    }
}
