using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha(100);
            string opcao;
            bool continua = true;

            while (continua)
            {
                Console.Write("\n DIGITE UM NUMERO OU OPERADOR (X PARA SAIR): ");
                opcao = Console.ReadLine();

                if (opcao == "+")
                {
                    if (!pilha.Vazia() && !pilha.Cheia()) // testa se existe pelo menos um valor na pilha.
                    {
                        int n1 = pilha.Desempilhar(); // desempilha o primeiro valor.                     
                        if (!pilha.Vazia() && !pilha.Cheia()) // testa se existem dois valores na pilha, para realização da operação matemática.
                        {
                            int n2 = pilha.Desempilhar(); // desempilha o segundo valor.
                            pilha.Empilhar(n2 + n1); // empilha o resultado da operação.
                            Console.WriteLine("\n  {0}", n2 + n1); // exibe o resultado da operação.
                        }
                        else
                        {
                            Console.WriteLine(" ERRO! NECESSARIO DOIS VALORES"); // caso !exista pelo menos dois valores na pilha (para realizar a operação), retorna erro.
                        }
                    }
                    else
                    {
                        Console.WriteLine(" ERRO! NECESSARIO DOIS VALORES"); // caso !exista pelo menos um valor na pilha, retorna erro.
                    }
                }
                else if (opcao == "-")
                {
                    if (!pilha.Vazia() && !pilha.Cheia())
                    {
                        int n1 = pilha.Desempilhar();
                        if (!pilha.Vazia() && !pilha.Cheia())
                        {
                            int n2 = pilha.Desempilhar();
                            pilha.Empilhar(n2 - n1);
                            Console.WriteLine("\n  {0}", n2 - n1);
                        }
                        else
                        {
                            Console.WriteLine(" ERRO! NECESSARIO DOIS VALORES");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" ERRO! NECESSARIO DOIS VALORES");
                    }
                }
                else if (opcao == "*")
                {
                    if (!pilha.Vazia() && !pilha.Cheia())
                    {
                        int n1 = pilha.Desempilhar();
                        if (!pilha.Vazia() && !pilha.Cheia())
                        {
                            int n2 = pilha.Desempilhar();
                            pilha.Empilhar(n2 * n1);
                            Console.WriteLine("\n  {0}", n2 * n1);
                        }
                        else
                        {
                            Console.WriteLine(" ERRO! NECESSARIO DOIS VALORES");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" ERRO! NECESSARIO DOIS VALORES");
                    }
                }
                else if (opcao == "/")
                {
                    if (!pilha.Vazia() && !pilha.Cheia())
                    {
                        int n1 = pilha.Desempilhar();
                        if (!pilha.Vazia() && !pilha.Cheia())
                        {
                            int n2 = pilha.Desempilhar();
                            pilha.Empilhar(n2 / n1);
                            Console.WriteLine("\n  {0}", n2 / n1);
                        }
                        else
                        {
                            Console.WriteLine(" ERRO! NECESSARIO DOIS VALORES");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" ERRO! NECESSARIO DOIS VALORES");
                    }
                }
                else if (opcao.ToUpper() == "X")
                {
                    continua = false;
                }
                else
                {
                    pilha.Empilhar(Convert.ToInt32(opcao));
                }
            }
        }
    }
}