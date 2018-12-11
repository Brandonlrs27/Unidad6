using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    class Program
    { //Lares Dominguez Brandon - 17211532
        static void Main(string[] args)
        {//Ejemplo 1
            Console.WriteLine("Ejemplo 1:  ");
            int numero, puntero = 0, final = 9, miitad = 999; //Se declaran variables para trabajar, en este caso numero es el valor que vamos a tomar del usuario, las variables puntero y final son de referencia para ir acomodando el vector como se trata el metodo.
            int[] vector = { 3, 8, 11, 22, 38, 49, 50, 56, 62, 70 }; //Se declara vector con 10 numeros
            bool encontro = false; //Variable que definira si se encontro el valor buscado
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (!encontro && puntero <= final) //Mientras que encontro sea falso y puntero menor o igual a final, se hara el ciclo
            {
                miitad = (int)((puntero + final) / 2); //mitad sera la suma de puntero y final dividido entre 2
                if (numero == vector[miitad]) //Si numero ingresado es igual al vector con posicion en mitad
                    encontro = true; //Se ha encontrado el valor
                else if (numero < vector[miitad]) //Si es menor al vector con posicion de mitad
                    final = miitad - 1; //Se aumentara a final la mitad + 1
                else
                    puntero = miitad + 1; //Si no se cumplen las anteriores, puntero suma la mitad + 1
            }
            if (encontro) //Si lo encontro, muestra la posicion del numero en el vector
                Console.Write("El dato se encuentra en la posicion: "  + (miitad + 1));
            else //Si no, se muestra que no se mostro
                Console.Write("No se encuentra el valor");
            Console.ReadKey();

            //Ejemplo 2
            Console.WriteLine();
            Console.WriteLine("Ejemplo 2:  ");
            int numero2, puntero2 = 0, final2 = 9, miitad2 = 999; 
            int[] vector2 = { 3, 12, 23, 34, 45, 56, 67, 78, 89, 91 }; 
            bool encontro2 = false; 
            Console.WriteLine("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            while (!encontro2 && puntero2 <= final2) 
            {
                miitad2 = (int)((puntero2 + final2) / 2); 
                if (numero2 == vector2[miitad2]) 
                    encontro2 = true; 
                else if (numero2 < vector2[miitad2])
                    final2 = miitad2 - 1; 
                else
                    puntero2 = miitad2 + 1; 
            }
            if (encontro2) 
                Console.Write("El dato se encuentra en la posicion: " + (miitad2 + 1));
            else 
                Console.Write("No se encuentra el valor");
            Console.ReadKey();

        }
    }
}
