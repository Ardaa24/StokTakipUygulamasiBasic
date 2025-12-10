using StokTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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

        public void LoadCategories()
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
                    node.Tag = reader["ccode"]; 
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

            dataGridView1.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 11);

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.Height = 40;

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(242, 242, 242);

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(50, 50, 50);

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold);

            dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dataGridView1.ColumnHeadersHeight = 45;
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
            LoadCategories();
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
                ProductName = pname,
                Price = price,
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
            if (lbCart.Items.Count == 0)
            {
                MessageBox.Show("Lütfen önce ürün ekleyin.");
            }
            else {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tblSale (SaleDate, TotalAmount) VALUES (@SaleDate, @TotalAmount)",
                    conn);
                cmd.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@TotalAmount", total);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Satış tamamlandı!", "Bilgi");
                cartLines.Clear();
                lbCart.Items.Clear();
                total = 0;
                lblTotal.Text = "0 ₺";
                LoadProducts();
            }
        }

        class CartItem
        {
            public string ProductCode;
            public string ProductName;
            public decimal Price;
            public int Quantity;
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

        private void btnRestart_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CreateLastSalePdf();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbCart.Items.Clear();
            lblTotal.Text = "0.00 ₺";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbCart.SelectedIndex == -1)
            {
                MessageBox.Show("Silinecek ürünü seçin!");
                return;
            }

            int index = lbCart.SelectedIndex;

            CartItem item = cart[index];

            total -= item.Price * item.Quantity;
            lblTotal.Text = total.ToString("0.00 ₺");

            cart.RemoveAt(index);
            lbCart.Items.RemoveAt(index);
        }

        private void CreateLastSalePdf()
        {
            int saleId = 0;
            DateTime saleDate = DateTime.Now;
            decimal saleTotal = 0;

            // Son satışı al
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT TOP 1 SaleID, SaleDate, TotalAmount FROM tblSale ORDER BY SaleID DESC",
                conn);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                saleId = Convert.ToInt32(dr["SaleID"]);
                saleDate = Convert.ToDateTime(dr["SaleDate"]);
                saleTotal = Convert.ToDecimal(dr["TotalAmount"]);
            }
            dr.Close();
            conn.Close();

            if (saleId == 0)
            {
                MessageBox.Show("Yazdırılacak satış bulunamadı.");
                return;
            }

            string filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                $"Fis_{saleId}.pdf");

            // PDF oluştur
            iTextSharp.text.Document document =
                new iTextSharp.text.Document(iTextSharp.text.PageSize.A6);

            iTextSharp.text.pdf.PdfWriter.GetInstance(
                document, new FileStream(filePath, FileMode.Create));

            document.Open();

            // ✅ ÇAKIŞMASIZ FONT TANIMLARI
            iTextSharp.text.Font titleFont =
                iTextSharp.text.FontFactory.GetFont(
                    iTextSharp.text.FontFactory.HELVETICA_BOLD, 14);

            iTextSharp.text.Font normalFont =
                iTextSharp.text.FontFactory.GetFont(
                    iTextSharp.text.FontFactory.HELVETICA, 10);

            document.Add(new iTextSharp.text.Paragraph("MARKET FİŞİ\n", titleFont));
            document.Add(new iTextSharp.text.Paragraph($"Fiş No : {saleId}", normalFont));
            document.Add(new iTextSharp.text.Paragraph($"Tarih  : {saleDate}", normalFont));
            document.Add(new iTextSharp.text.Paragraph("----------------------------", normalFont));

            foreach (var item in cart)
            {
                document.Add(new iTextSharp.text.Paragraph(
                    $"{item.ProductName} x{item.Quantity}  {item.Price * item.Quantity:0.00} ₺",
                    normalFont));
            }

            document.Add(new iTextSharp.text.Paragraph("----------------------------", normalFont));
            document.Add(new iTextSharp.text.Paragraph(
                $"TOPLAM : {saleTotal:0.00} ₺", titleFont));

            document.Close();

            MessageBox.Show("PDF fiş oluşturuldu.\n\n" + filePath, "Bilgi");
            Process.Start(filePath);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            frmStock stock = new frmStock();
            stock.ShowDialog();
        }
    }


}
