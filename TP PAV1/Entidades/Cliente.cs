using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.Entidades
{
    public class Cliente
    {
        private string Documento;
        private string Apellido;
        private string Nombre;
        private DateTime FechaNacimiento;
        private int IdSexo;
        private int IdTipoDocumento;
        private int IdBarrio;
        private string Calle;
        private int NroCasa;
        private int IdEstadoCivil;



        public Cliente(string documento, string apellido, string nombre)
        {
            Documento = documento;
            Apellido = apellido;
            Nombre = nombre;
        }

        public Cliente()
        {

        }

        public string DocumentoCliente
        {
            get => Documento;
            set => Documento = value;
        }
        public string ApellidoCliente
        {
            get => Apellido;
            set => Apellido = value;
        }

        public string NombreCliente
        {
            get => Nombre;
            set => Nombre = value;
        }

        public DateTime FechaNacimientoCliente
        {
            get => FechaNacimiento;
            set => FechaNacimiento = value;
        }

        public int SexoCliente
        {
            get => IdSexo;
            set => IdSexo = value;
        }

        public int TipoDocumentoCliente
        {
            get => IdTipoDocumento;
            set => IdTipoDocumento = value;
        }

        public int BarrioCliente
        {
            get => IdBarrio;
            set => IdBarrio = value;
        }

        public string CalleCliente
        {
            get => Calle;
            set => Calle = value;
        }

        public int NroCasaCliente
        {
            get => NroCasa;
            set => NroCasa = value;
        }

        public int EstadoCivilCliente
        {
            get => IdEstadoCivil;
            set => IdEstadoCivil = value;
        }
    }
}

