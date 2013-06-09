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
            DataTable dta = new DataTable("Table");
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

        }
    }
