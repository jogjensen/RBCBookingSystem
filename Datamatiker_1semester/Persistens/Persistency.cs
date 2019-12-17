using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Datamatiker_1semester.Classes;
using Datamatiker_1semester.Viewmodel;
using Newtonsoft.Json;

namespace Datamatiker_1semester.Persistens
{

    //Philip koder

    public class Persistency
    {
        private const string FileName = "Kundeinformation.txt";
        private readonly StorageFolder _folder = ApplicationData.Current.LocalCacheFolder;

        public Persistency()
        {
            
        }

        public async void Gemkunde (KundeInformation kunde)
        {
            string jstring = JsonConvert.SerializeObject(kunde);
            var datafile = await _folder.CreateFileAsync(FileName, CreationCollisionOption.OpenIfExists);
            await FileIO.WriteTextAsync(datafile, jstring);
        }
        //Fil findes i C:\Users\DINBRUGER\AppData\Local\Packages
    }
}  //Philip koder slut
