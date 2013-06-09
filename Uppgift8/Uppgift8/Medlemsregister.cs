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
        }

        }

