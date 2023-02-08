//escribir un programa que haga lo siguiente:

//1) borrar la pantalla.
//2) pedir el nombre de una persona.
//3) saludarlo con un texto que diga "¡hola [nombreingresado]!"
//4) preguntar si se quiere continuar.
//5) si la respuesta es "s" repetir desde el punto 1.
//6) si la respuesta es "n" finalizar el programa mostrando un mensaje que diga "programa finalizado correctamente".
//7) si la respuesta no es ni "s" ni "n" que tambien finalice el programa, pero mostrando un mensaje que diga "opcion no valida".

string respuesta = "S";

while (respuesta.ToUpper() == "S") {
    Console.Clear();

    Console.WriteLine("Buenas! Ingrese su nombre");
    var nombreIngresado = Console.ReadLine();

    Console.WriteLine($"Hola! {nombreIngresado}!");

    Console.WriteLine("Desea continuar? S para si, N para no.");
    respuesta = Console.ReadLine();
         };

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente.");

}
else { Console.WriteLine("Opcion no valida"); 
}
