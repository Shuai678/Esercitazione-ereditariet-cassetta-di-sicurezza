﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Gioielli : OggettoSegreto
    {
        private string tipo;

        public Gioielli(string identificatore, string valore, string tipo) : base(identificatore, valore) // Chiama il costruttore di OggettoSegreto
        {
            this.tipo = tipo;
        }

        public string Tipo
        { 
            get { return tipo; }
            set { tipo = value; }
        }

    }
}
