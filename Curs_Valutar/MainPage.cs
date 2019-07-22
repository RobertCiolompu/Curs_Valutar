using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Curs_Valutar
{
    public partial class PaginaPrincipala : Form
    {
        private CursValutar cursValutar;
        private SchimbValutar schimbValutar;
        public PaginaPrincipala()
        {
            InitializeComponent();
            cursValutar = new CursValutar(this);
            schimbValutar = new SchimbValutar(this);
            panel1.Visible = true;
            cursValutar.Hide();
            schimbValutar.Hide();
            sesiune_noua();

        }

        string[] moneda = new string[32];
        string[] valoareMoneda = new string[32];
        public string[] ArrMonede = new string[32];
        public string[] ArrValoriMonede = new string[32];
        public string adresa = Environment.CurrentDirectory;
        
        private void preiaDate()
        {
            int i, j;
            i = j = 0;
            String URLString = " http://bnr.ro/nbrfxrates.xml";
            XmlTextReader cititor = new XmlTextReader(URLString);
            while (cititor.Read())
            {
                switch (cititor.NodeType)
                {
                    case XmlNodeType.Element:
                        if (cititor.Name == "Rate")
                        {
                            while (cititor.MoveToNextAttribute())
                                if (!Char.IsNumber(cititor.Value[0]))
                                {
                                    moneda[i] = cititor.Value;
                                    i++;
                                }
                        }
                        break;
                    case XmlNodeType.Text: 
                        if (Char.IsNumber(cititor.Value[0]) && cititor.Value[4] != '-')
                        {
                            valoareMoneda[j] = cititor.Value;
                            j++;
                        }
                        break;
                }
            }
        }


        private void scrieDate()
        {
            using (StreamWriter sw = File.CreateText(adresa+"\\curs_valutar.txt")) {

                 for (int i = 0; i < moneda.Length; i++)
                     sw.WriteLine(moneda[i] + '=' + valoareMoneda[i]);
            }       
        }


        private void sesiune_noua()
        {
            if (!File.Exists(adresa+"\\curs_valutar.txt"))
            {
                string mesaj = "Nu exista niciun fisier care sa contina cursurile valutare actuale. Va rugam apasati butonul 'Actualizare curs' din fereastra principala.";
                MessageBox.Show(mesaj);
            }
            else
            {
                MonedeSiValori();
                cursValutar.incarcareCurs();
                cursValutar.delimitare_date();
                schimbValutar.umplereListeConvertor();
            }
        }

        public void MonedeSiValori()
        {
            using (StreamReader sr = File.OpenText(adresa + "\\curs_valutar.txt"))
            {
                string s = "";
                string[] substring = new string[32];
                string[] temp;
                int i = 0;
                char delimitator = '=';
                while ((s = sr.ReadLine()) != null)
                {
                    substring[i] = s + Environment.NewLine;
                    temp = substring[i].Split(delimitator);
                    ArrMonede[i] = temp[0];
                    ArrValoriMonede[i] = temp[1];
                    i++;
                }
            }

        }

        private void DeschideFereastraNoua_Click(object sender, EventArgs e)
        {
            if (sender == CursCurent)
            {
                cursValutar.Show();

            }
            else if (sender == Conversie)
            {
                schimbValutar.Show();
            }
        }

        private void cursCurentMeniu_Click(object sender, EventArgs e)
        {
            cursValutar.Show();
        }


        private void conversieMeniu_Click(object sender, EventArgs e)
        {
            schimbValutar.Show();
        }

        private void iesireMeniu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siteBNRMeniu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bnr.ro/Cursul-de-schimb-524.aspx");
        }

        private void dictionarMonedeMeniu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(adresa + "\\Dictionar Monede.txt");
        }

        private void incadreazaDate()
        {
            preiaDate();
            scrieDate();
            cursValutar.incarcareCurs();
        }
        private void ActualizareCurs_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cursValutar.ListaCurs.Lines.Length; i++)
                cursValutar.ListaCurs.Text = "";
            incadreazaDate();
        }
    }
}
