/******************************************************************************
Autor: Juan Pablo Moreno

Fecha:21/08/2024

crear menu de libreria.
Si selecciona 3 no repite, de lo contario repite
*******************************************************************************/
using System;
class HelloWorld
{
	static void Main()
	{
		int eleccion=0;
		while (eleccion !=3) {
			Console.WriteLine("Bienvenido a la libreria");
			Console.WriteLine("1 ingrese");
			Console.WriteLine("2 cancelar inscripcion");
			Console.WriteLine("3 salir");
			eleccion = Int32.Parse(Console.ReadLine());
			if(eleccion==1) {
				Console.WriteLine("usted a ingresado");
			}
			if(eleccion==2) {
				Console.WriteLine("usted a cancelado");
			}
			if(eleccion==3) {
				Console.WriteLine("usted se a salido");
			}
		}


	}
}
