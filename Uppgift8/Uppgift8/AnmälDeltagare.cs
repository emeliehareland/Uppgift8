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
    public partial class AnmälDeltagare : Form
    {
        public AnmälDeltagare()
        {
            InitializeComponent();
        }

        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
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


            // Lägger in information om tävlingsdeltagare i databasen, tabell deltari.
            string in_i_deltari_reg = "insert into deltari (golfid, tavlingid, klass) values ('" + Golfid_textBox.Text + "'," + Tävlingid_textBox.Text + ",'" + klass + "')";
            NpgsqlCommand command_deltari_reg = new NpgsqlCommand(in_i_deltari_reg, Huvudfönster.conn);
            command_deltari_reg.ExecuteNonQuery();

            MessageBox.Show("Spelare är nu anmäld till tävling!");
            this.Close();
        }

    }
}
