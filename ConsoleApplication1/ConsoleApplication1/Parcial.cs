using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Parcial
    {
        int op,i=0,edad;
        double a, b, c;
        string nom;
        
        
        public void ops() 
        {
            Console.WriteLine("Ingrese una opcion");
            op = int.Parse(Console.ReadLine());

            switch (op) 
            {
                case 1: Console.WriteLine("Ingrese un numero");
                    a = double.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("El poducto de 0 por cualquier numero es 0");
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un segundo numero");
                        b = double.Parse(Console.ReadLine());

                        c = a * b;
                        Console.WriteLine("El resultado de la multiplicacion es " +c);
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    Console.WriteLine("Ingrese dos numeros enteros ");
                    Console.WriteLine("Ingrese el primer numero");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    b = double.Parse(Console.ReadLine());
                    if (b == 0)
                    {
                        Console.WriteLine("Error: no se puede dividir entre cero");
                    }
                    else
                    {
                        c = a / b;
                        Console.WriteLine("El resultado de la division es " + c);
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    for (i = 0; i < 5; )
                    {
                        Console.WriteLine("Ingrese un nombre");
                        nom = Console.ReadLine();
                        Console.WriteLine("El nombre es " + nom);
                        Console.ReadKey();
                        i = i+1;
                    }

                    break;
                case 4: do 
                    {
                        Console.WriteLine("Ingrese su edad");
                        edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("La edad es " + edad);
                        Console.ReadKey();
                        i = i + 1;
                    }
                    while (i < 5);

                    break;

            }


            
            

        }
    }
}
