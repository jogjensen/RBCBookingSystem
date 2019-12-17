using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datamatiker_1semester.Classes
{

    //Philip koder

    public class KundeInformation
    {
       
        private string _navn;
        private int _tlfnummer;
        private string _adr;
        private string _bynavn;
        private int _postnummer;
        private string _email;
        private string _email2;

      //he

        public KundeInformation(string navn,int tlfnummer,string adr,string bynavn,int postnummer,string email,string email2)
        {
            _navn = navn;
            _tlfnummer = tlfnummer;
            _adr = adr;
            _bynavn = bynavn;
            _postnummer = postnummer;
            _email = email;
            _email2 = email2;


        }

        public KundeInformation() : this("",0, "", "", 0, "", "")
        {

        }


        public String Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public Int32 Tlfnummer
        {
            get => _tlfnummer;
            set => _tlfnummer = value;
        }

        public String Adr
        {
            get => _adr;
            set => _adr = value;
        }

        public String Bynavn
        {
            get => _bynavn;
            set => _bynavn = value;
        }

        public Int32 Postnummer
        {
            get => _postnummer;
            set => _postnummer = value;
        }

        public String Email
        {
            get => _email;
            set => _email = value;
        }

        public String Email2
        {
            get => _email2;
            set => _email2 = value;
        }


        //Philip koder slut

    }



}

