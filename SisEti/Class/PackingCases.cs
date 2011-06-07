using System;
using System.Collections.Generic;
using System.Text;

namespace SisEti.Class
{
    public class PackingCases
    {
        private string _CajaId;

        public string CajaId
        {
            get { return _CajaId; }
            set { _CajaId = value; }
        }
        private string _Talla;

        public string Talla
        {
            get { return _Talla; }
            set { _Talla = value; }
        }
        private string _Prendas;

        public string Prendas
        {
            get { return _Prendas; }
            set { _Prendas = value; }
        }
        private string _TipoCaja;

        public string TipoCaja
        {
            get { return _TipoCaja; }
            set { _TipoCaja = value; }
        }
        private string _Id;

        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _CuttingID;

        public string CuttingID
        {
            get { return _CuttingID; }
            set { _CuttingID = value; }
        }
    }
}
