// Pide un nombre de usuario y una contraseña. Si el usuario es "admin" y la contraseña "1234", muestra “Acceso permitido”. En caso contrario, muestra el motivo del error (“Contraseña incorrecta” o “Usuario no reconocido”).

using System;
Console.Write("Ingrese el nombre de usuario: ");
string usuario = Console.ReadLine();

Console.Write("Ingrese la contraseña: ");
string contrasena = Console.ReadLine();

if (usuario == "admin")
{
    if (contrasena == "1234")
    {
        Console.WriteLine("Acceso permitido");
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta");
    }
}
else
{
    Console.WriteLine("Usuario no reconocido");
}

