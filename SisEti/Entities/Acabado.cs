using System;
using System.Collections.Generic;
using System.Text;

namespace SisEti.Entities
{
    public class Acabado
    {
        private int _IdAcabado;

        public int IdAcabado
        {
            get { return _IdAcabado; }
            set { _IdAcabado = value; }
        }        

        private int _Number;

        public int Number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        private string _DescripcionEtiqueta;

        public string DescripcionEtiqueta
        {
            get { return _DescripcionEtiqueta; }
            set { _DescripcionEtiqueta = value; }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }


    }
}
