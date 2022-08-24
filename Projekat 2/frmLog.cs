using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_2
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void Prodaja(object sender, EventArgs e)
        {
            frmProdaja pr = new frmProdaja();
            this.Hide();
            pr.ShowDialog();
            this.Close();
        }

        private void Administracija(object sender, EventArgs e)
        {
            frmAdministracija am = new frmAdministracija();
            this.Hide();
            am.ShowDialog();
            this.Close();
        }
    }
}