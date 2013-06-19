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
    public partial class Medlemsregister : Form
    {
        public Medlemsregister()
        {
            InitializeComponent();
        }

        //När användaren klickar på "Avbryt" stängs hela detta form, Medlemsregister.
        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //När användaren kilckar på "Visa alla spelare" sker följande
        private void VisaAllaSpelare_button_Click(object sender, EventArgs e)
        {
            //Skapar en tabell som heter dt1 och som innehåller fölande kolumner:
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("golfid", typeof(string));
            dt1.Columns.Add("namn", typeof(string));
            dt1.Columns.Add("adress", typeof(string));
            dt1.Columns.Add("telefonnummer", typeof(string));
            dt1.Columns.Add("epost", typeof(string));
            dt1.Columns.Add("handicap", typeof(string));
            dt1.Columns.Add("kon", typeof(string));
            dt1.Columns.Add("medlemsstatus", typeof(string));
            dt1.Columns.Add("betalt", typeof(string));

            //Skapar strängen allaspelare.
            //Strängen innehåller information om spelare. Hämtar golfid, namn, adress, telefonnummer, epost, handicap och kön från databasen, tabellen person medlemsstatus och betalningsår från tabellen medlem.
            String allaspelare = "select person.golfid, person.namn, person.adress, person.telefonnummer, person.epost, person.handicap, person.kon, medlem.medlemsstatus, medlem.betalt from person, medlem where person.golfid = medlem.golfid;";
            //Skapar ett nytt Npgsql kommando, command8.
            NpgsqlCommand command8 = new NpgsqlCommand(allaspelare, Huvudfönster.conn);
            //Skapar en Npgsql "DataReader", dr2. Samt utför kommando, command8.
            NpgsqlDataReader dr2 = command8.ExecuteReader();

            //Skapar en while-loop.
            while (dr2.Read())
            {
                DataRow row = dt1.NewRow();
                row["golfid"] = dr2["golfid"].ToString();
                row["namn"] = dr2["namn"].ToString();
                row["adress"] = dr2["adress"].ToString();
                row["telefonnummer"] = dr2["telefonnummer"].ToString();
                row["epost"] = dr2["epost"].ToString();
                row["handicap"] = dr2["handicap"].ToString();
                row["kon"] = dr2["kon"].ToString();
                row["medlemsstatus"] = dr2["medlemsstatus"].ToString();
                row["betalt"] = dr2["betalt"].ToString();

                //Lägger till rader.
                dt1.Rows.Add(row);
            }
            //Stänger DataReader.
            dr2.Close();

            //Skapare en DataView, dv1 och lägger in kolumner och rader från dt1 i dataGrindVeiw1.
            DataView dv1 = new DataView(dt1);
            dataGridView1.DataSource = dv1;
        }

        //När användaren kilckar på "Sök spelare" sker följande
        private void SökSpelare_button_Click(object sender, EventArgs e)
        {
            //Skapar strängen id som innehåller det golf-id som användaren skriver in i Golfid_textBox1.
            string id = Golfid_textBox1.Text;

            //Skapar en tabell som heter dt2 och som innehåller fölande kolumner:
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("golfid", typeof(string));
            dt2.Columns.Add("namn", typeof(string));
            dt2.Columns.Add("adress", typeof(string));
            dt2.Columns.Add("telefonnummer", typeof(string));
            dt2.Columns.Add("epost", typeof(string));
            dt2.Columns.Add("handicap", typeof(string));
            dt2.Columns.Add("kon", typeof(string));
            dt2.Columns.Add("medlemsstatus", typeof(string));
            dt2.Columns.Add("betalt", typeof(string));

            //Skapar strängen enspelare.
            //Strängen innehåller information om spelare. Hämtar golfid, namn, adress, telefonnummer, epost, handicap och kön från databasen, tabellen person medlemsstatus och betalningsår från tabellen medlem.
            String enspelare = "select person.golfid, person.namn, person.adress, person.telefonnummer, person.epost, person.handicap, person.kon, medlem.medlemsstatus, medlem.betalt from person, medlem where person.golfid = '" + id + "' and medlem.golfid = '" + id + "';";
            //Skapar ett nytt Npgsql kommando, command9.
            NpgsqlCommand command9 = new NpgsqlCommand(enspelare, Huvudfönster.conn);
            //Skapar en Npgsql "DataReader", dr3. Samt utför kommando, command9.
            NpgsqlDataReader dr3 = command9.ExecuteReader();

            //Skapar en while-loop.
            while (dr3.Read())
            {
                DataRow row = dt2.NewRow();
                row["golfid"] = dr3["golfid"].ToString();
                row["namn"] = dr3["namn"].ToString();
                row["adress"] = dr3["adress"].ToString();
                row["telefonnummer"] = dr3["telefonnummer"].ToString();
                row["epost"] = dr3["epost"].ToString();
                row["handicap"] = dr3["handicap"].ToString();
                row["kon"] = dr3["kon"].ToString();
                row["medlemsstatus"] = dr3["medlemsstatus"].ToString();
                row["betalt"] = dr3["betalt"].ToString();

                //Lägger till rader.
                dt2.Rows.Add(row);
            }
            //Stänger DataReader.
            dr3.Close();

            //Skapare en DataView, dv2 och lägger in kolumner och rader från dt2 i dataGrindVeiw1.
            DataView dv2 = new DataView(dt2);
            dataGridView1.DataSource = dv2;
        }

        public string markeratid()
        {
            //Skapar int nummer som innehåller en vald rad i dataGridView1.
            int nummer = dataGridView1.CurrentRow.Index;

            //Skapar strängen valtid.
            //Strängen innehåller information om spelare. Hämtar golfid från databasen, tabellen person.
            String valtid = "select golfid from person;";
            //Skapar ett nytt Npgsql kommando, command10.
            NpgsqlCommand command10 = new NpgsqlCommand(valtid, Huvudfönster.conn);
            //Skapar en Npgsql "DataReader", dr4. Samt utför kommando, command10.
            NpgsqlDataReader dr4 = command10.ExecuteReader();

            //Skapar strängen id. 
            //Skapar int räknare och sätter denna till 0.
            string id = "";
            int räknare = 0;

            //Skapar en while-loop.
            while (dr4.Read())
            {
                //Gör en uträkning för golfid.
                if (räknare == nummer)
                {
                    id = dr4["golfid"].ToString();
                }
                räknare = räknare + 1;
            }

            //Stänger DataReader.
            dr4.Close();

            return id;
        }

        //När användaren kilckar på "Radera markerad" sker följande
        private void RaderaMarkerad_button_Click(object sender, EventArgs e)
        {
            //Använder strängen id för att se vilket golfid det är som användaren har markerat och valt att radera.
            string id = markeratid();

            //Skapar strängen tabort1.
            //Strängen innehåller information om vilken spelare som ska raderas. Raderar golfid från databasen, tabellen medlem.
            String tabort1 = "delete from deltari where golfid = '" + id + "';";
            //Skapar ett nytt Npgsql kommando, command11.
            NpgsqlCommand command11 = new NpgsqlCommand(tabort1, Huvudfönster.conn);
            //Utför kommando, command12.
            command11.ExecuteNonQuery();

            //Skapar strängen tabort1.
            //Strängen innehåller information om vilken spelare som ska raderas. Raderar golfid från databasen, tabellen person.
            String tabort2 = "delete from person where golfid = '" + id + "';";
            //Skapar ett nytt Npgsql kommando, command12.
            NpgsqlCommand command12 = new NpgsqlCommand(tabort2, Huvudfönster.conn);
            //Utför kommando, command12.
            command12.ExecuteNonQuery();

            //Skapar strängen tabort2.
            //Strängen innehåller information om vilken spelare som ska raderas. Raderar golfid från databasen, tabellen medlem.
            String tabort3 = "delete from medlem where golfid = '" + id + "';";
            //Skapar ett nytt Npgsql kommando, command122.
            NpgsqlCommand command122 = new NpgsqlCommand(tabort3, Huvudfönster.conn);
            //Utför kommando, command122.
            command122.ExecuteNonQuery();

            //När allt ovan är utfört visas en meddelanderuta.
            MessageBox.Show("Vald spelare är nu borttagen ur databasen!");
        }

        //När användaren kilckar på "Ändra markerad" sker följande
        private void ÄndraMarkerad_button_Click(object sender, EventArgs e)
        {
            //Använder strängen id för att se vilket golfid det är som användaren har markerat och valt att ändra.
            string id = markeratid();

            //Skapar strängen attändra.
            //Strängen innehåller information om spelare. Hämtar golfid, namn, adress, telefonnummer, epost, handicap och kön från databasen, tabellen person medlemsstatus och betalningsår från tabellen medlem.
            String attändra = "select person.golfid, person.namn, person.adress, person.telefonnummer, person.epost, person.handicap, person.kon, medlem.medlemsstatus, medlem.betalt from person, medlem where person.golfid = '" + id + "' and medlem.golfid = '" + id + "';";
            //Skapar ett nytt Npgsql kommando, command13.
            NpgsqlCommand command13 = new NpgsqlCommand(attändra, Huvudfönster.conn);
            //Skapar en Npgsql "DataReader", dr5. Samt utför kommando, command13.
            NpgsqlDataReader dr5 = command13.ExecuteReader();

            //Skapar en while-loop.
            while (dr5.Read())
            {
                Golfid_textBox2.Text = dr5["golfid"].ToString();
                Namn_textBox.Text = dr5["namn"].ToString();
                Adress_textBox.Text = dr5["adress"].ToString();
                Telefonnr_textBox.Text = dr5["telefonnummer"].ToString();
                Epost_textBox.Text = dr5["epost"].ToString();
                Handicap_textBox.Text = dr5["handicap"].ToString();
                Kön_comboBox.Text = dr5["kon"].ToString();
                MedlemsStatus_comboBox.Text = dr5["medlemsstatus"].ToString();
                BetaltÅr_textBox.Text = dr5["betalt"].ToString();

                //Om kon (kön) som hämtas från databasen är Man ska Kön_comboBox visa Man.
                if (dr5["kon"].ToString() == "Man")
                {
                    Kön_comboBox.Text = "Man";
                }

                //Om kon (kön) som hämtas från databasen är Kvinna ska Kön_comboBox visa Kvinna.
                else if (dr5["kon"].ToString() == "Kvinna")
                {
                    Kön_comboBox.Text = "Kvinna";
                }

                if (dr5["medlemsstatus"].ToString() == "Aktiv")
                {
                    MedlemsStatus_comboBox.Text = "Aktiv";
                }
                else if (dr5["medlemsstatus"].ToString() == "Vilande")
                {
                    MedlemsStatus_comboBox.Text = "Vilande";
                }
                else if (dr5["medlemsstatus"].ToString() == "Greenfee")
                {
                    MedlemsStatus_comboBox.Text = "Greenfee";
                }
                else if (dr5["medlemsstatus"].ToString() == "Junior")
                {
                    MedlemsStatus_comboBox.Text = "Junior";
                }
                else if (dr5["medlemsstatus"].ToString() == "Ickemedlem")
                {
                    MedlemsStatus_comboBox.Text = "Ickemedlem";
                }
            }
            //Stänger DataReader.
            dr5.Close();

            //Gör så att Ändra_groupBox blir synlig när användren valt "Ändra markerad".
            Ändra_groupBox.Visible = true;
        }

        //När användaren kilckar på "Spara" sker följande
        private void Spara_button_Click(object sender, EventArgs e)
        {
            //Deklarerar variabeln kon, står för kön.
            var kon = "";

            // --------------------------------------
            // Prova detta istället för nedanstående? 
            // kon = Kön_comboBox.Text; 
            // -------------------------------------

            //Om användaren väljer Kvinna i comboboxen får variabeln kon värdet Kvinna.
            if (Kön_comboBox.Text == "Kvinna")
            {
                kon = "Kvinna";
            }

            //Om användaren väljer Man i comboboxen får variabeln kon värdet Man.
            else if (Kön_comboBox.Text == "Man")
            {
                kon = "Man";
            }

            //Deklarerar variabeln status.
            var status = "";

            // --------------------------------------
            // Prova detta istället för nedanstående? 
            // status = Medlemsstatus_comboBox.Text; 
            // -------------------------------------

            //Om användaren väljer Aktiv i comboboxen får variabeln status värdet Aktiv.
            if (MedlemsStatus_comboBox.Text == "Aktiv")
            {
                status = "Aktiv";
            }

            //Om användaren väljer Vilande i comboboxen får variabeln status värdet Vilande.
            else if (MedlemsStatus_comboBox.Text == "Vilande")
            {
                status = "Vilande";
            }

            //Om användaren väljer Greenfee i comboboxen får variabeln status värdet Greenfee.
            else if (MedlemsStatus_comboBox.Text == "Greenfee")
            {
                status = "Greenfee";
            }

            //Om användaren väljer Junior i comboboxen får variabeln status värdet Junior.
            else if (MedlemsStatus_comboBox.Text == "Junior")
            {
                status = "Junior";
            }

            //Om användaren väljer Ickemedlem i comboboxen får variabeln status värdet Ickemedlem.
            else if (MedlemsStatus_comboBox.Text == "Ickemedlem")
            {
                status = "Ickemedlem";
            }

            //Använder strängen id för att se vilket golfid det är som användaren har markerat och valt att ändra.
            string id = markeratid();

            //Skapar strängen uppdatera1.
            //Strängen innehåller uppdaterad information om spelare. Lägger in namn, adress, telefonnummer, epost, handicap och kön i databasen, i tabellen person.
            string uppdatera1 = "update person set namn = '" + Namn_textBox.Text + "', adress = '" + Adress_textBox.Text + "', telefonnummer = '" + Telefonnr_textBox.Text + "', epost = '" + Epost_textBox.Text + "', handicap = " + Handicap_textBox.Text + ", kon = '" + kon + "' where golfid = '" + Golfid_textBox2.Text + "';";
            //Skapar ett nytt Npgsql kommando, command14.
            NpgsqlCommand command14 = new NpgsqlCommand(uppdatera1, Huvudfönster.conn);
            //Utför kommando, command14.
            command14.ExecuteNonQuery();

            //Gör så att Ändra_groupBox blir osynlig när användaren valt ändrat den vald spelare.
            Ändra_groupBox.Visible = false;

            //När allt ovan är utfört visas en meddelanderuta.
            MessageBox.Show("Uppgifter för spelare ändrade!");

            //Skapar strängen uppdatera2.
            //Strängen innehåller uppdaterad information om spelare. Lägger in golfid, medlemsstatus och betalt i databasen, i tabellen medlem.
            string uppdatera2 = "update medlem set medlemsstatus = '" + status + "', betalt = '" + BetaltÅr_textBox.Text + "' where golfid = '" + Golfid_textBox2.Text + "';";
            //Skapar ett nytt Npgsql kommando, command15.
            NpgsqlCommand command15 = new NpgsqlCommand(uppdatera2, Huvudfönster.conn);
            //Utför kommando, command15.
            command15.ExecuteNonQuery();
            
            //Gör så att Ändra_groupBox blir osynlig när användaren valt ändrat den vald spelare.
            Ändra_groupBox.Visible = false;

            //När allt ovan är utfört visas en meddelanderuta.
            MessageBox.Show("Uppgifter för spelare ändrade!");


            //Programmet buggar ur om man endast ändrar innehållet i comboboxarna, ändrar man ex. handicap samtidigt fungerar det...?
        }
    }
}

