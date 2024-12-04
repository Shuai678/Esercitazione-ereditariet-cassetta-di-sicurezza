using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class CassettaDiSicurezza
    {
        private List<OggettoSegreto> oggettiContenuti;
        private string codiceUnivoco;
        private string produttore;
        private string codiceSegreto;
        private bool vuoto;

        public List<OggettoSegreto> OggettiContenuti
        {
            get { return oggettiContenuti; }
        }
        public CassettaDiSicurezza (string codiceUnivoco, string produttore, string codiceSegreto, bool vuoto)
        {
            this.codiceUnivoco = codiceUnivoco;
            this.produttore = produttore;
            this.codiceSegreto = codiceSegreto;
            this.vuoto = vuoto;
        }

        public string CodiceUnivoco
        {
            get { return codiceUnivoco; }
        }
        public string Produttore
        {
            get { return produttore; }
        }

        public string CodiceSegreto
        {
            get { return codiceSegreto; }
        }

        public void Aggiungi(OggettoSegreto oggetto)
        {
            oggettiContenuti.Add(oggetto);
            vuoto = false;
        }

        public void Rimuovi(OggettoSegreto oggetto)
        {
            if (oggetto == null)
                return;
            OggettiContenuti.Remove(oggetto);
        }

        public void ModificaPin (string codiceVecchio, string codiceNuovo)
        {

            if (codiceNuovo == null || codiceNuovo == codiceVecchio || codiceVecchio != codiceSegreto)
                return;
            codiceSegreto = codiceNuovo;
        }

        public void SetVuoto()
        {
            vuoto = true;
        }





        

    }
}
