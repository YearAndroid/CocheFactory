using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CocheFactory
{
    class PSColor : CrearColor
    {
        public override string PresentarCL()
        {
            var BL;



            //throw new NotImplementedException();


            //implementacion de color 
            var R;
            if (R.Equals("R"))
            {
                Console.WriteLine("Rojo");
                Console.ReadLine().ToUpper();
            }
            else if (BL.Equals("BL"))
            {
                Console.WriteLine("Negro");
                Console.ReadLine().ToUpper();

            }
            else
            {
                Console.WriteLine("No exite color");
            }
            Console.ReadKey();
                //Console.Write("Ford","Ferrarri", PresentarCL());
            
        }
    }
}
