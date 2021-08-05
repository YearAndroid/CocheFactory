using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocheFactory
{
    public abstract class CrearColor
    {
        //private string R;
        //private string BL;
        //public colores (string Rojo, string Black)
        //{
        //    R = Rojo;
        //    BL = Black;
        //}

        //private string Color { get; set; }
        private string Color { get; set; }
        public CrearColor(string color)
        {
            this.Color = color;
        }

        public abstract string PresentarCL();
    }
}
