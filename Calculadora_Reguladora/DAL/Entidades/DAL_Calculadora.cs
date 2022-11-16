using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entidades
{
    public class DAL_Calculadora
    {
        private string _sNumero1;
        private string _sNumero2;
        private string _sOperador;
        private string _sObservacion;
        private string _sVerificacion;

        public string sNumero1 { get => _sNumero1; set => _sNumero1 = value; }
        public string sNumero2 { get => _sNumero2; set => _sNumero2 = value; }
        public string sOperador { get => _sOperador; set => _sOperador = value; }
        public string sObservacion { get => _sObservacion; set => _sObservacion = value; }
        public string sVerificacion { get => _sVerificacion; set => _sVerificacion = value; }
    }
}
