using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocheFactory
{
    interface ICocheFactory
    {
        CrearCarroceria CrearCarroceria();

        CrearMotor CrearMotor();

        CrearColor CrearColor();
    }
}
