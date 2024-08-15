
using System;

public class Program
{
    static void Main(string[] args)
    {
                 
            Console.WriteLine("Bienvenidos a nuestro primer sistema creado en C#");

            Console.WriteLine("Ingresa tu nombre para continuar");
            string Nombre = Console.ReadLine();//Para recibir Valores de Caracter
            Console.WriteLine("Ingrese su edad");
            int Edad=Convert.ToInt32(Console.ReadLine());// convertir a dato tipo double
            double EdadMeses = Edad * 12; // Calculos Matematicos
            Console.WriteLine(Nombre +" Tu edad en Meses es: " + EdadMeses + "Meses");//Concatenacion
    }
}


