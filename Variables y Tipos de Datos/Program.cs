// See https://aka.ms/new-console-template for more information

// Ejemplo: Obtener y mostrar los valores mínimos y máximos de un tipo de dato.

sbyte minValorSbyte = SByte.MinValue;
sbyte maxValorSbyte = SByte.MaxValue;

Console.WriteLine("SByte");
Console.WriteLine("Mínimo: " + minValorSbyte);
Console.WriteLine("Máximo: " + maxValorSbyte);

// Símbolo de suma: +
// Símbolo de resta: -
// Símbolo de multiplicación: *
// Símbolo de división: /

Console.WriteLine ("\n");
//Ejercicio: Utilizar dos tipos de datos diferentes al anterior
// Uno entero y otro decimal, y mostrar sus valores máximos y mínimos
// 1. Mostrar los valores min y max.
// 2. Multiplicar el valor máximo por 10 y mostrar resultados.
// 3. Multiplicar el valor minimo por 10 y mostrar resultados.

// sbyte, byte, short, ushort, int, uint, long, ulong
// float, double, decimal

byte minValorByte = Byte.MinValue;
byte maxValorByte = Byte.MaxValue;

Console.WriteLine("Byte:");
Console.WriteLine("Minimo: " + minValorByte);
Console.WriteLine("Valor minimo * 10 = " + minValorByte * 10);
Console.WriteLine("Maximo: " + maxValorByte);
Console.WriteLine("Valor maximo * 10 = " + maxValorByte * 10);

Console.WriteLine("\n");
float minValorfloat = float.MinValue;
float maxValorfloat = float.MaxValue;

Console.WriteLine("Float:");
Console.WriteLine("Minimo: " + minValorfloat);
Console.WriteLine("Valor minimo * 10 = " + minValorfloat * 10);
Console.WriteLine("Maximo: " + maxValorfloat);
Console.WriteLine("Valor maximo * 10 = " + maxValorfloat * 10);
