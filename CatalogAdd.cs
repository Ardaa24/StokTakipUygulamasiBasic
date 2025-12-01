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
    public partial class CatalogAdd : Form
    {
        public CatalogAdd()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CatalogAdd_Load(object sender, EventArgs e)
        {
            Random rdm = new Random();
            string set = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string code = "";
            for (int i = 0; i < 6; i++)
            {
                code += set[rdm.Next(set.Length)];
            }
           txtCatalogCode.Text = code;
            txtCatalogCode.Enabled = false;
        }
    }
}
