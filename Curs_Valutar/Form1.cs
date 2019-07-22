using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Curs_Valutar
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            new_session();

        }

        string[] currency = new string[32];
        string[] value = new string[32];
        string[] coins = new string[32];
        string[] coin_val = new string[32];
        string path = "C:/Users/robyh/OneDrive/Documents/Visual Studio 2017/Projects/Curs_Valutar/curs_valutar.txt";

        private void button_Click(object sender, EventArgs e)
        {
            if(sender == button1)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
            }
            else if(sender == button2)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
            else if (sender == button3)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
            }
            else if (sender == button4)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }
        private void cursCurentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void conversieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siteBNRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bnr.ro/Cursul-de-schimb-524.aspx");
        }

        private void dictionarMonedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\robyh\OneDrive\Documents\Visual Studio 2017\Projects\Curs_Valutar\Dictionar Monede.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox4.Lines.Length; i++)
                textBox4.Text = "";
            manage_data();
        }
        private void get_data()
        {
            int i, j;
            i = j = 0;
            String URLString = " http://bnr.ro/nbrfxrates.xml";
            XmlTextReader reader = new XmlTextReader(URLString);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "Rate")
                        {
                            while (reader.MoveToNextAttribute())
                                if (!Char.IsNumber(reader.Value[0]))
                                {
                                    currency[i] = reader.Value;
                                    i++;
                                }
                        }
                        break;
                    case XmlNodeType.Text: 
                        if (Char.IsNumber(reader.Value[0]) && reader.Value[4] != '-')
                        {
                            value[j] = reader.Value;
                            j++;
                        }
                        break;
                }
            }
        }

        private void write_data()
        {
            using (StreamWriter sw = File.CreateText(path)) {

                 for (int i = 0; i < currency.Length; i++)
                     sw.WriteLine(currency[i] + '=' + value[i]);
            }       
        }

        private void manage_data()
        {
            get_data();
            write_data();
            load_currency_course();
        }

        private void new_session()
        {
            if (!File.Exists(path))
            {
                string mesaj = "Nu exista niciun fisier care sa contina cursurile valutare actuale. Va rugam apasati butonul 'Actualizare curs' din fereastra principala.";
                MessageBox.Show(mesaj);
            }
            else
            {
                load_currency_course();
                split_course();
                fill_list_options();
            }
        }

        //panel 2 = actual course panel

        private void load_currency_course()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    textBox4.Text += s + Environment.NewLine;  
                }
            }

        }

        private void split_course()
        {
            char delimiter = '=';
            string[] substring;

            for(int i = 0; i<textBox4.Lines.Length; i++)
            {
                if (textBox4.Lines[i] != "")
                {
                    substring = textBox4.Lines[i].Split(delimiter);
                    coins[i] = substring[0];
                    coin_val[i] = substring[1];
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                for( int i = 0; i < textBox4.Lines.Length; i++)
                {
                    if(textBox4.Lines[i].Contains(textBox5.Text)|| textBox4.Lines[i].Contains(textBox5.Text.ToUpper()))
                    {
                        textBox6.Text = coin_val[i];
                        break;
                    }
                }
            }
        }

        //panel 3 = conversion panel

        private void add_to_listbox(ListBox list)
        {
            if (list.Text == "")
            {
                for (int i = 0; i < coins.Length; i++)
                {
                    list.Items.Add(coins[i]);
                }      
                list.Items.Add("RON");
                list.Sorted = true;
                
            }

        }
        
        private void fill_list_options()
        {
            add_to_listbox(listBox1);
            add_to_listbox(listBox2);

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == listBox1)
                label7.Text = "Moneda selectata este:" + listBox1.SelectedItem.ToString();
            else if(sender == listBox2)
                label8.Text = "Moneda selectata este:" + listBox2.SelectedItem.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] convertedCoin, coin_to_convert;
            string coin1 = "";
            string coin2 = "";
            char delimiter = ':';
            double valoare_in_lei, valoare_in_lei_coin1, valoare_in_lei_coin2;
            valoare_in_lei = valoare_in_lei_coin1 = valoare_in_lei_coin2 = 0;

            if (label1.Text == "" || label2.Text == "" || (label1.Text == "" && label2.Text == ""))
            {
                string mesaj = "Va rugam asigurati-va ca monedele au fost selectate!";
                MessageBox.Show(mesaj);
            }
            else
            {
                convertedCoin = label7.Text.Split(delimiter);
                coin1 = convertedCoin[1];
                coin_to_convert = label8.Text.Split(delimiter);
                coin2 = coin_to_convert[1];
            }

            if (textBox2.Text == "")
            {
                string message = "Va rugam introduceti o suma!";
                MessageBox.Show(message);
            }
            else
            {
                if(coin1 == coin2)
                {
                    textBox3.Text = textBox2.Text;
                }
                else if (coin2 == "RON")
                {
                    convert_amount(coin1, valoare_in_lei, textBox3);
                }
                else if(coin1 == "RON")
                {
                    convert_amount(coin2, valoare_in_lei, textBox3);
                    
                }
                else
                {
                    for (int i = 0; i < coins.Length; i++)
                    {
                        if (coin1 == coins[i])
                        {
                            valoare_in_lei_coin1 = Convert.ToDouble(coin_val[i]);
                            break;
                        }
                    }
                    for (int i = 0; i < coins.Length; i++)
                    {
                        if (coin2 == coins[i])
                        {
                            valoare_in_lei_coin2 = Convert.ToDouble(coin_val[i]);
                            break;
                        }
                    }
                    double suma = Convert.ToDouble(textBox2.Text);
                    textBox3.Text = Convert.ToString((suma * valoare_in_lei_coin1) / valoare_in_lei_coin2);
                }
                    
            }
        }

        private void convert_amount(string coin, double val, TextBox textBox)
        {
            for (int i = 0; i < coins.Length; i++)
            {
                if (coin == coins[i])
                {
                    val = Convert.ToDouble(coin_val[i]);
                    break;
                }
            }
            double suma = Convert.ToDouble(textBox2.Text);
            textBox.Text = Convert.ToString(suma / val);
        }

        private void buttonDenumiri_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\robyh\OneDrive\Documents\Visual Studio 2017\Projects\Curs_Valutar\Dictionar Monede.txt");

        }
    }
}
