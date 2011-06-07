using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SisEti.Entities
{
    public class Estilo
    {
        private int _IdEstilo;

        public int IdEstilo
        {
            get { return _IdEstilo; }
            set { _IdEstilo = value; }
        }

        private string _EstiloCodigo;

        public string EstiloCodigo
        {
            get { return _EstiloCodigo; }
            set { _EstiloCodigo = value; }
        }

        private int _EstadoActivo;

        public int EstadoActivo
        {
            get { return _EstadoActivo; }
            set { _EstadoActivo = value; }
        }

        private string _Activo;

        public string Activo
        {
            get { return _Activo; }
            set { _Activo = value; }
        }
    }
}
