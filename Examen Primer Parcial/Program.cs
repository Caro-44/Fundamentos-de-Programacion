//Examen Ejercicio 8:
//Sistema de Crafting

//ANÁLISIS DE PROBLEMA

//PROBLEMA: En un videojuego de supervivencia, el jugador puede fabricar un objeto si cuenta con todos los materiales
//necesarios para completar una receta.

//OBJETIVO: Generar un programa que solicite tres materiales con una cantidad necesaria para fabricar el objeto.
//En caso de no contar con los requisitos necesarios, mostrar un mensaje que le haga saber al usuario que no puede
//construir el objeto. En caso contrario de si tener los requisitos, mostrar el mensaje que la fabricación fue exitosa.

//ENTRADAS:
// - Cantidad de material 1
// - Cantidad de material 2
// - Cantidad de material 3

//SALIDAS:
//Mensaje de fabricación fallida.
//Unidades faltantes.
//Mensaje de fabricación completada.

//ALGORITMO

// INICIO

// Definir madera
// Definir metal
// Definir piedra
// Solicitar cantidad de madera
// Solicitar cantidad de metal
// Solicitar cantidad de piedra
// Si madera < 30
// ENTONCES
// Mostrar "No se puede completar la fabricación, FALTA: madera."
// SINO
// Si metal < 50
// ENTONCES
// Mostrar "No se puede completar la fabricación, FALTA: metal."
// SINO
// Si piedra < 20
// ENTONCES
// Mostrar "No se puede completar la fabricación, FALTA: piedra."
// SINO
// Mostrar: "La fabricación del martillo fue exitosa."
// FIN SI
// FIN SI
// FIN SI

// FIN
Console.Write("\n");
Console.WriteLine("Fabricación de martillo.");
Console.WriteLine("Requisitos:");
Console.WriteLine("30 o más de madera");
Console.WriteLine("50 o más de metal");
Console.WriteLine("20 o más de piedra");
Console.Write("\n");

Console.WriteLine("Escribe la cantidad de madera que se tiene.");
int  madera;
bool siMadera = int.TryParse(Console.ReadLine(), out madera);
if (siMadera == true)
{
    if (madera >= 30) Console.WriteLine("Escribe la cantidad de metal que se tiene.");
    else
    {
        int maderaResta;
        maderaResta = 30 - madera;


        Console.WriteLine("No se pudo completar la fabricación. FALTA: madera.");
        Console.WriteLine("Unidades faltantes:" + maderaResta);


    }

    int  metal;
    bool siMetal = int.TryParse(Console.ReadLine(), out metal);
    if (siMetal == true)
    {

        if (metal >= 50) Console.WriteLine("Escribe la cantidad de piedra que se tiene.");
        else
        {
            int metalResta;
            metalResta = 50 - metal;


            Console.WriteLine("No se pudo completar la fabricación. FALTA: metal.");
            Console.WriteLine("Unidades faltantes:" + metalResta);

        }

        int  piedra;
        bool siPiedra = int.TryParse(Console.ReadLine(), out piedra);
        if (siPiedra == true)
        {

            if (piedra >= 20) Console.WriteLine("La fabricación del martillo fue exitosa.");
            else
            {
                int piedraResta;
                piedraResta = 20 - piedra;


                Console.WriteLine("No se pudo completar la fabricación. FALTA: piedra.");
                Console.WriteLine("Unidades faltantes:" + piedraResta);

            }

            Console.Write("\n");
        }
        else
        {
            Console.WriteLine("El valor no es válido.");
        }
    }
    else
    {
        Console.WriteLine("El valor no es válido.");
    }
}
else
{
    Console.WriteLine("El valor no es válido.");
}


