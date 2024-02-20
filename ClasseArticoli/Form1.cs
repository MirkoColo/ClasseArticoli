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

            Scontrinos.Visible = false;

        }

        List<Alimentari> alimentaris = new List<Alimentari>();
        List<AlimentariFreschi> alimentarisFreschi = new List<AlimentariFreschi>();
        List<ArticoloNonAlimentare> nonAlimentaris = new List<ArticoloNonAlimentare>();
        int codice = 0;
        class AlimentariFreschi : Alimentari
        {

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

            public override float Sconta()
            {
                // 2% di sconto considerato in proporzione inversa
                int molt = 0;
                for (int i = 0; i < scadenza; i++)
                {
                    molt += 2;
                }

                float pres = prezzo - ((prezzo / 100) * molt);
                if (carta == true)
                {
                    pres = pres - ((pres / 100) * 5);
                }
                return pres;

            }

            public string Stampa()
            {
                return $"CODICE: {codice} - NOME: {nome} - PREZZO: {prezzo} - PREZZO SCONTATO: {Sconta()} - SCADENZA: {scadenza}";
            }

        }

        class ArticoloNonAlimentare : Articolo
        {

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
            public override float Sconta()
            {
                // 20% di sconto
                int ret = 1;
                if (riciclabile == true)
                {
                    ret = 10;
                }
                float pres = prezzo - ((prezzo / 100) * ret);
                if (carta == true)
                {
                    pres = pres - ((pres / 100) * 5);
                }
                return pres;
            }

            public string Stampa()
            {
                string gianna = (riciclabile == true) ? "SI" : "NO";
                return $"CODICE: {codice} - NOME: {nome} - PREZZO: {prezzo} - PREZZO SCONTATO: {Sconta()} - MATERIALE: {materiale} - RICICLABILE: {gianna}";
            }

        }
        class Alimentari : Articolo
        {

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

            public override float Sconta()
            {
                // 20% di sconto

                float pres = prezzo - ((prezzo / 100) * 20);
                if (carta == true)
                {
                    pres = pres - ((pres / 100) * 5);
                }
                return pres;
            }

            public string Stampa()
            {
                return $"CODICE: {codice} - NOME: {nome} - PREZZO: {prezzo} - PREZZO SCONTATO: {Sconta()} - DATA: {data_scadenza}";
            }

        }
        class Articolo
        {
            protected string codice, nome;
            protected float prezzo;
            protected bool carta = false;

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
            public float Prezzo
            {
                get { return prezzo; }
                set { prezzo = value; }
            }
            public bool Carta
            {
                get { return carta; }
                set { carta = value; }
            }

            public Articolo()
            {
            }
            public Articolo(string a, string b, int c)
            {
                codice = a;
                nome = b;
                prezzo = c;
            }

            public virtual float Sconta()
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
            alimentaris.Add(alimentare);
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

            ArticoloNonAlimentare alimentare = new ArticoloNonAlimentare(codice.ToString(), nome, int.Parse(prezzo), a, materiale);
            nonAlimentaris.Add(alimentare);
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
            alimentarisFreschi.Add(alimentare);
            codice++;
        }

        public void AggiungiACarrello(object art)
        {

        }

        private void SCONTRINO_Click(object sender, EventArgs e)
        {
            Scontrinos.Visible = true;
            DialogResult dialogResult = MessageBox.Show("Hai la carta fedeltà?", "CARTA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                foreach (Alimentari alimentari in alimentaris)
                {
                    alimentari.Carta = true;
                }
                foreach (ArticoloNonAlimentare alimentari in nonAlimentaris)
                {
                    alimentari.Carta = true;
                }
                foreach (AlimentariFreschi alimentari in alimentarisFreschi)
                {
                    alimentari.Carta = true;
                }
            }



            Scontrinos.Items.Add("ARTICOLI ALIMENTARI:");
            foreach (Alimentari alimentari in alimentaris)
            {
                Scontrinos.Items.Add(alimentari.Stampa());
            }
            Scontrinos.Items.Add("ARTICOLI NON ALIMENTARI:");
            foreach (ArticoloNonAlimentare alimentari in nonAlimentaris)
            {
                Scontrinos.Items.Add(alimentari.Stampa());
            }
            Scontrinos.Items.Add("ARTICOLI ALIMENTARI FRESCHI:");
            foreach (AlimentariFreschi alimentari in alimentarisFreschi)
            {
                Scontrinos.Items.Add(alimentari.Stampa());
            }
        }


        private void Scontrinos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }
    }
}
