using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakip
{
    public partial class CatalogAdd : Form
    {
        public CatalogAdd()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokDB;Integrated Security=True");


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

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tblCategory (ccode,cname,ctype,comment) VALUES (@ccode,@cname,@ctype,@comment)", conn);
            cmd.Parameters.AddWithValue("@ccode", txtCatalogCode.Text);
            cmd.Parameters.AddWithValue("@cname", txtName.Text);
            cmd.Parameters.AddWithValue("@ctype", txtType.Text);
            cmd.Parameters.AddWithValue("@comment", rtbComment.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
