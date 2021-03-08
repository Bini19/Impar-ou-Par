using System;

namespace LogicaDeProgramaçãoTeste01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Digite um Número obrigado !!"); //Imprime um valor na tela

            Console.ForegroundColor = ConsoleColor.White; //Altera a cor da fonte

            Console.WriteLine("Teste01");

            Console.ReadKey(); //Aguarda o pressionamento de alguma tecla para continuar

            int NumeroDigitado;

            Console.Write("Insira um número:"); //Exibe a mensagem

            NumeroDigitado = Convert.ToInt32(Console.ReadLine()); //Lê e converte a para int o numero informado

            if (NumeroDigitado % 2 == 0)
            {
                //Numero Par
                Console.WriteLine("Par");
            }
            else
            {
                //Numero Impar
                Console.WriteLine("Impar");

            }
            Console.ReadKey();
        }
    }
}
