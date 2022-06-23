using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.Entidades
{
    public class Profesion
    {
        private int IdProfesion;
        private string NombreProfesion;


        public Profesion(int id, string nombre)
        {
            IdProfesion = id;
            NombreProfesion = nombre;
        }

        public Profesion()
        {

        }

        public int id
        {
            get => IdProfesion;
            set => IdProfesion = value;
        }

        public string nombreProfesion
        {
            get => NombreProfesion;
            set => NombreProfesion = value;
        }
    }
}
