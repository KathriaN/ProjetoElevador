using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador
    {
        public int qtdAndares, capElevador, qtdEspacos = 0, qtdPessoas = 0, andarAtual = 0;

        public void Inicializar()
        {
            do
            {
                Console.WriteLine("Informe a quantidade de andares no prédio:");
                qtdAndares = int.Parse(Console.ReadLine());

                // TRATAMENTO DE ENTRADA DE VALOR INVÁLIDO
                if (qtdAndares <= 0)
                {
                    Console.WriteLine("\nQUANTIDADE DE ANDARES INVÁLIDA! Informe um número inteiro positivo!\n");
                }
            }
            while (qtdAndares <= 0);
            do
            {
                Console.WriteLine("\nInforme a capacidade máxima do elevador:");
                capElevador = int.Parse(Console.ReadLine());

                // TRATAMENTO DE ENTRADA DE VALOR INVÁLIDO
                if (capElevador <= 0)
                {
                    Console.WriteLine("\nCAPACIDADE INVÁLIDA! Informe um número inteiro positivo!");
                }
            }
            while (capElevador <= 0);
            Console.WriteLine("\nO ELEVADOR INICIA VAZIO NO TÉRREO!\n");
        }

        public void Entrar()
        {
            int qtdEspacos = capElevador - qtdPessoas;

            if (qtdEspacos == 0) // VERIFICAR SE HÁ ESPAÇO NO ELEVADOR
            {
                Console.WriteLine("\nNÃO HÁ ESPAÇO NO ELEVADOR! ELEVADOR CHEIO!\n");
            }
            else
            {
                qtdPessoas += 1; // INCREMENTAR O NÚMERO DE PESSOAS NO ELEVADOR

                Console.WriteLine("\nA quantidade atual de pessoas no elevador é: {0}", qtdPessoas);

                //VERIFICAR EM QUAL ANDAR ESTÁ O ELEVADOR
                if (andarAtual == 0)
                {
                    Console.WriteLine("O elevador está no térreo.\n");
                }
                else
                {
                    Console.WriteLine("O elevador está no {0}º Andar.\n", andarAtual);
                }
            }
        }

        public void Sair()
        {
            if (qtdPessoas == 0) // VERIFICAR SE HÁ PESSOAS NO ELEVADOR
            {
                Console.WriteLine("\nNÃO HÁ MAIS PESSOAS NO ELEVADOR! ELEVADOR VAZIO!\n");
            }
            else
            {
                qtdPessoas -= 1; // DECREMENTAR O NÚMERO DE PESSOAS NO ELEVADOR

                Console.WriteLine("\nA quantidade atual de pessoas no elevador é: {0}", qtdPessoas);

                //VERIFICAR EM QUAL ANDAR ESTÁ O ELEVADOR
                if (andarAtual == 0)
                {
                    Console.WriteLine("O elevador está no térreo.\n");
                }
                else
                {
                    Console.WriteLine("O elevador está no {0}º Andar.\n", andarAtual);
                }
            }
        }

        public void Subir()
        {
            if (andarAtual == qtdAndares) // VERIFICAR SE O ELEVADOR ESTÁ NO ULTIMO ANDAR
            {
                Console.WriteLine("\nNÃO É POSSÍVEL MAIS SUBIR! JÁ ESTÁ NO ÚLTIMO ANDAR!\n");
            }
            else
            {
                andarAtual += 1; // SUBIR O ELEVADOR EM UM ANDAR

                Console.WriteLine("\nA quantidade atual de pessoas no elevador é: {0}", qtdPessoas);

                //VERIFICAR EM QUAL ANDAR ESTÁ O ELEVADOR
                if (andarAtual == 0)
                {
                    Console.WriteLine("O elevador está no térreo.\n");
                }
                else
                {
                    Console.WriteLine("O elevador está no {0}º Andar.\n", andarAtual);
                }
            }
        }

        public void Descer()
        {
            if (andarAtual == 0) // VERIFICAR SE O ELEVADOR ESTÁ NO TÉRREO
            {
                Console.WriteLine("\nNÃO É POSSÍVEL MAIS DESCER! JÁ ESTÁ NO TÉRREO!\n");
            }
            else
            {
                andarAtual -= 1; // DESCER O ELEVADOR EM UM ANDAR
                Console.WriteLine("\nA quantidade atual de pessoas no elevador é: {0}", qtdPessoas);

                //VERIFICAR EM QUAL ANDAR ESTÁ O ELEVADOR
                if (andarAtual == 0)
                {
                    Console.WriteLine("O elevador está no térreo.\n");
                }
                else
                {
                    Console.WriteLine("O elevador está no {0}º Andar.\n", andarAtual);
                }
            }
        }
    }
}
