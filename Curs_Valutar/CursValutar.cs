using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_Valutar
{
    public partial class CursValutar : Form
    {
        private PaginaPrincipala paginaPrincipala;
        public string[] ArrMonede = new string[32];
        public string[] ArrValoriMonede = new string[32];
        public CursValutar(PaginaPrincipala paginaPrincipala)
        {
            InitializeComponent();
            this.paginaPrincipala = paginaPrincipala;
        }

        private void InapoiLaPagPrincipala_Click(object sender, EventArgs e)
        {
            paginaPrincipala.Show();
            Hide();
        }


        public void incarcareCurs()
        {
            using (StreamReader sr = File.OpenText(paginaPrincipala.adresa + "\\curs_valutar.txt"))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    ListaCurs.Text += s + Environment.NewLine;
                }
            }

        }

        public void delimitare_date()
        {
            char delimitator = '=';
            string[] substring;

            for (int i = 0; i < ListaCurs.Lines.Length; i++)
            {
                if (ListaCurs.Lines[i] != "")
                {
                    substring = ListaCurs.Lines[i].Split(delimitator);
                    ArrMonede[i] = substring[0];
                    ArrValoriMonede[i] = substring[1];
                }
            }
        }
        private void GasesteValoare_Click(object sender, EventArgs e)
        {
            if (textboxMonedaCurs.Text != "")
            {
                for (int i = 0; i < ListaCurs.Lines.Length; i++)
                {
                    if (ListaCurs.Lines[i].Contains(textboxMonedaCurs.Text) || ListaCurs.Lines[i].Contains(textboxMonedaCurs.Text.ToUpper()))
                    {
                        textboxValoareMonedaCurs.Text = ArrValoriMonede[i];
                        break;
                    }
                }
            }
        }

        private void buttonDenumiri_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(paginaPrincipala.adresa + "\\Dictionar Monede.txt");

        }

    }
}
