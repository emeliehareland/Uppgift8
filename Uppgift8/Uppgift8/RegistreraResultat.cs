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
    public partial class RegistreraResultat : Form
    {
        public RegistreraResultat()
        {
            InitializeComponent();
        }

        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {          
            // Lägger in information om resultat  i databasen, tabell deltari. 
            string in_resultat = "update deltari set resultat = " + Resultat_textBox.Text + " where golfid = '" + Golfid_textBox.Text + "' and tavlingid = " + Tävlingid_textBox.Text + ";";
            NpgsqlCommand command_resultat = new NpgsqlCommand(in_resultat, Huvudfönster.conn);
            command_resultat.ExecuteNonQuery();

            MessageBox.Show("Nytt resultat är registrerat!");
            this.Close();
        }
    }
}
