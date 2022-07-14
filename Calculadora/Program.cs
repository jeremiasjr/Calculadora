Retorno:
Calculadora.Class1.Moldura();
Calculadora.Class1.Menu();

int n1, n2, res;

ConsoleKeyInfo cki;
bool contLoop = true;
while (contLoop)
    if (Console.KeyAvailable)
    {
        cki = Console.ReadKey(true);
        switch (cki.Key)
        {
            case ConsoleKey.NumPad1: // Operação de SOMA
                {
                    Console.Clear();
                    Calculadora.Class1.Moldura();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(1, 1);
                    Console.WriteLine("          SOMA          ");
                    Console.SetCursorPosition(1, 3);
                    Console.Write("PRIMEIRO NUMERO: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(1, 5);
                    Console.Write("SEGUNDO NUMERO: ");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    res = n1 + n2;
                    Console.SetCursorPosition(1, 7);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"RESULTADO = {res}");
                    goto continua;
                }
            case ConsoleKey.NumPad2: // Operação de SUBTRAÇÃO
                {
                    Console.Clear();
                    Calculadora.Class1.Moldura();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(1, 1);
                    Console.WriteLine("        SUBTRAÇÃO       ");
                    Console.SetCursorPosition(1, 3);
                    Console.Write("PRIMEIRO NUMERO: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(1, 5);
                    Console.Write("SEGUNDO NUMERO: ");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    res = n1 - n2;
                    Console.SetCursorPosition(1, 7);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"RESULTADO = {res}");
                    goto continua;
                }
            case ConsoleKey.NumPad3: // Opoeração de MULTIPLICAÇÃO
                {
                    Console.Clear();
                    Calculadora.Class1.Moldura();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(1, 1);
                    Console.WriteLine("      MULTIPLICAÇÃO     ");
                    Console.SetCursorPosition(1, 3);
                    Console.Write("PRIMEIRO NUMERO: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(1, 5);
                    Console.Write("SEGUNDO NUMERO: ");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    res = n1 * n2;
                    Console.SetCursorPosition(1, 7);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"RESULTADO = {res}");
                    goto continua;
                }
            case ConsoleKey.NumPad4: //Operação de DIVISÃO
                {
                    Console.Clear();
                    Calculadora.Class1.Moldura();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(1, 1);
                    Console.WriteLine("        DIVISÃO        ");
                    Console.SetCursorPosition(1, 3);
                    Console.Write("PRIMEIRO NUMERO: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(1, 5);
                    Console.Write("SEGUNDO NUMERO: ");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    res = n1 / n2;
                    Console.SetCursorPosition(1, 7);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"RESULTADO = {res}");
                    goto continua;
                }
            case ConsoleKey.NumPad5: //SAI DO PROGRAMA
                {
                    Environment.Exit(0);
                    break;
                }
        }
    }
continua:  
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(1, 9);
Console.Write("Voltar ao Menu? (S/N)");

//consulta de teclas nesse caso para (S/N)
ConsoleKeyInfo cke;
bool continuarLoop = true;
        while (continuarLoop)
            if (Console.KeyAvailable)
            {
                cke = Console.ReadKey(true);
                switch (cke.Key)
                {
                    case ConsoleKey.S:
                        Console.Clear();
                        goto Retorno;
                    case ConsoleKey.N:
                        continuarLoop = false;
                        Environment.Exit(0);
                        break;
                }
            }