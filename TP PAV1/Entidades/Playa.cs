using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1
{
    public class Playa
    {
        private int idPlaya;
        private string nombrePlaya;

        public Playa()
        {

        }
            
        public int IdPlaya
        {
            get => idPlaya;
            set => idPlaya = value;
        }


        public string NombrePlaya
        {
            get => nombrePlaya;
            set => nombrePlaya = value;
        }

    }
}
