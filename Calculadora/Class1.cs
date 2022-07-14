using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Class1
    {
        public static void Moldura()
        {
            //Moldura da tela
            int i, j;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ");
            for (i = 0; i < 25; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");

            for (j = 0; j < 11; j++)
            {
                Console.Write("|");
                for (i = 0; i < 25; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }

            Console.Write(" ");
            for (i = 0; i < 25; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }
        public static void Menu()

        {
            //Menu
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(1, 1);
            Console.Write(" CALCULADORA DE JEREMIAS");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine("Menu");

            Console.SetCursorPosition(1, 4);
            Console.WriteLine("1 - SOMA");

            Console.SetCursorPosition(1, 5);
            Console.WriteLine("2 - SUBTRAÇÃO");

            Console.SetCursorPosition(1, 6);
            Console.WriteLine("3 - MULTIPLICAÇÃO");

            Console.SetCursorPosition(1, 7);
            Console.WriteLine("4 - DIVISÃO");

            Console.SetCursorPosition(1, 8);
            Console.WriteLine("5 - SAIR");
            Console.SetCursorPosition(1, 9);
        }
    }
}
