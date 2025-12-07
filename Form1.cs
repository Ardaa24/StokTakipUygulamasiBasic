using StokTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStokTakipApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            btnCloseTree.Visible = true;
            tvList.Visible = true;
        }

        private void btnCloseTree_Click_1(object sender, EventArgs e)
        {
            tvList.Visible = false;
            btnCloseTree.Visible = false;
        }
        private void btnListAdd_Click(object sender, EventArgs e)
        {
         Add add = new Add();
            add.ShowDialog();
        }

        private void btnCatalogAdd_Click(object sender, EventArgs e)
        {
            CatalogAdd catalogAdd = new CatalogAdd();
            catalogAdd.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSrc_Click(object sender, EventArgs e)
        {

        }

        
    }
}
