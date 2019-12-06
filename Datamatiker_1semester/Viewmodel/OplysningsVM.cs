using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Datamatiker_1semester.Annotations;
using Datamatiker_1semester.Classes;
using Datamatiker_1semester.common;
using Newtonsoft.Json;

namespace Datamatiker_1semester.Viewmodel
{
    class OplysningsVM:INotifyPropertyChanged
    {
        private RelayCommand _gemKundeCommand;
        private KundeInformation _kunde;


        public OplysningsVM()
        {
            _gemKundeCommand = new RelayCommand(GemKunde);
            _kunde = new KundeInformation();
        }

        private void GemKunde()
        {
            // laver json + gemmer i fil
            string str = JsonConvert.SerializeObject(_kunde);
        }

        /*
         * Properties
         */
        public RelayCommand GemKundeCommand
        {
            get => _gemKundeCommand;
        }


        public KundeInformation Kunde
        {
            get => _kunde;
        }

        /*
         * Properties slut
         */




        /*
         * I notify property changed
         */
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
