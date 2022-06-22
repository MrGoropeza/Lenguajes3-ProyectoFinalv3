using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Servicios
{
    public class FirebaseAuthenticator : IAuth
    {
        private static string webAPIkey = "AIzaSyB7u4xCGe_kMhTQ61S2L39MtlxbvD_9Ypg";
        private static FirebaseAuthProvider auth;
        public FirebaseAuthenticator()
        {
            auth = new FirebaseAuthProvider(new FirebaseConfig(webAPIkey));
        }

        public async Task<bool> eliminarCuenta(string token)
        {
            try
            {
                await auth.DeleteUserAsync(token);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public Task<FirebaseAuthLink> iniciarSesion(string correo, string pass)
        {
            throw new NotImplementedException();
        }

        public Task<bool> recuperarContra(string correo)
        {
            throw new NotImplementedException();
        }


        public async Task<FirebaseAuthLink> registrarUsuario(string correo, string pass)
        {
            try
            {
                FirebaseAuthLink userLink = await auth.CreateUserWithEmailAndPasswordAsync(correo, pass);
                return userLink;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}