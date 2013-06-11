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
//Lägger till Npgsql.

namespace Uppgift8
{
    public partial class AnmälDeltagare : Form
    {
        public AnmälDeltagare()
        {
            InitializeComponent();
        }

        //När användaren klickar på "Avbryt" stängs hela detta form, AnmälDeltagare.
        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //När användaren kilckar på "OK" sker följande:
        private void OK_button_Click(object sender, EventArgs e)
        {
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

            //Skapar strängen anmaldeltagare.
            //Strängen innehåller information om tävlingsdeltagare. Lägger in golfid, tävlingid och klass i databasen, i tabellen deltari.
            string anmaldeltagare = "insert into deltari (golfid, tavlingid, klass) values ('" + Golfid_textBox.Text + "'," + Tävlingid_textBox.Text + ",'" + klass + "')";
            //Skapar ett nytt Npgsql-kommando, command1.
            NpgsqlCommand command1 = new NpgsqlCommand(anmaldeltagare, Huvudfönster.conn);
            //Utför kommando, command1.
            command1.ExecuteNonQuery();


            //När allt ovan är utfört visas en meddelanderuta.
            MessageBox.Show("Spelare är nu anmäld till tävling!");
            //Sedan stängs hela detta form, AnmälDeltagare.
            this.Close();
        }

    }
}
