using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TareaCapitulos8Y9
{
    class Capitulo8
    {
        public void Ejercicio8_3()
        {
            string hora, fecha;

            hora = DateTime.Now.ToString("h:mm:ss tt");
            fecha = DateTime.Now.ToString("yyy/dd/MM");
            Console.WriteLine("La Hora es:{0}", hora);
            Console.WriteLine("La Fecha es:{0}", fecha);
            Console.ReadKey();
        }

        public void Ejercicio8_5()
        {
            ArrayList cadenas = new ArrayList();

            Console.WriteLine("\nDigite la Primera Cadena: ");
            string cad = Console.ReadLine();
            cadenas.Add(cad);

            Console.WriteLine("\nDigite la Segunda Cadena: ");
            string cade = Console.ReadLine();
            cadenas.Add(cade);
            cadenas.Sort();

            foreach (string caden in cadenas)
            {
                Console.WriteLine("{0}", caden);
            }
            Console.ReadKey();
        }

        public void Menu()
        {
            int op;
            Console.WriteLine(
                                " MENU\n" +
                                "1. Ejercicio 3\n" +
                                "2. Ejercicio 5\n\n" +
                                "Elija una Opcion: "
                             );
            
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        System.Console.Clear();
                        Ejercicio8_3();/*Hacer un programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.*/
                        break;
                    }
                case 2:
                    {
                        System.Console.Clear();
                        Ejercicio8_5();/*Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.*/
                        break;
                    }
            }
        }
    }
}
