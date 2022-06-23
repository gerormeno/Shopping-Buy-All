using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.Entidades
{
    public class Articulo
    {
        private string Articulos;
        private int ID;
        private int Precio;

        public Articulo()
        {

        }
        public Articulo(string articulo)
        {
            Articulos = articulo;
        }

        public string NombreArticulo
        {
            get => Articulos;
            set => Articulos = value;
        }

        public int Id_articulo
        {
            get => ID;
            set => ID = value;
        }

        public int Precio_articulo
        {
            get => Precio;
            set => Precio = value;
        }
    }

}
