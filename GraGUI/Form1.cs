using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        public static Gra g;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNowaGra_Click(object sender, EventArgs e)
        {
            grpBoxLosowanie.Visible = true;
            btnNowaGra.Enabled = false;
        }

        private void btnLosuj_Click(object sender, EventArgs e)
        {
            // todo: try-catch
            int a;
            int b;
            try
            {
                 a = int.Parse(textBoxOd.Text);
                 b = int.Parse(textBoxDo.Text);
            }
            catch
            {
                a = 1;
                b = 100;

            }
            g = new Gra(a, b);

            textBoxOd.Enabled = false;
            textBoxDo.Enabled = false;
            btnLosuj.Enabled = false;
            groupBox_Gra.Visible = true;
            button_historia.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_sprawdz_Click(object sender, EventArgs e)
        {
            int podana_liczba;

            try
            {
                podana_liczba = int.Parse(textBox_podajliczbe.Text);
            }

            catch
            {
                podana_liczba = 0;
            }

            switch(g.Ocena(podana_liczba))
            {
                case Gra.Odpowiedz.ZaMalo:
                    label_ocena.Text = "Za Mało";
                    break;

                case Gra.Odpowiedz.Trafiono:
                    label_ocena.Text = "Trafiono";
                    break;

                case Gra.Odpowiedz.ZaDuzo:
                    label_ocena.Text = "Za Dużo";
                    break;

            }

            label_wynik0.Text = g.LicznikRuchow.ToString();

            if(g.Stan == Gra.StanGry.Odgadnieta)
            {
                
               
                
                DialogResult ok = MessageBox.Show("Brawo zgadłeś", "Wygrana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if( ok == DialogResult.OK)
                {
                    grpBoxLosowanie.Visible = false;
                    groupBox_Gra.Visible = false;
                    btnNowaGra.Enabled = true;
                    textBoxDo.Enabled = true;
                    textBoxOd.Enabled = true;
                    btnLosuj.Enabled = true;



                }
                
            }

            

            
                      
        }

        private void grpBoxLosowanie_Enter(object sender, EventArgs e)
        {

        }

        private void button_poddaj_Click(object sender, EventArgs e)
        {
            g.Poddaj();
            if(g.Stan == Gra.StanGry.Poddana)
            {
                DialogResult ok = MessageBox.Show("Przegrałeś", "Porażka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(ok == DialogResult.OK)
                {
                    grpBoxLosowanie.Visible = false;
                    groupBox_Gra.Visible = false;
                    btnNowaGra.Enabled = true;
                    textBoxDo.Enabled = true;
                    textBoxOd.Enabled = true;
                    btnLosuj.Enabled = true;
                }

                
            }
        }

        private void button_historia_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
