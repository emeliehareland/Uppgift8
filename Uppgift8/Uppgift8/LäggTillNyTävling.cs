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
    public partial class LäggTillNyTävling : Form
    {
        public LäggTillNyTävling()
        {
            InitializeComponent();
        }

        //När användaren klickar på "Avbryt" stängs hela detta form, LäggTillNyTävling.
        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //När användaren kilckar på "OK" sker följande:
        private void OK_button_Click(object sender, EventArgs e)
        {
            //Deklarerar att tävlingsdatum är datumet som väljs i dateTimePicker1.  
            DateTime tävlingsdatum = this.dateTimePicker1.Value.Date;

            //Deklarerar att sista anmälningsdatum är datumet som väljs i dateTimePicker2. 
            DateTime sistaAnmälningsdatum = this.dateTimePicker2.Value.Date;

            //Skapar strängen nytävling.
            //Strängen innehåller information om ny tävling. Lägger in namn,  tävlingsdatum och sista anmälaningsdatum i databasen, i tabellen tavling.
            string nytävling = "insert into tavling (namn,  datum, sistaanmalan) values ('" + Tävlingsnamn_textBox.Text + "', '" + tävlingsdatum.ToString() + "', '" + sistaAnmälningsdatum.ToString() + "'); SELECT CURRVAL(pg_get_serial_sequence('tavling','tavlingid'))";
            //Skapar ett nytt Npgsql kommando, command2.
            NpgsqlCommand command4 = new NpgsqlCommand(nytävling, Huvudfönster.conn);
            //Skapar en Npgsql "DataReader", dr1. Samt utför kommando, command4.
            NpgsqlDataReader dr1 = command4.ExecuteReader();

            //tavlingid dvs. tävling-ID sätts ett nummer högre för varje ny tävling som läggs till.
            dr1.Read();
            int tavlingid = Convert.ToInt32(dr1["currval"]);
            //Stänger "DataReader".
            dr1.Close();

            //Skapar strängen klassa.
            //Strängen innehåller information om tävlingsklass A. Lägger in klassnamn, från-värde, till-värde och tävling-ID i databasen, i tabellen klass.
            string klassa = "insert into klass (klassnamn, franvarde, tillvarde, tavlingid) values ('A', " + AFrån_textBox.Text + ", " + ATill_textBox.Text + ", " + tavlingid.ToString() + ")";
            //Skapar ett nytt Npgsql kommando, command5.
            NpgsqlCommand command5 = new NpgsqlCommand(klassa, Huvudfönster.conn);
            //Utför kommando, command5.
            command5.ExecuteNonQuery();

            //Skapar strängen klassb.
            //Strängen innehåller information om tävlingsklass B. Lägger in klassnamn, från-värde, till-värde och tävling-ID i databasen, i tabellen klass.
            string klassb = "insert into klass (klassnamn, franvarde, tillvarde, tavlingid) values ('B', " + BFrån_textBox.Text + ", " + BTill_textBox.Text + ", " + tavlingid.ToString() + ")";
            //Skapar ett nytt Npgsql kommando, command6.
            NpgsqlCommand command6 = new NpgsqlCommand(klassb, Huvudfönster.conn);
            //Utför kommando, command6.
            command6.ExecuteNonQuery();

            //Skapar strängen klassc.
            //Strängen innehåller information om tävlingsklass C. Lägger in klassnamn, från-värde, till-värde och tävling-ID i databasen, i tabellen klass.
            string klassc = "insert into klass (klassnamn, franvarde, tillvarde, tavlingid) values ('C', " + CFrån_textBox.Text + ", " + CTill_textBox.Text + ", " + tavlingid.ToString() + ")";
            //Skapar ett nytt Npgsql kommando, command7.
            NpgsqlCommand command7 = new NpgsqlCommand(klassc, Huvudfönster.conn);
            //Utför kommando, command7.
            command7.ExecuteNonQuery();

            //När allt ovan är utfört visas en meddelanderuta.
            MessageBox.Show("Ny tävling är tillagd!");
            //Sedan stängs hela detta form, LäggTillNyTävling.
            this.Close();
        } 
    }
}
