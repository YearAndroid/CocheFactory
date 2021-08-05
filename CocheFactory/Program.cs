using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocheFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICocheFactory factory;
            CrearMotor CM;
            CrearColor CCL;
            CrearCarroceria CC;

            string Coche, Color, Carroceria;
            Console.WriteLine("Selecciona el Coche (Fo/Fe)");
            Coche = Console.ReadLine().ToUpper();

            Console.WriteLine("Selecione el color (R/Bl)");
            Color = Console.ReadLine().ToUpper();

            Console.WriteLine("Selecione la Carroceria (B/C)");
            Carroceria = Console.ReadLine().ToUpper();

            if (Carroceria.Equals("B"))
            {
                factory = new FordFactory();
                if (Color.Equals("R"))
                {
                    if (Coche.Equals("Fo"))
                    {
                        CC = factory.CrearCarroceria();
                        Console.WriteLine(CC.PresentarCC());

                        CM = factory.CrearMotor();
                        Console.WriteLine(CM.PresentarMt());

                        CCL = factory.CrearColor(color);
                        Console.WriteLine(CCL.PresentarCL());
                        
                    }
                    else if (Carroceria.Equals("C"))
                    {
                        CC = factory.CrearCarroceria();
                        Console.WriteLine(CC.PresentarCC());
                       
                        CM = factory.CrearMotor();
                        Console.WriteLine(CM.PresentarMt());

                        CCL = factory.CrearColor();
                        Console.WriteLine(CCL.PresentarCL());
                    }else
                    {
                        Console.WriteLine("Seleccion incorrecta");
                        Environment.Exit(0);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
