using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Exercicio1
            {

                Console.WriteLine("Digite um número inteiro: ");

                int num = int.Parse(Console.ReadLine());


                for (int i = 1; i <= num; i++)
                {

                    Console.Write(i + " ");

                }
                Console.ReadLine();

            }

            //Exercicio2

            {
                Console.WriteLine("Digite um número inteiro: ");
                int num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.ReadLine();
            }

            //Exercicio3

            {
                {
                    Console.WriteLine("Digite um número inteiro menor que 1000: ");
                    int num = int.Parse(Console.ReadLine());

                    if (num >= 1000)
                    {
                        Console.WriteLine("O número digitado é maior ou igual a 1000. Tente novamente.");
                        return;
                    }

                    for (int i = 1000; i <= num; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }

                    Console.ReadLine();
                }
            }

            //Exercicio4

            {
                {
                    int somaPositivos = 0;

                    while (somaPositivos < 200)
                    {
                        Console.WriteLine("Digite um número inteiro: ");
                        int num = int.Parse(Console.ReadLine());

                        if (num > 0)
                        {
                            Console.WriteLine("Número positivo: " + num);
                            somaPositivos += num;
                        }
                    }

                    Console.WriteLine("Soma dos números positivos: " + somaPositivos);
                    Console.ReadLine();
                }
            }

            //Exercico5

            {
                {
                    Console.WriteLine("Digite um número inteiro: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Divisores de " + num + ":");
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }

                    Console.ReadLine();
                }
            }

            //Exercicio6
            
            {
                {
                    int[] numeros = new int[10];
                    int maior = int.MinValue;
                    int menor = int.MaxValue;

                    for (int i = 0; i < numeros.Length; i++)
                    {
                        Console.WriteLine("Digite um número inteiro: ");
                        numeros[i] = int.Parse(Console.ReadLine());

                        if (numeros[i] > maior)
                        {
                            maior = numeros[i];
                        }

                        if (numeros[i] < menor)
                        {
                            menor = numeros[i];
                        }
                    }

                    Console.WriteLine("Maior número digitado: " + maior);
                    Console.WriteLine("Menor número digitado: " + menor);
                    Console.ReadLine();
                }
            }

            //Exercicio7

            {
                {
                    int n = 0;
                    int somaImpares = 0;
                    int numPares = 0;

                    while (numPares < n)
                    {
                        Console.WriteLine("Digite um número inteiro: ");
                        int num = int.Parse(Console.ReadLine());

                        if (num % 2 == 0)
                        {
                            numPares++;
                        }
                        else
                        {
                            somaImpares += num;
                        }
                    }

                    Console.WriteLine("Você informou " + numPares + " números pares e a soma dos ímpares é: " + somaImpares);
                    Console.ReadLine();
                }
            }
        }
    }
}
