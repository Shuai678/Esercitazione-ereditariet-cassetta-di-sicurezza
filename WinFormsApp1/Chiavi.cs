using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Chiavi: OggettoSegreto
    {
        private string tipo;

        public Chiavi(string identificatore, double valore, string tipo) : base(identificatore, valore)
        {
            this.tipo = tipo;
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public double CalcolaValoreAssicurato()
        {
            return Valore * 1000;
        }
    }
}
