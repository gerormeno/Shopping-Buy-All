using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.Entidades
{
    public class Local
    {
        private string NombreLocal;
        private int NumeroLocal;
        private int TipoLocal;

        public Local()
        {
        }

        public Local (string nombre, int numero, int tipo)
        {
            NombreLocal = nombre;
            NumeroLocal = numero;
            TipoLocal = tipo;
        }

        public string NombreDeLocal
        {
            get => NombreLocal;
            set => NombreLocal = value;
        }

        public int NumeroDeLocal
        {
            get => NumeroLocal;
            set => NumeroLocal = value;
        }

        public int TipoDeLocal
        {
            get => TipoLocal;
            set => TipoLocal = value;
        }
    }
}
