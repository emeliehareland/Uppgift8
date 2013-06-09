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
    public partial class LäggTillNySpelare : Form
    {
        public LäggTillNySpelare()
        {
            InitializeComponent();
        }

        private void LäggTillNySpelare_Load(object sender, EventArgs e)
        {

        }

        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_button_Click(object sender, EventArgs e)
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

            if (Medlemsstatus_comboBox.Text == "Aktiv")
            {
                status = "Aktiv";
            }
            else if (Medlemsstatus_comboBox.Text == "Vilande")
            {
                status = "Vilande";
            }
            else if (Medlemsstatus_comboBox.Text == "Greenfee")
            {
                status = "Greenfee";
            }
            else if (Medlemsstatus_comboBox.Text == "Junior")
            {
                status = "Junior";
            }
            else if (Medlemsstatus_comboBox.Text == "Ickemedlem")
            {
                status = "Ickemedlem";
            }


            string iniperson = "insert into person (golfid, namn, adress, telefonnummer, epost, handicap, kon) values('" + Golfid_textBox.Text + "', '" + Namn_textBox.Text + "', '" + Adress_textBox.Text + "', '" + Telefonnummer_textBox.Text + "', '" + Epost_textBox.Text + "', " + Handicap_textBox.Text + ", '" + kon + "');";
            NpgsqlCommand command_person = new NpgsqlCommand(iniperson, Huvudfönster.conn);
            command_person.ExecuteNonQuery();

            string inimedlem = "insert into medlem (golfid, medlemsstatus, betalt) values('" + Golfid_textBox.Text + "', '" + status + "', '" + BetaltÅr_textBox.Text + "');";
            NpgsqlCommand command_medlem = new NpgsqlCommand(inimedlem, Huvudfönster.conn);
            command_medlem.ExecuteNonQuery();

            MessageBox.Show("Ny spelare är tillagd!"); 
            this.Close(); 
        }

        }

    }
