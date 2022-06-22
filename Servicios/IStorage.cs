using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenguajes3_ProyectoFinalv3.Servicios
{
    public interface IStorage
    {
        string getAvatarLink(int dni);
        string setAvatarLink();
    }
}
