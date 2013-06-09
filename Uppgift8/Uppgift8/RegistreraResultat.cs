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
    }
}
