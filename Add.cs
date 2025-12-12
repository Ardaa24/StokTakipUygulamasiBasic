using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokDB;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            getInfo();
            Random rdm = new Random();
            string set = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string code = "";
            for (int i = 0; i < 8; i++)
            {
                code += set[rdm.Next(set.Length)];
            }
            txtCode.Text = code;
            txtCode.Enabled = false;

            Random rdm2 = new Random();
            string set2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string code2 = "";
            for (int i = 0; i < 4; i++)
            {
                code2 += set2[rdm2.Next(set2.Length)];
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tblProduct (pcode,pname,categorycode,bname,number,bprice,sprice) " +
                "VALUES (@pcode,@pname,@categorycode,@bname,@number,@bprice,@sprice)", conn);

            cmd.Parameters.AddWithValue("@pcode", txtCode.Text);
            cmd.Parameters.AddWithValue("@pname", txtName.Text);
            cmd.Parameters.AddWithValue("@categorycode", cbCategory.SelectedIndex.ToString());
            cmd.Parameters.AddWithValue("@bname", txtBrand.Text);
            cmd.Parameters.AddWithValue("@number", txtPiece.Text);
            cmd.Parameters.AddWithValue("@bprice", txtBuy.Text);
            cmd.Parameters.AddWithValue("@sprice", txtSale.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            popupForm p = new popupForm();
            p.lblMessage.Text = "Ürün başarıyla eklendi.";
            p.lblMessage.Left = (p.Width - p.lblMessage.Width) / 2;
            p.ShowDialog();

        }

       

        void getInfo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblCategory", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbCategory.Items.Add(reader["cname"].ToString().Trim());
            }
            reader.Close();
            conn.Close();
        }
    }
    }

