using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift8
{
    public partial class Huvudfönster : Form
    {
        public Huvudfönster()
        {
            InitializeComponent();
        }

        private void medlemshanteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void registeraTävlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistreraTävling RegistreraTävling = new RegistreraTävling();
            RegistreraTävling.ShowDialog();
        }

        private void anmälDeltagareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnmälDeltagare AnmälDeltagare = new AnmälDeltagare();
            AnmälDeltagare.ShowDialog();
        }

        private void registreraResultatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistreraResultat RegistreraResultat = new RegistreraResultat();
            RegistreraResultat.ShowDialog();
        }

        private void läggTillNySpelareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LäggTillNySpelare LäggTillNySpelare = new LäggTillNySpelare();
            LäggTillNySpelare.ShowDialog();
        }

        private void medlemsregisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medlemsregister Medlemsregister = new Medlemsregister();
            Medlemsregister.ShowDialog();
        }

        private void Huvudfönster_Load(object sender, EventArgs e)
        {

        }
    }
}
