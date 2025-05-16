using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek86.forms
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnGestionAbsence_Click(object sender, EventArgs e)
        {
            gestion_absence gbsform = new gestion_absence(); // Open in general mode
            gbsform.Show();
        }

        private void btnGestionPersonnel_Click(object sender, EventArgs e)
        {
            gestion_personnel gpsform = new gestion_personnel();
            gpsform.Show();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
