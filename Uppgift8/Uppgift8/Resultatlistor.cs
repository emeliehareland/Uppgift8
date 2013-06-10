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

        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisaResultat_button_Click(object sender, EventArgs e)
        {
            string tavlingid = Tävlingid_textBox.Text;

            // dtr = Data Table Resultat
            DataTable dtr = new DataTable("Tabell");
            dtr.Columns.Add("golfid", typeof(string));
            dtr.Columns.Add("resultat", typeof(string));

            // väljer klass att hämta resultat och detagare från
            var klass = "";

            if (A_radioButton.Checked == true)
            {
                klass = "A";
            }
            else if (B_radioButton.Checked == true)
            {
                klass = "B";
            }
            else if (C_radioButton.Checked == true)
            {
                klass = "C";
            }

            // res = resultat
            // drr = Data Row Resultat
            String res = "select deltari.golfid, deltari.resultat from deltari where deltari.klass = '" + klass + "' and deltari.tavlingid = " + tavlingid + ";";
            NpgsqlCommand command = new NpgsqlCommand(res, Huvudfönster.conn);
            NpgsqlDataReader drr = command.ExecuteReader();

            while (drr.Read())
            {
                DataRow row = dtr.NewRow();
                row["golfid"] = drr["golfid"].ToString();
                row["resultat"] = drr["resultat"].ToString();

                dtr.Rows.Add(row);
            }
            drr.Close();

            // dvr = Data View Resultat
            DataView dvr = new DataView(dtr);
            dataGridView1.DataSource = dvr;
        }
    }
}
