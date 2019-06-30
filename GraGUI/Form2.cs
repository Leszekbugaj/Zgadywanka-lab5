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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            listView_historia.Columns.Add("Wylosowana", -2, HorizontalAlignment.Left);
            listView_historia.Columns.Add("Odpowiedź", -2, HorizontalAlignment.Left);
            listView_historia.Columns.Add("Czas", -2, HorizontalAlignment.Left);

            foreach(Gra.Ruch ruch in Form1.g.Historia)
            {
                ListViewItem wartosc = new ListViewItem(ruch.propozycja.ToString());

                switch (ruch.odpowiedz)
                {
                    case Gra.Odpowiedz.ZaMalo:
                        wartosc.SubItems.Add("Za mało");
                        break;

                    case Gra.Odpowiedz.Trafiono:
                        wartosc.SubItems.Add("Trafiono");
                        break;

                    case Gra.Odpowiedz.ZaDuzo:
                        wartosc.SubItems.Add("Za dużo");
                        break;
                }

                wartosc.SubItems.Add(ruch.kiedy.ToString());
                listView_historia.Items.Add(wartosc);
            }

            Controls.Add(listView_historia);



        }
    }

}
