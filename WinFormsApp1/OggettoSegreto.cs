using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class OggettoSegreto
    {
        private string identificatore;
        private string valore;
        private double valoreAssicurato;
        public OggettoSegreto (string identificatore, string valore)
        {
            this.identificatore = identificatore;
            this.valore = valore;
        }
    }
}
