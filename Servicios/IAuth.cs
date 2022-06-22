using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenguajes3_ProyectoFinalv3.Servicios
{
    public interface IAuth
    {
        Task<FirebaseAuthLink> iniciarSesion(string correo, string pass);
        Task<FirebaseAuthLink> registrarUsuario(string correo, string pass);
        Task<bool> recuperarContra(string correo);
        Task<bool> eliminarCuenta(string token);
    }
}
