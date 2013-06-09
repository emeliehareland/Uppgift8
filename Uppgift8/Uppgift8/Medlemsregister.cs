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

        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisaAllaSpelare_button_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable("Tabell");
            dta.Columns.Add("golfid", typeof(string));
            dta.Columns.Add("namn", typeof(string));
            dta.Columns.Add("adress", typeof(string));
            dta.Columns.Add("telefonnummer", typeof(string));
            dta.Columns.Add("epost", typeof(string));
            dta.Columns.Add("handicap", typeof(string));
            dta.Columns.Add("kon", typeof(string));
            dta.Columns.Add("medlemsstatus", typeof(string));
            dta.Columns.Add("betalt", typeof(string));

            String alla = "select person.golfid, person.namn, person.adress, person.telefonnummer, person.epost, person.handicap, person.kon, medlem.medlemsstatus, medlem.betalt from person, medlem where person.golfid = medlem.golfid;";
            NpgsqlCommand command = new NpgsqlCommand(alla, Huvudfönster.conn);
            NpgsqlDataReader dra = command.ExecuteReader();

            while (dra.Read())
            {
                DataRow row = dta.NewRow();
                row["golfid"] = dra["golfid"].ToString();
                row["namn"] = dra["namn"].ToString();
                row["adress"] = dra["adress"].ToString();
                row["telefonnummer"] = dra["telefonnummer"].ToString();
                row["epost"] = dra["epost"].ToString();
                row["handicap"] = dra["handicap"].ToString();
                row["kon"] = dra["kon"].ToString();
                row["medlemsstatus"] = dra["medlemsstatus"].ToString();
                row["betalt"] = dra["betalt"].ToString();

                dta.Rows.Add(row);
            }
            dra.Close();

            DataView dva = new DataView(dta);
            dataGridView1.DataSource = dva;
        }

        private void SökSpelare_button_Click(object sender, EventArgs e)
        {
            string id = Golfid_textBox1.Text;

            DataTable dte = new DataTable("Tabell");
            dte.Columns.Add("golfid", typeof(string));
            dte.Columns.Add("namn", typeof(string));
            dte.Columns.Add("adress", typeof(string));
            dte.Columns.Add("telefonnummer", typeof(string));
            dte.Columns.Add("epost", typeof(string));
            dte.Columns.Add("handicap", typeof(string));
            dte.Columns.Add("kon", typeof(string));
            dte.Columns.Add("medlemsstatus", typeof(string));
            dte.Columns.Add("betalt", typeof(string));

            String en = "select person.golfid, person.namn, person.adress, person.telefonnummer, person.epost, person.handicap, person.kon, medlem.medlemsstatus, medlem.betalt from person, medlem where person.golfid = '" + id + "' and medlem.golfid = '" + id + "';";
            NpgsqlCommand command = new NpgsqlCommand(en, Huvudfönster.conn);
            NpgsqlDataReader dre = command.ExecuteReader();

            while (dre.Read())
            {
                DataRow row = dte.NewRow();
                row["golfid"] = dre["golfid"].ToString();
                row["namn"] = dre["namn"].ToString();
                row["adress"] = dre["adress"].ToString();
                row["telefonnummer"] = dre["telefonnummer"].ToString();
                row["epost"] = dre["epost"].ToString();
                row["handicap"] = dre["handicap"].ToString();
                row["kon"] = dre["kon"].ToString();
                row["medlemsstatus"] = dre["medlemsstatus"].ToString();
                row["betalt"] = dre["betalt"].ToString();

                dte.Rows.Add(row);
            }
            dre.Close();

            DataView db = new DataView(dte);
            dataGridView1.DataSource = db;
        }

        public string markeratid()
        {
            int nummer = dataGridView1.CurrentRow.Index;

            String valtid = "select golfid from person;";
            NpgsqlCommand command3 = new NpgsqlCommand(valtid, Huvudfönster.conn);
            NpgsqlDataReader drid = command3.ExecuteReader();

            string idet = "";
            int raknare = 0;
            while (drid.Read())
            {
                if (raknare == nummer)
                {
                    idet = drid["golfid"].ToString();
                }
                raknare = raknare + 1;
            }

            drid.Close();

            return idet;
        }

        private void RaderaMarkerad_button_Click(object sender, EventArgs e)
        {
            string id = markeratid();

            String tabort1 = "delete from person where golfid = '" + id + "';";
            NpgsqlCommand command_tabort1 = new NpgsqlCommand(tabort1, Huvudfönster.conn);
            command_tabort1.ExecuteNonQuery();

            String tabort2 = "delete from medlem where golfid = '" + id + "';";
            NpgsqlCommand command_tabort2 = new NpgsqlCommand(tabort2, Huvudfönster.conn);
            command_tabort2.ExecuteNonQuery();

            MessageBox.Show("Vald spelare är nu borttagen ur databasen!");


        }

        private void ÄndraMarkerad_button_Click(object sender, EventArgs e)
        {
            string id = markeratid();
            String ändra = "select person.golfid, person.namn, person.adress, person.telefonnummer, person.epost, person.handicap, person.kon, medlem.medlemsstatus, medlem.betalt from person, medlem where person.golfid = '" + id + "' and medlem.golfid = '" + id + "';";
            NpgsqlCommand command_ändra = new NpgsqlCommand(ändra, Huvudfönster.conn);
            NpgsqlDataReader drä = command_ändra.ExecuteReader();

            while (drä.Read())
            {
                Golfid_textBox2.Text = drä["golfid"].ToString();
                Namn_textBox.Text = drä["namn"].ToString();
                Adress_textBox.Text = drä["adress"].ToString();
                Telefonnr_textBox.Text = drä["telefonnummer"].ToString();
                Epost_textBox.Text = drä["epost"].ToString();
                Handicap_textBox.Text = drä["handicap"].ToString();
                MedlemsStatus_comboBox.Text = drä["medlemsstatus"].ToString();
                BetaltÅr_textBox.Text = drä["betalt"].ToString();

                if (drä["kon"].ToString() == "Man")
                {
                    Kön_comboBox.Text = "Man";
                }
                else if (drä["kon"].ToString() == "Kvinna")
                {
                    Kön_comboBox.Text = "Kvinna";
                }

            }
            drä.Close();

            Ändra_groupBox.Visible = true;
        }

        private void Spara_button_Click(object sender, EventArgs e)
        {

            var kon = "";

            if (Kön_comboBox.Text == "Kvinna")
            {
                kon = "Kvinna";
            }
            else if (Kön_comboBox.Text == "Man")
            {
                kon = "Man";
            }


            var status = "";

            if (MedlemsStatus_comboBox.Text == "Aktiv")
            {
                status = "Aktiv";
            }
            else if (MedlemsStatus_comboBox.Text == "Vilande")
            {
                status = "Vilande";
            }
            else if (MedlemsStatus_comboBox.Text == "Greenfee")
            {
                status = "Greenfee";
            }
            else if (MedlemsStatus_comboBox.Text == "Junior")
            {
                status = "Junior";
            }
            else if (MedlemsStatus_comboBox.Text == "Ickemedlem")
            {
                status = "Ickemedlem";
            }

            string id = markeratid();

            string updatera_p = "update person set namn = '" + Namn_textBox.Text + "', adress = '" + Adress_textBox.Text + "', telefonnummer = '" + Telefonnr_textBox.Text + "', epost = '" + Epost_textBox.Text + "', handicap = " + Handicap_textBox.Text + ", kon = '" + kon + "' where golfid = '" + Golfid_textBox2.Text + "';";
            NpgsqlCommand command_uppdatera_p = new NpgsqlCommand(updatera_p, Huvudfönster.conn);
            command_uppdatera_p.ExecuteNonQuery();

            string updatera_m = "update medlem set medlemsstatus = '" + status + "', betalt = '" + BetaltÅr_textBox.Text + "' where golfid = '" + Golfid_textBox2.Text + "';";
            NpgsqlCommand command_uppdatera_m = new NpgsqlCommand(updatera_m, Huvudfönster.conn);
            command_uppdatera_m.ExecuteNonQuery();

            MessageBox.Show("Uppgifter för spelare ändrade!");
        }
    }
}

