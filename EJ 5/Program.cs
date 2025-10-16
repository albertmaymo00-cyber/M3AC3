

using System;

int año;

Console.Write("Introduce un año ");
año = Convert.ToInt32(Console.ReadLine());

string resultado = (año % 400 == 0) ? "El año es bisiesto" : "El año no es bisiesto";

Console.WriteLine(resultado);
