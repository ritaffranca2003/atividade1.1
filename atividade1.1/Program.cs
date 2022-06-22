using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1._1
{
    class Program
    {
        static void Main(string[] args)

        {
            string texto; // Declaração de variavel.
            //texto = "Olá mundo ";  // comando que atribue um valor na variavel.

            //Console.Write("Digite o seu nome: "); // comando de saida, mostra o texto "Digite o seu nome: ".
            //texto = texto + Console.ReadLine(); // variavel texto armazena o valor existente e junta o valor digitado
            //                                    //recebido pelo comando de entrada (Console.ReadLine()).

            Console.WriteLine("Digite um numero: "); // Comando de saida mostra "Digite um numero:"
            texto = Console.ReadLine(); // Valor Digitado recebido pelo de entrada e atribuido a variavel texto
            Console.WriteLine("Digite ouitro numero: "); // Comando de saida mostra "Digite outro numero:"
            texto = texto + Console.ReadLine(); // variavel texto armazena um valor existente e junta o valor digitado

            Console.Write(texto); //escreve na tela o valor do textoLength, comando Console.WriteLine é de saida.

            Console.ReadKey(); // comando de entrada, espera uma tecla ser clicada para fechar.
        }
    }
}
