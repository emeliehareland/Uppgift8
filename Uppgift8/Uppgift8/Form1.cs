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
    public partial class Huvudfönster : Form
    {
        //Skapar en Npgsqlkoppling, conn.
        public static NpgsqlConnection conn;

        public Huvudfönster()
        {
            InitializeComponent();
            //Ansluter till ovan.
            Connect();
        }

        //Lägger in information om databasen som programmet kommer att använda. Öppnar kopplingen till databasen.
        private static void Connect()
        {
            conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Uppgift8;User Id=postgres;Password=password;SSL=true");
            conn.Open();
        }

        //När användaren klickar på "Anmäl deltagare" i menyn öppnas formet AmnälDeltagare.
        private void anmälDeltagareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnmälDeltagare AnmälDeltagare = new AnmälDeltagare();
            AnmälDeltagare.ShowDialog();
        }

        //När användaren klickar på "Registrera resultat" i menyn öppnas formet RegistreraResultat.
        private void registreraResultatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistreraResultat RegistreraResultat = new RegistreraResultat();
            RegistreraResultat.ShowDialog();
        }

        //När användaren klickar på "Lägg till ny spelare" i menyn öppnas formet LäggTillNySpelare.
        private void läggTillNySpelareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LäggTillNySpelare LäggTillNySpelare = new LäggTillNySpelare();
            LäggTillNySpelare.ShowDialog();
        }

        //När användaren klickar på "Lägg till ny spelare" i menyn öppnas formet LäggTillNySpelare.
        private void medlemsregisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medlemsregister Medlemsregister = new Medlemsregister();
            Medlemsregister.ShowDialog();
        }

        //När användaren klickar på "Lägg till ny tävling" i menyn öppnas formet LäggTillNyTävling.
        private void läggTillNyTävlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LäggTillNyTävling LäggTillNyTävling = new LäggTillNyTävling();
            LäggTillNyTävling.ShowDialog();
        }

        //När användaren klickar på "Resultatlistor" i menyn öppnas formet Resultatlistor.
        private void tävlingsregisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resultatlistor Resultatlistor = new Resultatlistor();
            Resultatlistor.ShowDialog();
        }
    }
}
