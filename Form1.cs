using StokTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketStokTakipApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokDB;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCloseTree.Visible= false;

            StyleDataGrid();
            LoadProducts();
            LoadCategories();

        }

        private void LoadCategories()
        {
            tvList.Nodes.Clear();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT ccode, cname FROM tblCategory", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TreeNode node = new TreeNode(reader["cname"].ToString());
                    node.Tag = reader["ccode"]; // ileride lazım olacak
                    tvList.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kategori Hatası");
            }
            finally
            {
                conn.Close();
            }
        }





        private void LoadSubCategories(TreeNode parentNode, DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row["ctype"].ToString().Trim().ToLower() == "alt" &&
                    row["comment"].ToString() == parentNode.Tag.ToString())
                {
                    TreeNode sub = new TreeNode(row["cname"].ToString());
                    sub.Tag = row["ccode"];
                    parentNode.Nodes.Add(sub);
                }
            }
        }


        private void tvList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tblProduct WHERE tblCategory=@ccode", conn);
            cmd.Parameters.AddWithValue("@ccode", e.Node.Tag);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }




        private void LoadProducts()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblProduct", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA");
            }
            finally
            {
                conn.Close();
            }
        }

        private void StyleDataGrid()
        {

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 230);


            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 235, 243);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;


            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.Height = 40;


            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 45;


            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;


            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void tvList_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
                return;

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM tblProduct WHERE CategoryCode = @ccode", conn);

                cmd.Parameters.AddWithValue("@ccode", e.Node.Tag);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filtreleme Hatası");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCategoryListe_Click(object sender, EventArgs e)
        {
            tvList.Visible = true;
            btnCloseTree.Visible = true;
        }
        private void btnCloseTree_Click(object sender, EventArgs e)
        {
            tvList.Visible= false;
            btnCloseTree.Visible= false;
        }

       
    }
}
