using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.Entidades
{
    public class Vehiculo
    {
        private string Patente;
        private int id_tipoDocupmento;
        private string nroDocumento;
        private int id_modelo;
        private int id_tipoVehiculo;


        public Vehiculo(string pat, int tipoDoc, string nroDoc,int idMod,int id_tipoVeh)
        {
            Patente = pat;
            id_tipoDocupmento = tipoDoc;
            nroDocumento = nroDoc;
            id_modelo = idMod;
            id_tipoVehiculo = id_tipoVeh;
        }

        public Vehiculo()
        {

        }

        public string patenteVehiculo
        {
            get => Patente;
            set => Patente = value;
        }
        public int tipoDocVehiculo
        {
            get => id_tipoDocupmento;
            set => id_tipoDocupmento = value;
        }

        public string nroDocVehiculo
        {
            get => nroDocumento;
            set => nroDocumento = value;
        }

        public int modeloVehiculo
        {
            get => id_modelo;
            set => id_modelo = value;
        }

        public int tipoVehiculo
        {
            get => id_tipoVehiculo;
            set => id_tipoVehiculo = value;
        }
    }
}
