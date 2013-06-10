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
    public partial class LäggTillNyTävling : Form
    {
        public LäggTillNyTävling()
        {
            InitializeComponent();
        }

        private void Avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void OK_button_Click(object sender, EventArgs e)
        { 
           // Lägger in information om tävling i databasen, tabell tavling.  
            DateTime tävlingsdatum = this.dateTimePicker1.Value.Date;
            DateTime sistaAnmälningsdatum = this.dateTimePicker2.Value.Date;
            string in_i_tavling = "insert into tavling (namn,  datum, sistaanmalan) values ('" + Tävlingsnamn_textBox.Text + "', '" + tävlingsdatum.ToString() + "', '" + sistaAnmälningsdatum.ToString() + "'); SELECT CURRVAL(pg_get_serial_sequence('tavling','tavlingid'))";
            NpgsqlCommand command_tavling = new NpgsqlCommand(in_i_tavling, Huvudfönster.conn);
            NpgsqlDataReader id_tavling = command_tavling.ExecuteReader();
            id_tavling.Read();
            int tavlingid = Convert.ToInt32(id_tavling["currval"]);
            id_tavling.Close();


            // Lägger in information om tävlingsklass A i databasen, tabell klass. 
            string in_i_klass_a = "insert into klass (klassnamn, franvarde, tillvarde, tavlingid) values ('A', " + AFrån_textBox.Text + ", " + ATill_textBox.Text + ", " + tavlingid.ToString() + ")";
            NpgsqlCommand command_klass_a = new NpgsqlCommand(in_i_klass_a, Huvudfönster.conn);
            command_klass_a.ExecuteNonQuery();

            // Lägger in information om tävlingsklass B i databasen, tabell klass. 
            string in_i_klass_b = "insert into klass (klassnamn, franvarde, tillvarde, tavlingid) values ('B', " + BFrån_textBox.Text + ", " + BTill_textBox.Text + ", " + tavlingid.ToString() + ")";
            NpgsqlCommand command_klass_b = new NpgsqlCommand(in_i_klass_b, Huvudfönster.conn);
            command_klass_b.ExecuteNonQuery();

            // Lägger in information om tävlingsklass C i databasen, tabell klass. 
            string in_i_klass_c = "insert into klass (klassnamn, franvarde, tillvarde, tavlingid) values ('C', " + CFrån_textBox.Text + ", " + CTill_textBox.Text + ", " + tavlingid.ToString() + ")";
            NpgsqlCommand command_klass_c = new NpgsqlCommand(in_i_klass_c, Huvudfönster.conn);
            command_klass_c.ExecuteNonQuery();

            MessageBox.Show("Ny tävling är tillagd!");
            this.Close();
        } 
    }
}
