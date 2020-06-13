using System;

namespace TareaCapitulos8Y9
{
    class Program
    {
        static void Main(string[] args)
        {             
            Capitulo8 c8 = new Capitulo8();
            Capitulo9 capitulo = new Capitulo9();

            Console.Write(
                            " MENU \n" +
                            "1. Capitulo 8 \n" +
                            "2. Capitulo 9\n\n" +
                            "Elija una Opcion: "
                         );
            

            int op = 0;
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        System.Console.Clear();
                        c8.Menu();                        
                        break;
                    }

                case 2:
                    {
                        System.Console.Clear();
                        capitulo.Menu1();
                        break;
                    }                 
            }
        }
    }
}
