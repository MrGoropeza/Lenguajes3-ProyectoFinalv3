using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Web;
using Firebase.Storage;

namespace Lenguajes3_ProyectoFinalv3.Servicios
{
    public class FirebaseFiles : IStorage
    {
        private static string storagekey = "lenguajes3-proyectofinal.appspot.com";
        private static FirebaseStorage storage;

        public FirebaseFiles()
        {
            storage = new FirebaseStorage(storagekey);
        }
        public string getAvatarLink(int dni)
        {
            throw new NotImplementedException();
        }

        public async Task<string> setAvatarLink(Stream file,int dni)
        {
            return await storage.Child("avatars")
                .Child(dni.ToString())
                .PutAsync(file);
        }
    }
}