using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Uppgift8
{
    public partial class RegistreraResultat : Form
    {
        public RegistreraResultat()
        {
            InitializeComponent();
        }

        //När användaren klickar på "Avbryt" stängs hela detta form, RegistreraResultat.
        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //När användaren kilckar på "OK" sker följande:
        private void OK_button_Click(object sender, EventArgs e)
        {
            //Skapar strängen resultat.
            //Strängen innehåller information om resultat. Uppdaterar tabellen och lägger in resultat i databasen, tabell deltari. 
            string resultat = "update deltari set resultat = " + Resultat_textBox.Text + " where golfid = '" + Golfid_textBox.Text + "' and tavlingid = " + Tävlingid_textBox.Text + ";";
            //Skapar ett nytt Npgsql kommando, command16.
            NpgsqlCommand command16 = new NpgsqlCommand(resultat, Huvudfönster.conn);
            //Utför kommando, command16.
            command16.ExecuteNonQuery();

            //När allt ovan är utfört visas en meddelanderuta.
            MessageBox.Show("Nytt resultat är registrerat!");
            //Sedan stängs hela detta form, RegistreraResultat.
            this.Close();
        }
    }
}
