using StokTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MarketStokTakipApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokDB;Integrated Security=True");

        //Global Referances
        List<string> cartLines = new List<string>();
        decimal total = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCloseTree.Visible= false;

            StyleDataGrid();
            LoadProducts();
            LoadCategories();
            lblTotal.Text = "0.00 ₺";
            total= 0; 

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            string pcode = row.Cells["pcode"].Value.ToString();
            string pname = row.Cells["pname"].Value.ToString();
            decimal price = Convert.ToDecimal(row.Cells["sprice"].Value);
            int stock = Convert.ToInt32(row.Cells["number"].Value);

            if (stock <= 0)
            {
                MessageBox.Show("Stok yok!");
                return;
            }

            cart.Add(new CartItem
            {
                ProductCode = pcode,
                Quantity = 1
            });

            lbCart.Items.Add($"{pname} - {price} ₺");

            total += price;
            lblTotal.Text = total.ToString("0.00 ₺");
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            UpdateStock();
            cart.Clear();    
            //PrintDocument pd = new PrintDocument();

            //pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            //pd.PrintPage += Pd_PrintPage;

            //PrintDialog dlg = new PrintDialog();
            //dlg.Document = pd;

            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    pd.Print();
            //}
            MessageBox.Show("Satış tamamlandı!", "Bilgi");
            cartLines.Clear();
            lbCart.Items.Clear();
            total = 0;
            lblTotal.Text = "0 ₺";
            LoadProducts();
        }

        class CartItem
        {
            public string ProductCode;   // pcode
            public int Quantity;         // satılan adet
        }
        List<CartItem> cart = new List<CartItem>();
        private void UpdateStock()
        {
            conn.Open();

            foreach (var item in cart)
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tblProduct SET number = number - @qty WHERE pcode = @pcode",
                    conn);

                cmd.Parameters.AddWithValue("@qty", item.Quantity);
                cmd.Parameters.AddWithValue("@pcode", item.ProductCode);

                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        //private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    float y = 20;
        //    Font title = new Font("Arial", 14, FontStyle.Bold);
        //    Font normal = new Font("Arial", 10);

        //    e.Graphics.DrawString("MARKET FİŞİ", title, Brushes.Black, 80, y);
        //    y += 30;

        //    e.Graphics.DrawString(DateTime.Now.ToString(), normal, Brushes.Black, 10, y);
        //    y += 30;

        //    foreach (string line in cartLines)
        //    {
        //        e.Graphics.DrawString(line, normal, Brushes.Black, 10, y);
        //        y += 20;
        //    }

        //    y += 10;
        //    e.Graphics.DrawLine(Pens.Black, 10, y, 200, y);
        //    y += 10;

        //    e.Graphics.DrawString("TOPLAM: " + total.ToString("0.00 ₺"), title, Brushes.Black, 10, y);
        //}
    }


}
