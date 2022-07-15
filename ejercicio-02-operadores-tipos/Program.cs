/*
Enunciado del ejercicio:

Ejercicio 1
Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.

Ejercicio 2
Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

Coche: puertas, ruedas, marca, ITV vigente

Mesa: peso, largo, material, color

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.

Ejercicio 3
Operadores Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/

// ejercicio 2
Console.WriteLine("Ingrese su nombre:");
string name = Console.ReadLine();
Console.WriteLine("Ingrese su apellido:");
string lastName = Console.ReadLine();
Console.WriteLine("Ingrese su edad:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Sabe programar?:");
string developer = Console.ReadLine();

Console.WriteLine("Su nombre es " + name + " " + lastName + ", tiene " + age + " y " + developer + " programa.");

// ejercicio 2
// Coche
int puertas = 4;
int ruedas = 4;
string marca = "Toyota";
Boolean itvVigente = false;

// mesa
float peso = 5.45f;
float largo = 5.32f;
string material = "madera";
string color = "caoba";

// ejercicio 3
int num1 = 18;
int num2 = 10;
Boolean comparacion = num1 >= num2;

char value = 'a';

Boolean comp1 = 4 == 4 && value == 'a';
Boolean comp2 = num1 < 0 && num2 < 2;