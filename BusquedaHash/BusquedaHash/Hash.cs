using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BusquedaHash
{
    public class Hash
    {
        Hashtable datos = new Hashtable(); //Crea un hashtable para agregar datos
        public void Buscar()
        {
            Console.WriteLine("Datos disponibles: ");
            datos.Add(123, "Brandon"); //Los datos contienen una llave unica y el dato
            datos.Add(132, "Carlos");//La clave no puede repetirse
            datos.Add(321, "Jose");
            datos.Add(213, "David");
            datos.Add(232, "Chuleta");
            Imprimir(datos); //Se llama el metodo imprimir
            Console.WriteLine();
            Console.WriteLine("Introduzca clave para buscar dato: "); //Se pregunta y lee la clave 
            int clave = int.Parse(Console.ReadLine()); //Se guarda en la variable
            if (datos.ContainsKey(clave)) //Si datos contiene la llave que esta en la variable
            {
                Console.WriteLine("Se encontro y contiene el dato: {0}", datos[clave]); //Escribira el dato encontrado con esa llave
            }
            else
            {
                Console.WriteLine("Dato no encontrado"); //Si no es encontrado, mensaje de que no
            }

        }
        public void Imprimir(Hashtable hashtable) //Metodo imprimir con parametro Hashtable
        {
            foreach (DictionaryEntry i in datos) //Aqui se busca un dictonaryentry para imprimir, osea que tenga la clave algun dato cualquiera
            {
                Console.WriteLine("{0}-{1}", i.Key, i.Value);
            }
        }

    }
}

