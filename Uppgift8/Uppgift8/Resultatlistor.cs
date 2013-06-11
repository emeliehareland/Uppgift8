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
    public partial class Resultatlistor : Form
    {
        public Resultatlistor()
        {
            InitializeComponent();
        }

        //När användaren klickar på "Avbryt" stängs hela detta form, Resultatlistor.
        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //När användaren kilckar på "Visa resultat" sker följande:
        private void VisaResultat_button_Click(object sender, EventArgs e)
        {
            //Skapar strängen tavlingid som innehåller det tävling-id som användaren skriver in i Tävlingid_textBox.
            string tavlingid = Tävlingid_textBox.Text;

            //Skapar en tabell som heter dt3 och som innehåller fölande kolumner:
            DataTable dt3 = new DataTable();
            dt3.Columns.Add("golfid", typeof(string));
            dt3.Columns.Add("resultat", typeof(string));

            //Deklarerar variabel klass
            var klass = "";

            //Om "A" är iklickat av användaren får variabel klass värdet A.
            if (A_radioButton.Checked == true)
            {
                klass = "A";
            }

            //Om "B" är iklickat av användaren får variabel klass värdet B.
            else if (B_radioButton.Checked == true)
            {
                klass = "B";
            }

            //Om "C" är iklickat av användaren får variabel klass värdet C.
            else if (C_radioButton.Checked == true)
            {
                klass = "C";
            }

            //Skapar strängen resultatlista.
            //Strängen innehåller information om spelarnas resulat. Hämtar golfid och resultat från databasen, tabellen deltari.
            String resultatlista = "select deltari.golfid, deltari.resultat from deltari where deltari.klass = '" + klass + "' and deltari.tavlingid = " + tavlingid + ";";
            //Skapar ett nytt Npgsql kommando, command17.
            NpgsqlCommand command17 = new NpgsqlCommand(resultatlista, Huvudfönster.conn);
            //Skapar en Npgsql "DataReader", dr6. Samt utför kommando, command17.
            NpgsqlDataReader dr6 = command17.ExecuteReader();

            //Skapar en while-loop.
            while (dr6.Read())
            {
                DataRow row = dt3.NewRow();
                row["golfid"] = dr6["golfid"].ToString();
                row["resultat"] = dr6["resultat"].ToString();

                //Lägger till rader.
                dt3.Rows.Add(row);
            }
            //Stänger DataReader.
            dr6.Close();

            //Skapare en DataView, dv3 och lägger in kolumner och rader från dt3 i dataGrindVeiw1.
            DataView dv3 = new DataView(dt3);
            dataGridView1.DataSource = dv3;
        }
    }
}
