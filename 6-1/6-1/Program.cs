using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        //Lares Dominguez Brandon - 17211532
        static void Main(string[] args)
        {
            //1er Ejemplo
            int num , i = 0, pos = 0;
            int[] vector = { 3, 65, 8, 1, 2, 88, 9, 0, 6, 45 };
            bool encontro = false;
            Console.WriteLine("Algortimo 1");
            Console.WriteLine("Arreglo para buscar algun valor del arreglo (3,65,8,1,2,88,9,0,6,45)");
            Console.Write("Ingresar numero cualquiera: ");
            num = int.Parse(Console.ReadLine());

            while(!(encontro) && i<10)
            {
                if (num == vector[i])
                {
                    encontro = true;
                    pos = i;
                }
                i = i + 1;
            }
            if (encontro)
                pos = pos + 1;
            
             Console.WriteLine("El numero si se encuentra y esta en la posicion: " + pos );
            Console.ReadKey();

            //2do Ejemplo

            TipoBusqueda TB = new TipoBusqueda();

            List<int> Lista = new List<int>();

            Lista.Add(78);
            Lista.Add(35);
            Lista.Add(243);
            Lista.Add(2);
            Lista.Add(65);
            Lista.Add(4);
            Lista.Add(243);
            Lista.Add(12);
            Lista.Add(1);        
            int ele = 20;

            Console.WriteLine("\nAlgortimo 2");
            Console.WriteLine();
            Console.WriteLine("Elemento: " + ele);
            Console.WriteLine("Esta incluido en la lista? " + TB.BusquedaSecuencial(ele, Lista));
            Console.ReadKey();
        }
    }

    class TipoBusqueda
    {
        public bool BusquedaSecuencial(int Elemento, List<int> Lista)
        {
            int Tamaño = Lista.Count;
            int Posicion = 0;

            while (Posicion < Tamaño)
            {
                if (Lista[Posicion] == Elemento)
                {
                    return true;
                }
                else
                {
                    Posicion++;
                }
            }
            return false;
        }
    }
}

        

    

 