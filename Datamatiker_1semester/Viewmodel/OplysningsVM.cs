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
using Datamatiker_1semester.Persistens;
using Newtonsoft.Json;

namespace Datamatiker_1semester.Viewmodel
{
    public class OplysningsVM:INotifyPropertyChanged
    {
        private RelayCommand _gemKundeCommand;
        private KundeInformation _kunde;
        private Persistency _gem;


        public OplysningsVM()
        {
            _gem = new Persistency();
            _gemKundeCommand = new RelayCommand(Gem);
            _kunde = new KundeInformation();
        }

        private void Gem()
        {
            _gem.Gemkunde(_kunde);
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
         * Philipkoder slut - Niqulaykoder start
         */

   
     // Her oprettes der en liste med tider til kalenderen,
        // hvor den henter basic informationer fra RBCBooking.

        private List<RBCBooking> tider;
        private RBCBooking _selectedTider;

        public List<RBCBooking> Tider
        {
            get => tider;
            set
            {
                tider = value;
                OnPropertyChanged();
            }
        }

        public RBCBooking SelectedTider
        {
            get => _selectedTider;
            set
            {
                _selectedTider = value;
                OnPropertyChanged();
            }
        }
        
        // Indhold der skal vises på skærmen (XAML).
        public MainVM()
        {
            // Her opretes tider
            tider = new List<RBCBooking>();
            tider.Add(new RBCBooking("Dummy", "Dummy"));

            _selectedTider = new RBCBooking("10:45", "Dato - 5 / 12 / 2019");
        }
   
   
    /*
         * Niqulay koder slut
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
