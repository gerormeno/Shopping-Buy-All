using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.Entidades
{
    public class Compra
    {
        private int nro_compra;
        private int nro_local;
        private int tipo_documento;
        private string nro_documento;
        private DateTime fecha;
        private int monto;

        public Compra(int Nro_compra, int Nro_local, int Tipo_Documento, string Nro_Documento, DateTime Fecha,int Monto)
        {
            nro_compra = Nro_compra;
            nro_local = Nro_local;
            tipo_documento = Tipo_Documento;
            nro_documento = Nro_Documento;
            fecha = Fecha;
            monto = Monto;
        }

        public int numeroCompra
        {
            get => nro_compra;
            set => nro_compra = value;
        }
        public int localCompra
        {
            get => nro_local;
            set => nro_local = value;
        }
        public int tipoDocumentoCompra
        {
            get => tipo_documento;
            set => tipo_documento = value;
        }
        public string nroDocumentoCompra
        {
            get => nro_documento;
            set => nro_documento = value;
        }
        public DateTime fechaCompra
        {
            get => fecha;
            set => fecha = value;
        }

        public int montoCompra
        {
            get => monto;
            set => monto = value;
        }


    }
}

