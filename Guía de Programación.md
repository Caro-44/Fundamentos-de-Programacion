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

-----------

## Colores

La consola utiliza colores por defecto, por lo general suelen ser:
- **Blanco**
- **Negro**

No obstante, es posible configurar la consola para mostrar 
otros colores, haciendo uso de los siguientes métodos:

- `Console.ForegroundColor`: Permite asignar un color al texto.
- `Console.BackgroundColor: Permite agregar un color al fondo.

Es importante regresar los colores a los valores por defecto
una vez que se haya terminado:

- `Console.ResetColor()`: Regresa los colores a los valores por defecto. 

***Existen 16 colores por defecto.***

-------------

## Variables y Tipos de Dato

Las variables son fundamentales para la construcción de programas.
**Se utilizan para almacenar y manipular datos.**
Almacenan números, textos y valores lógicos.

### Variables
Es un contenedor de información con un tipo de dato, un identificador
y un valor que puede cambiar durante el programa.

### Constante
Contenedor de información con un tipo de dato, un identificador
y un valor que **no puede cambiarse** una vez asignado.

--------------------------

## Tipos de datos

Es un tipo de información que puede guardar una variable y
que no puede ser cambiado una vez haya sido asignado.

- Enteros
- Decimales
- Textos
- Estructuras de datos
- Objetos
- Textos (cadenas)
- Booleanos

### Tipos numéricos:
Almacenan valores numéricos.
Dependiendo del tipo de dato pueden ser decimales o no. 
Tienen un límite mínimo y máximo de valor que pueden guardar.
Pueden o no tener signo y su valor por defecto es 0.

***Existen 10 tipos de enteros***
- `sbyte`: (-128 a 127) **8 bits de tamaño.**
- `byte`: (0 a 255) **8 bits de tamaño.**
- `short`: (-32,768 a 32,767) **16 bits de tamaño.**
- `ushort`: (0 a 65,535) **16 bits de tamaño.**
- `int`: **32 bits de tamaño.**
- `uint`: **32 bits de tamaño.**
- `long`: **64 bits de tamaño**
- `ulong`: **64 bits de tamaño**
- `nint`: (Depende de la plataforma) **32 bits o 64 bits de tamaño**
- `unint`: (Depende de la plataforma) **32 bits o 64 bits de tamaño**

### Existen 3 tipos de decimales

- `float`: 4 bytes de tamaño.
- `double`: 8 bytes de tamaño.
- `decimal`: 16 bytes de tamaño.

***Es posible utilizar `_` para separar números.***

***Es posible utilizar notación científica para facilitar
la lectura, como `e`o `E`.***

Los tipos numéricos que se usan principalmente en videojuegos
son `int` & `float`

### Números enteros: `int`
- Utiliza números enteros donde sea posible. 
- No requiere subfijos.
- Se utiliza para: 
1. Recursos
2. Vida de personajes
3. Edades
4. Puntajes

### Números decimales: `float`

- Utilizado para valores que **deban** contener decimales
- Considerar posibiles errores
- Utilizar sufijos `f` o `F`
- Se utiliza para:
1. Coordenadas
2. Distancias
3. Medidas
4. Bonus
5. Hit chance

---------------

## Tipos Booleanos

Las variables de tipo `bool` pueden almacenar uno de dos
posibles valores:
- `true`
- `false`

Se les conoce también como banderas o *flags*.

---------------

## Tipos texto
Existen dos tipos de dato que pueden almacenar texto:
1. Cadenas
2. Caracteres

### Cadenas
Tipo de dato: `string`.

**Características:**
- Encerrado por: *Comillas dobles* `" "`
- Capacidad: *Aproximadamente 2GB*
- Valor por defecto: `null` (Sin valor)

### Caracteres
Tipo de dato: `char`

**Características:**
- Encerrado por: *Comillas simples* ` '' `
- Capacidad: *Un carácter.*
- Valor por defecto: `/0`

--------------

## Identificador (Nombre)

Una variable debe ener un nombre único e irrepetible en el
bloque en el que existe.

### Reglas
1. Inicia con una letra o un guión bajo
2. No debe contener espacio
3. Puede contener cualquiera de:
- Números
- Letras
- Guión bajo.

### Convenciones
1. Utiliza nombres descriptivos
2. Utiliza solo el alfabeto inglés. *Sin ñ, acentos, etc.*
3. Prefiere el ingles sobre el español. *No tiene ñ, acentos, etc.*

Varianles: utilizaCamelCase
Constantes: UTILIZA_UPPER_CASE

----------------

## Valores

El valor se refiere a la información específica que guarda
una variable. Es posible asignar diferentes valores
dependiendo de su tipo de dato. 

----------------

## Declarar y asignar Variables y Constantes

### Variable
Guarda un valor que puede o no cambiar.

Requiere:
- Tipo de dato
- Identificador
- *Puede o no tener valor inicial*

### Constante
Guarda un valor que **NO** puede cambiar

Requiere:
- Palabra reservada `const`
- Tipo de dato
- Nombre
- Valor definido desde el inicio

## Declaración y Asignación

### Declaración
Antes de guardar un valor es necesario declarar la variable.
Consta de 2 elementos clave:
1. Tipo de dato
2. Identificador

### Asignación
Antes de utilizar una variable, es necesario asignarle un
valor válido.
Consta de 3 elementos clave:
1. Identificador
2. Signo de igual
3. Valor

### Declaración + Asignación
Utiliza los elementos de la declaración y asignación
- Identificador
- Signo de igual
- Valor

***Es la única forma de declarar CONSTANTES (`const`)***

-------------

## Tipo de dato implícito

### Tipos de datos

C# es un lenguaje de "tipado fuerte", lo que signfica que
una variable puede ser de **un y solo un** tipo de dato.
Esto permite obtener el tipo de dato a partir del valor.

Esta caracteristica permite inferir el tipo de dato
según el valor.
Se utiliza la palabra `var` reemplazado al tipo de dato.

Esto aplica para las **variables**, las **constantes**
requiere de un tipo explícito.

### Obteniendo el tipo de dato
Es posible obtener el tipo de dato de una variable o constante
utilizando `getType()` en la variable o constante.

- `variable.getType()`
- `constante.getType()`

**IMPORTANTE:** El valor regresado por es diferente al escrito
en el programa.

- `byte`=> `System.Byte`
- `int` => `System.Int32`
- `float` => `System.Single`

----------------------------

## Operaciones

### Operaciones aritméticas

- Se aplican a los tipos de valores númericos.
- Los resultados siempre son valores númericos.
- El resultado *casi siempre* es del tipo de dato con mayor precisión.

**EJEMPLOS:**

1. Suma: + 
2. Resta: -
3. Multiplicación: *
4. División Entera: /
5. División (Real): /
6. Resto o Módulo: %

### División entera vs División

### Entera
Aplica para tipos de datos enteros.
- No resulta en decimales
- La división entre 0 lanza un error.

### Lógicos
Aplica para cuando algunos de los números es decimal.
- Siempre resulta en un tipo decimal
- La división entre 0 resulta en ∞

**MÁS EJEMPLOS DE OPERACIONES:**

- Adición Unaria (Prefijo): ++ (Suma antes que cualquier acción.) ***++num***
- Resta Unaria (Prefijo): -- (Resta antes de cualquier acción.) ***--num***
- Adición Unaria (Sufijo): ++ (Suma después que cualquier acción.) ***num++***
- Resta Unaria (Sufijo): -- (Resta después de cualquier acción.) ***num--***
- Unary Plus + (Equivalente a multiplicar por +1) ***+(-num)***
- Unary Negative - (Equivalente a multiplicar por -1) ***-(-9)***

### Jerarquía de Operaciones

### Operaciones generales

- **Agrupación:** ()
- **Urany Negative:** -
- **Multiplicación y División:** * y /
- **Resto y Módulo:** %
- **Suma y Resta:** + y -

### Suma y resta unaria

- **Adición Unaria (Prefijo):** ++
- **Resta Unaria (Prefijo):** --
- **Adición Unaria (Sufijo):** ++
- **Resta Unaria (Sufijo):** --

------------

## Operaciones relacionales y lógicas
Permiten comparar operaciones para obtener un resultado 
verdadero o falso.
Es posible unir más de una condición para obtener un resultado.
El resultado siempre es `bool`

### Operaciones relacionales

- Igualdad: == (Determina si dos valores son iguales.)
- Diferente: != (Determina si dos valores son diferentes.)
- Mayor que: > (Determina si un valor es mayor que otro.)
- Menor que: < (Determina si un valor es menor que otro.)
- Mayor o igual que: >= (Determina si un valor es mayor o igual a otro.)
- Menor o igual que: <= (Determina si un valor es menor o igual a otro.)

### Operadores Lógicos

- AND: && (`true`, si **ambos** valores son `true`.) 
- OR: || (`true`, si **cualquier** valor es `true`.)
- NOT: ! (Se convierte el valor en su **opuesto* `true` ⟷ `false`.)

Para que un *AND* resulte verdadero, **todas** las condiciones
deben ser **verdaderas**.

Para que un *OR* resulte verdadero, **cualquiera** de las condiciones
deben ser **verdaderas**.

UN *NOT* cambia de valor de la operación al valor opuesto.

### Jerarquía de Operaciones

### Relacionales

- Relacionales (<, >, >=, <=)
- Igualdad (==, !=)

### Lógicos

- NOT (!)
- AND (&&)
- OR (||)

Un operador relacional compara dos operandos y devuele un
valor `bool`.

Los operadores AND (&&) y OR || evalúan dos expresiones booleanas
y devuelven un valor `bool`.

El operador NOT (!) requiere un único operando booleano.

----------

## Consola

Permite mostrar y leer información.
Las entradas y salidas son la base de cualquier programa.

Se utiliza `Console.XXXX` donde `XXXX` indica la acción
o propiedad.

### Leyendo información

### `Console.ReadLine ()`
Permite obtener cualquier tecla que presione el usuario.
Regresa un `ConsoleKeyInfo`, con la información de la tecla presionada.

- `KeyChar`: La "impresión" de la tecla.
- `Modifiers`: Modificadores como `Shift` o `Ctrl`.

Depende del programador determinar cuándo termina la entarada.
Usar `ctrl+z`, `f6` o similar.

***Se utiliza para las entradas de texto.***

Esta funcionalidad está limitada, siempre se obtiene un `string`
(Aunque el usuario escriba 25, se leerá como texto, NO como entero.)

### `ConsoleReadKey()`
Permite leer las teclas que presiona el usuario.
Posible ocultar las teclas en la consola.

- `Console.ReadKey()`
- `Console.ReadKey(true)`

Termina cuando recibe una instrucción de salida: `ctrl+z`, `f6` o similar.

***Se utiliza para teclas individuales y lecturas en tiempo real.***

### `ConsoleRead`

Permite leer la información de la consola de forma indefinida,
caracter por caracter. Regresa a un entero, representando la entrada.

- Lee hasta que se encuentra con un "Enter" y continua.
- Se puede utilizar `LF (10)` junto con `CR (13)` para determinar que el usuario presiona "Enter."
- Regresa `-1` cuando encuentra una instrucción de salida `ctrl+z`, `f6` o similar.

***Se utiliza al leer el stream de un texto. Principalmente para archivos, red o similar.***

-------------------

## Conversiones entre tipos de dato

**EXISTEN TRES TIPOS DE CONVERSIONES:**

### Implícita

La conversión se realiza de forma automática.
No se necesita escribir ninguna instrucción adicional.

***C# "sabe" realizar la conversión.***

### Explícita

Es necesario indicar que se requiere realizar la conversión.

Se utiliza la sintaxis:
`(int) valor/variable`

Donde:
- (`int`): Es un nuevo tipo de dato.
- (`valor/variable`): El valor o variable a convertir.

**NOTA:** Es posible que se pierda la información al realizar la conversión.

### Parse (De Cadena a Número)

No es posible realizar un cast directo de cadena a número. Para
realizar la conversión, es necesario *interpretar* el valor que se tiene.

### `Parse("STR")`
Convierte el valor de la cadena a un entero.
Intenta realizar la conversión, lanza error si no es posible.

Es necesario indicar que se requiere hacer la conversión, con la siguiente
sintaxis:
`tipo.Parse(str)`

Si no es válido el valor numérico, se genera una excepción.

### `TryParse("STR", out tipo valor)`
Convierte el valor de la cadena a un número.
Intenta realiar la conversión e indica si fue posible.

Es necesario indiciar que se requiere hacer la conversión, con la siguiente
sintaxis:
`tipo.TryParse(str, val);`

Regresa dos elementos:

1. Si se pudo realizar la conversión.
2. El valor convertido si se convirtió y 0 si no. 

--------------

## Condicionales

### Flujo secuencial

Un programa se ejecuta de izquierda a derecha, de arriba a abajo.
Un programa real necesita tomar decisiones y repetir procesos.

**Las condicionales permiten tomar una decisión.**

### `ìf`
Permite ejecutar un bloque de código solamente cuando
la condición es verdadera. 

### `if-else`
Permite ejecutar un bloque de código solamente cuando
una condición es verdadera o falsa.

### `if - elseif- else`
Permite evaluar diferentes condiciones y ejecutar el primer
bloque si es verdadero.

El orden importa:
- Una vez que encuentra una condición verdadera, ejecura el código e ignora todos los demás.
- Se deja de revisar las demás condiciones.

### If independientes Vs else if

### *Independientes*
Pueden ejecutarse varios bloques.

### *else if*
Se ejecuta el primer bloque verdadero.

### Condicionales anidadas

### *Anidación*
Es posible incluir cualquier sentencia dentro de un if, incluso otros
ifs. 

### *Combinación*
Si una condición depende de otra, por lo general es más 
claro combinarlas.

### `switch`
Permite seleccionar una acción entre múltiples alternativas
concretas de un mismo valor.

- `case`: Un posible valor.
- `break`: Termina el caso.
- `default`: Ningún caso coincide.

Es posible combinar casos. Si alguno de los valores coincide,
se ejecuta el código.

### If vs Switch

### *Se utiliza if cuando:*
- La combinación usa rangos.
- Se combinan varias variables.
- La lógica es compleja.

### *Se utiliza switch cuando:*
- Un valor tiene opciones concretas.
- Ejemplos: Menú

-----------------

## Flujo breve para analizar y resolver problemas

1. Analizar el problema
2. Escribir un algoritmo para ello (paso a paso para su resolución).
3. Probar algoritmo
4. Corregir si es necesario.

---------------

## Referencia breve para "Debugging" 

### ¿Qué hacer si mi programa no funciona?

1. Leer el mensaje de error de la consola.
2. Seleccionar error
3. Leer posibles soluciones
4. Aplicar la más viable según lo que se quiera lograr
5. Probar código nuevo.