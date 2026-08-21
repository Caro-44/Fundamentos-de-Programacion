# Guía de Programación

## Console.Write y Console.WriteLine

Ambos son métodos de lenguajes como C#, los cuales
sirven para mostrar un texto en la pantalla de la consola.
La diferencia principal entre ambos es que, mientras 
"Console.Write" deja el cursor en la misma línea, 
"Console.WriteLine" añade un salto de línea al terminar
de imprimir.

Un ejemplo sería:

```csharp
Console.WriteLine("¡Hola, Carolina!");
Console.WriteLine("¡Hola, Carolina!");
Console.WriteLine("¡Hola, Carolina!"); 
```

U otro ejemplo:

```csharp
Console.Write("Hola");
Console.Write("Carolina");
Console.Write("!");
```

---------

## Secuencias de Escape

Dentro de una cadena, es posible hacer que en tanto los comandos
"Console.Write" como "Console.WriteLine", se muestren
caracteres que de otra forma no son posibles.

Existen múltiples secuencias de escape, todas inician con: `\`

Las secuencias más comunes son:
 
- `\n` (Salto de Linea): Agrega un salto de línea ("Enter") al texto.
- `\t` (Tabulación): Permite alinear bloques de texto en columnas.
- `\"` (Comillas Dobles): Si se quiere insertar una `"`, es necesario agregar una `\` antes para distinguirla del inicio y fin.
- `\\` ( Barra Invertida): La `\` es el carácter inicial de todas las secuencias y se utiliza para "escapar", quedando como `\\` cuando se quiere mostrar.

