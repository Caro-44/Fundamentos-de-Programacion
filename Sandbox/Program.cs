// See https://aka.ms/new-console-template for more information

Console.WriteLine("¡Hola, Carolina!");
Console.WriteLine("¡Hola, Carolina!");
Console.WriteLine("¡Hola, Carolina!");

Console.Write("¡Hola ");
Console.Write("Carolina");
Console.Write("!");

Console.Write("\n\n\n");
// Generar un programa que muestre atributos en tabla con borde
Console.Write("Estadísticas en forma de tabla");
Console.Write("\n\n");

Console.WriteLine("/ Greg \"El Mago\" /");
Console.WriteLine("\\----------------\\");
Console.WriteLine("/ HP\t100      /");
Console.WriteLine("\\ MP\t50       \\");
Console.WriteLine("/ Gold\t1,500    /");
Console.WriteLine("\\ Exp\t200      \\");

Console.Write("\n\n\n");
// Bandera de México con color
Console.WriteLine("Bandera de México");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("ME");
Console.ForegroundColor = ConsoleColor.White;
Console.Write("XI");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("CO");

Console.ResetColor();
Console.WriteLine();

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Black;
Console.Write("ME");
Console.BackgroundColor = ConsoleColor.White;
Console.Write("XI");
Console.BackgroundColor = ConsoleColor.Red;
Console.Write("CO");

Console.ResetColor();
