using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.Entidades
{
    class RegistroEstacionamiento
    {
        private int Id_playa;
        private int Nro_estacionamiento;
        private string Patente;
        private DateTime Fecha_estacionamiento;
        private DateTime Hora_desde;
        private DateTime Hora_hasta;

        public RegistroEstacionamiento()
        {

        }

        public RegistroEstacionamiento(int id_playa, int nro_estacionamiento, string patente, DateTime fecha_estacionamiento, DateTime hora_desde, DateTime hora_hasta)
        {
            Id_playa = id_playa;
            Nro_estacionamiento = nro_estacionamiento;
            Patente = patente;
            Fecha_estacionamiento = fecha_estacionamiento;
            Hora_desde = hora_desde;
            Hora_hasta = hora_hasta;

        }
        public int playa
        {
            get => Id_playa;
            set => Id_playa = value;
        }
        public int nro_estacionamiento
        {
            get => Nro_estacionamiento;
            set => Nro_estacionamiento = value;
        }

        public string patente
        {
            get => Patente;
            set => Patente = value;
        }

        public DateTime fecha_estacionamiento
        {
            get => Fecha_estacionamiento;
            set => Fecha_estacionamiento = value;
        }
        public DateTime hora_desde
        {
            get => Hora_desde;
            set => Hora_desde = value;
        }
        public DateTime hora_hasta
        {
            get => Hora_hasta;
            set => Hora_hasta = value;
        }



    }
}