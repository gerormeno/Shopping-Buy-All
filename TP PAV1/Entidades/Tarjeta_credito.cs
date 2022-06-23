using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1
{
    public class Tarjeta_credito
    {
        private int idTarjeta;
        private string Nombre;
        private int IdTipo;

        public Tarjeta_credito()
        {

        }

        public int IdTarjeta
        {
            get => idTarjeta;
            set => idTarjeta = value;
        }


        public string NombreTarjeta
        {
            get => Nombre;
            set => Nombre = value;
        }

        public int IdTipoTarjeta
        {
            get => IdTipo;
            set => IdTipo = value;
        }

        

    }
}
