using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.UserDataTasks;

namespace Datamatiker_1semester.Classes
{
    public class RBCBooking
    {
        // _dato = "Dato - 5/12/2019";
        // _tid = "10:45";

        private string _tid;
        private string _dato;

        public string Tid
        {
            get => _tid;
            set { _tid = value; }
        }

        public string Dato
        {
            get => _dato;
            set { _dato = value; }
        }

        public RBCBooking(string Tid, string Dato)
        {
           _tid = Tid;
           _dato = Dato;
        }
    }
}
