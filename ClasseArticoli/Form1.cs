using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseArticoli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int codice = 0;
        class AlimentariFreschi : Alimentari
        {
            public List<AlimentariFreschi> alimentarisFreschi = new List<AlimentariFreschi>();
            private int scadenza;

            public int Scadenza
            {
                get { return scadenza; }
                set { scadenza = value; }
            }

            public AlimentariFreschi(string a, string b, int c, string d, int e) : base(a, b, c, d)
            {
                scadenza = e;
            }

            public override int Sconta()
            {
                // 2% di sconto considerato in proporzione inversa
                int molt = 0;
                for(int i = 0; i < scadenza; i++)
                {
                    molt += 2;
                }
                return prezzo - ((prezzo / 100) * molt);
            }

        }

        class ArticoloNonAlimentare : Articolo
        {
            public List<ArticoloNonAlimentare> nonAlimentaris = new List<ArticoloNonAlimentare>();
            private string materiale;
            private bool riciclabile;

            public string Materiale
            {
                get { return materiale; }
                set { materiale = value; }
            }

            public bool Riciclabile
            {
                get { return riciclabile; }
                set { riciclabile = value; }
            }

            public ArticoloNonAlimentare(string a, string b, int c, bool d, string e) : base(a, b, c)
            {
                materiale = e;
                riciclabile = d;
            }
            public override int Sconta()
            {
                // 20% di sconto
                int ret = 1;
                if (riciclabile == true)
                {
                    ret = 10;
                }
                    return prezzo - ((prezzo / 100) * ret);
                
            }

        }
        class Alimentari : Articolo
        {
            public List<Alimentari> alimentaris = new List<Alimentari>();
            protected string data_scadenza;

            public string Data_Scadenza
            {
                get { return data_scadenza; }
                set { data_scadenza = value; }
            }

            public Alimentari(string a, string b, int c, string d) : base(a, b, c)
            {
                data_scadenza = d;
            }

            public override int Sconta()
            {
                // 20% di sconto
                return prezzo - ((prezzo / 100) * 20);
            }

        }
        class Articolo
        {
            protected string codice, nome;
            protected int prezzo;

            public string Codice
            {
                get { return codice; }
                set { codice = value; }
            }
            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }
            public int Prezzo
            {
                get { return prezzo; }
                set { prezzo = value; }
            }

            public Articolo(string a, string b, int c)
            {
                codice = a;
                nome = b;
                prezzo = c;
            }

            public virtual int Sconta()
            {
                // 5% di sconto
                return prezzo - ((prezzo / 100) * 5);
            }
            
        }

        private void AGGIUNGI_Click(object sender, EventArgs e)
        {
            
        }

        private void ALIMENTARI_Click(object sender, EventArgs e)
        {
            string message, title, defaultValue;
            message = "Inserisci il nome prodotto";
            title = "Input prodotto";
            defaultValue = "";
            string nome = Interaction.InputBox(message, title, defaultValue);
            message = "Inserisci il prezzo prodotto";
            string prezzo = Interaction.InputBox(message, title, defaultValue);
            message = "Inserisci la data di scadenza prodotto";
            string data = Interaction.InputBox(message, title, defaultValue);
            Alimentari alimentare = new Alimentari(codice.ToString(), nome, int.Parse(prezzo), data);
            alimentare.alimentaris.Add(alimentare);
            codice++;
        }
        
        private void NON_ALIMENTARI_Click(object sender, EventArgs e)
        {
            string message, title, defaultValue;
            message = "Inserisci il nome prodotto";
            title = "Input prodotto";
            defaultValue = "";
            string nome = Interaction.InputBox(message, title, defaultValue);
            message = "Inserisci il prezzo prodotto";
            string prezzo = Interaction.InputBox(message, title, defaultValue);
            message = "Inserisci il materiale del prodotto";
            string materiale = Interaction.InputBox(message, title, defaultValue);
            DialogResult dialogResult = MessageBox.Show("è riciclabile?", "Riciclabile", MessageBoxButtons.YesNo);
            bool a = false;
            if (dialogResult == DialogResult.Yes)
            {
                a = true;
            }

            ArticoloNonAlimentare alimentare = new ArticoloNonAlimentare(codice.ToString(), nome, int.Parse(prezzo), a , materiale );
            alimentare.nonAlimentaris.Add(alimentare);
            codice++;
        }

        private void ALIMENTARI_FRESCHI_Click(object sender, EventArgs e)
        {
            string message, title, defaultValue;
            message = "Inserisci il nome prodotto";
            title = "Input prodotto";
            defaultValue = "";
            string nome = Interaction.InputBox(message, title, defaultValue);
            message = "Inserisci il prezzo prodotto";
            string prezzo = Interaction.InputBox(message, title, defaultValue);
            message = "Inserisci la data di scadenza prodotto";
            string data = Interaction.InputBox(message, title, defaultValue);
            message = "Inserisci la scadenza max prodotto";
            string scad = Interaction.InputBox(message, title, defaultValue);
            AlimentariFreschi alimentare = new AlimentariFreschi(codice.ToString(), nome, int.Parse(prezzo), data, int.Parse(scad));
            alimentare.alimentarisFreschi.Add(alimentare);
            codice++;
        }

        public void AggiungiACarrello(object art)
        {
            
        }

        private void SCONTRINO_Click(object sender, EventArgs e)
        {
            
        }
    }
}
