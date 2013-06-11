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
    public partial class LäggTillNySpelare : Form
    {
        public LäggTillNySpelare()
        {
            InitializeComponent();
        }

        //Felklick. Vill inte tabort med risk för att förstöra något.
        private void LäggTillNySpelare_Load(object sender, EventArgs e)
        {

        }

        //När användaren klickar på "Avbryt" stängs hela detta form, LäggTillNySpelare.
        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //När användaren kilckar på "OK" sker följande:
        private void OK_button_Click(object sender, EventArgs e)
        {
            //Deklarerar variabeln kon. Står för kön.
            var kon = "";
            
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

            //Om användaren väljer Aktiv i comboboxen får variabeln status värdet Aktiv.
            if (Medlemsstatus_comboBox.Text == "Aktiv")
            {
                status = "Aktiv";
            }

            //Om användaren väljer Vilande i comboboxen får variabeln status värdet Vilande.
            else if (Medlemsstatus_comboBox.Text == "Vilande")
            {
                status = "Vilande";
            }

            //Om användaren väljer Greenfee i comboboxen får variabeln status värdet Greenfee.
            else if (Medlemsstatus_comboBox.Text == "Greenfee")
            {
                status = "Greenfee";
            }

            //Om användaren väljer Junior i comboboxen får variabeln status värdet Junior.
            else if (Medlemsstatus_comboBox.Text == "Junior")
            {
                status = "Junior";
            }

            //Om användaren väljer Ickemedlem i comboboxen får variabeln status värdet Ickemedlem.
            else if (Medlemsstatus_comboBox.Text == "Ickemedlem")
            {
                status = "Ickemedlem";
            }

            //Skapar strängen nyspelare1.
            //Strängen innehåller information om ny spelare. Lägger in golfid, namn, adress, telefonnummer, epost, handicap och kön i databasen, i tabellen person.
            string nyspelare1 = "insert into person (golfid, namn, adress, telefonnummer, epost, handicap, kon) values('" + Golfid_textBox.Text + "', '" + Namn_textBox.Text + "', '" + Adress_textBox.Text + "', '" + Telefonnummer_textBox.Text + "', '" + Epost_textBox.Text + "', " + Handicap_textBox.Text + ", '" + kon + "');";
            //Skapar ett nytt Npgsql kommando, command2.
            NpgsqlCommand command2 = new NpgsqlCommand(nyspelare1, Huvudfönster.conn);
            //Utför kommando, command2.
            command2.ExecuteNonQuery();

            //Skapar strängen nyspelare2.
            //Strängen innehåller information om ny spelare. Lägger in golfid, medlemsstatus och betalt i databasen, i tabellen medlem.
            string nyspelare2 = "insert into medlem (golfid, medlemsstatus, betalt) values('" + Golfid_textBox.Text + "', '" + status + "', '" + BetaltÅr_textBox.Text + "');";
            //Skapar ett nytt Npgsql kommando, command3.
            NpgsqlCommand command3 = new NpgsqlCommand(nyspelare2, Huvudfönster.conn);
            //Utför kommando, command3.
            command3.ExecuteNonQuery();

            //När allt ovan är utfört visas en meddelanderuta.
            MessageBox.Show("Ny spelare är tillagd!");
            //Sedan stängs hela detta form, AnmälDeltagare.
            this.Close(); 
        }

        }

    }
