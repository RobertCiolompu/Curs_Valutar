using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Curs_Valutar
{
    public partial class SchimbValutar : Form
    {
        private PaginaPrincipala paginaPrincipala;
        
        public SchimbValutar(PaginaPrincipala paginaPrincipala)
        {
            InitializeComponent();
            this.paginaPrincipala = paginaPrincipala;
        }

        private void preiaMonedeSiValori()
        {
            paginaPrincipala.MonedeSiValori();
        }

        private void InapoiLaPagPrincipala_Click(object sender, EventArgs e)
        {
            paginaPrincipala.Show();
            Hide();
        }

        public void adaugareListaConvertor(ListBox list)
        {
            if (list.Text == "")
            {
                for (int i = 0; i < paginaPrincipala.ArrMonede.Length; i++)
                {
                    list.Items.Add(paginaPrincipala.ArrMonede[i]);
                }
                list.Items.Add("RON");
                list.Sorted = true;

            }

        }

        public void umplereListeConvertor()
        {
            adaugareListaConvertor(ListaConversie1);
            adaugareListaConvertor(ListaConversie2);

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == ListaConversie1)
                MonedaDeConvertitDin.Text = "Moneda selectata este:" + ListaConversie1.SelectedItem.ToString();
            else if (sender == ListaConversie2)
                MonedaDeConvertitIn.Text = "Moneda selectata este:" + ListaConversie2.SelectedItem.ToString();
        }

        private void Conversie_Click(object sender, EventArgs e)
        {
            string[] monedaConvertita, monedaDeConvertit;
            string monedaPrimaLista = "";
            string monedaListaDoi = "";
            char delimitator = ':';
            double valoare_in_lei, valoare_in_lei_monedaPrimaLista, valoare_in_lei_monedaListaDoi;
            valoare_in_lei = valoare_in_lei_monedaPrimaLista = valoare_in_lei_monedaListaDoi = 0;

            if (MonedaDeConvertitDin.Text == "" || MonedaDeConvertitIn.Text == "" || (MonedaDeConvertitDin.Text == "" && MonedaDeConvertitIn.Text == ""))
            {
                string mesaj = "Va rugam asigurati-va ca monedele au fost selectate!";
                MessageBox.Show(mesaj);
            }
            else
            {
                monedaConvertita = MonedaDeConvertitDin.Text.Split(delimitator);
                monedaPrimaLista = monedaConvertita[1];
                monedaDeConvertit = MonedaDeConvertitIn.Text.Split(delimitator);
                monedaListaDoi = monedaDeConvertit[1];
            }

            if (textboxSumaDeConvertit.Text == "")
            {
                string message = "Va rugam introduceti o suma!";
                MessageBox.Show(message);
            }
            else
            {
                if (monedaPrimaLista == monedaListaDoi)
                {
                    textboxSumaConvertita.Text = textboxSumaDeConvertit.Text;
                }
                else if (monedaListaDoi == "RON")
                {
                    ConvertesteSuma(monedaPrimaLista, valoare_in_lei, textboxSumaConvertita);
                    
                }
                else if (monedaPrimaLista == "RON")
                {
                    ConvertesteSuma(monedaListaDoi, valoare_in_lei, textboxSumaConvertita);

                }
                else
                {
                    for (int i = 0; i < paginaPrincipala.ArrMonede.Length; i++)
                    {
                        if (monedaPrimaLista == paginaPrincipala.ArrMonede[i])
                        {
                            valoare_in_lei_monedaPrimaLista = System.Convert.ToDouble(paginaPrincipala.ArrValoriMonede[i]);
                            break;
                        }
                    }
                    for (int i = 0; i < paginaPrincipala.ArrMonede.Length; i++)
                    {
                        if (monedaListaDoi == paginaPrincipala.ArrMonede[i])
                        {
                            valoare_in_lei_monedaListaDoi = System.Convert.ToDouble(paginaPrincipala.ArrValoriMonede[i]);
                            break;
                        }
                    }
                    double suma = System.Convert.ToDouble(textboxSumaDeConvertit.Text);
                    textboxSumaConvertita.Text = System.Convert.ToString((suma * valoare_in_lei_monedaPrimaLista) / valoare_in_lei_monedaListaDoi);
                }

            }
        }

        private void ConvertesteSuma(string moneda, double valoare, TextBox textBox)
        {
            for (int i = 0; i < paginaPrincipala.ArrMonede.Length; i++)
            {
                if (moneda == paginaPrincipala.ArrMonede[i])
                {
                    valoare = System.Convert.ToDouble(paginaPrincipala.ArrValoriMonede[i]);
                    break;
                }
            }
            double suma = System.Convert.ToDouble(textboxSumaDeConvertit.Text);
            if (MonedaDeConvertitIn.Text.Contains("RON"))
                textBox.Text = System.Convert.ToString(suma * valoare);
            else if (MonedaDeConvertitDin.Text.Contains("RON"))
                textBox.Text = System.Convert.ToString(suma / valoare);
        }

        private void buttonDenumiri_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(paginaPrincipala.adresa + "\\Dictionar Monede.txt");

        }

        private void SchimbValutar_Load(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;

        }
    }
}
