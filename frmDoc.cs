using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class frmDoc : Form
    {
        public frmDoc()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      

        private void frmDoc_Load(object sender, EventArgs e)
        {
            pbDe.Enabled = false;
            pbSafe.Enabled = false;
            lblDe.Enabled = false;
            lblSafe.Enabled = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
