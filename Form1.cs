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
            btnCloseTree.Visible = false;

            StyleDataGrid();
            LoadProducts();
            LoadCategories();
            lblTotal.Text = "0.00 ₺";
            total = 0;

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
            tvList.Visible = false;
            btnCloseTree.Visible = false;
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
            if (cart.Count == 0)
            {
                MessageBox.Show("Sepet boş!");
                return;
            }

            try
            {
                conn.Open();

                SqlCommand cmdSale = new SqlCommand(
                    "INSERT INTO tblSale (SaleDate, TotalAmount) OUTPUT INSERTED.SaleID VALUES (@d,@t)", conn);

                cmdSale.Parameters.AddWithValue("@d", DateTime.Now);
                cmdSale.Parameters.AddWithValue("@t", total);

                int saleId = (int)cmdSale.ExecuteScalar();

                foreach (var item in cart)
                {
                    SqlCommand cmdDetail = new SqlCommand(
                        "INSERT INTO tblSaleDetail (SaleID, ProductCode, ProductName, Quantity, UnitPrice) " +
                        "VALUES (@sid,@code,@name,@qty,@price)", conn);

                    cmdDetail.Parameters.AddWithValue("@sid", saleId);
                    cmdDetail.Parameters.AddWithValue("@code", item.ProductCode);
                    cmdDetail.Parameters.AddWithValue("@name", item.ProductName);
                    cmdDetail.Parameters.AddWithValue("@qty", item.Quantity);
                    cmdDetail.Parameters.AddWithValue("@price", item.Price);

                    cmdDetail.ExecuteNonQuery();
                }

                UpdateStock();

                MessageBox.Show("Satış başarıyla tamamlandı ✅");

                cart.Clear();
                lbCart.Items.Clear();
                total = 0;
                lblTotal.Text = "0.00 ₺";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
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

            foreach (var item in cart)
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tblProduct SET number = number - @qty WHERE pcode = @pcode",
                    conn);

                cmd.Parameters.AddWithValue("@qty", item.Quantity);
                cmd.Parameters.AddWithValue("@pcode", item.ProductCode);

                cmd.ExecuteNonQuery();
            }

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CreateLastSalePdf();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            frmStock stock = new frmStock();
            stock.ShowDialog();
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
            try
            {
                int saleId = 0;
                DateTime saleDate = DateTime.Now;
                decimal saleTotal = 0m;

                using (var c = new System.Data.SqlClient.SqlConnection(conn.ConnectionString))
                {
                    c.Open();
                    using (var cmd = new System.Data.SqlClient.SqlCommand(
                        "SELECT TOP 1 SaleID, SaleDate, TotalAmount FROM tblSale ORDER BY SaleID DESC", c))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                saleId = Convert.ToInt32(dr["SaleID"]);
                                saleDate = Convert.ToDateTime(dr["SaleDate"]);
                                saleTotal = Convert.ToDecimal(dr["TotalAmount"]);
                            }
                        }
                    }
                }

                if (saleId == 0)
                {
                    MessageBox.Show("Yazdırılacak satış bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string filePath = System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    $"Fatura_{saleId}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

                using (var fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    var document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 36f, 36f, 36f, 36f);
                    var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, fs);
                    document.Open();

                    var titleFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 14);
                    var headerFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 10);
                    var normalFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 9);

                    var headerTable = new iTextSharp.text.pdf.PdfPTable(2) { WidthPercentage = 100f };
                    headerTable.SetWidths(new float[] { 65f, 35f });

                    var leftCell = new iTextSharp.text.pdf.PdfPCell();
                    leftCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    leftCell.AddElement(new iTextSharp.text.Paragraph("ANAVATAN BILGISAYAR A.S.", headerFont));
                    leftCell.AddElement(new iTextSharp.text.Paragraph("Merkez: Mersin. ...", normalFont));
                    leftCell.AddElement(new iTextSharp.text.Paragraph("Vergi No: 6320036072", normalFont));
                    headerTable.AddCell(leftCell);

                    var rightCell = new iTextSharp.text.pdf.PdfPCell();
                    rightCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    rightCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    rightCell.AddElement(new iTextSharp.text.Paragraph("e-ARSIV FATURA", headerFont));
                    rightCell.AddElement(new iTextSharp.text.Paragraph($"Fatura No: {saleId}", normalFont));
                    rightCell.AddElement(new iTextSharp.text.Paragraph($"Tarih: {saleDate:dd.MM.yyyy HH:mm}", normalFont));
                    headerTable.AddCell(rightCell);

                    document.Add(headerTable);
                    document.Add(new iTextSharp.text.Paragraph("\n"));

                    var infoTable = new iTextSharp.text.pdf.PdfPTable(2) { WidthPercentage = 100f };
                    infoTable.SetWidths(new float[] { 55f, 45f });
                    var buyer = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Alici:\nAd Soyad\nAdres\nTelefon", normalFont))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER
                    };
                    infoTable.AddCell(buyer);

                    var invoiceInfo = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(
                        $"Irsaliye / Bilgi:\nFatura No: {saleId}\nTarih: {saleDate:dd.MM.yyyy}\nSaat: {saleDate:HH:mm}", normalFont))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT
                    };
                    infoTable.AddCell(invoiceInfo);

                    document.Add(infoTable);
                    document.Add(new iTextSharp.text.Paragraph("\n"));

                    var productTable = new iTextSharp.text.pdf.PdfPTable(5) { WidthPercentage = 100f };
                    productTable.SetWidths(new float[] { 12f, 46f, 10f, 16f, 16f });

                    void AddHeader(string txt)
                    {
                        var cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(txt, headerFont))
                        {
                            BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY,
                            HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER,
                            Padding = 4
                        };
                        productTable.AddCell(cell);
                    }

                    AddHeader("Mal No");
                    AddHeader("Açıklama");
                    AddHeader("Miktar");
                    AddHeader("Birim Fiyat");
                    AddHeader("Tutar");

                    using (var c = new SqlConnection(conn.ConnectionString))
                    {
                        c.Open();

                        using (var cmd = new SqlCommand(
                            "SELECT ProductCode, ProductName, Quantity, UnitPrice " +
                            "FROM tblSaleDetail WHERE SaleID = @SaleID", c))
                        {
                            cmd.Parameters.AddWithValue("@SaleID", saleId);

                            using (var dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    string code = dr["ProductCode"].ToString();
                                    string name = dr["ProductName"].ToString();
                                    int qty = Convert.ToInt32(dr["Quantity"]);
                                    decimal price = Convert.ToDecimal(dr["UnitPrice"]);
                                    decimal lineTotal = qty * price;

                                    productTable.AddCell(new Phrase(code, normalFont));
                                    productTable.AddCell(new Phrase(name, normalFont));
                                    productTable.AddCell(new Phrase(qty.ToString(), normalFont));
                                    productTable.AddCell(new Phrase(price.ToString("0.00"), normalFont));
                                    productTable.AddCell(new Phrase(lineTotal.ToString("0.00"), normalFont));
                                }
                            }
                        }
                    }


                    document.Add(productTable);
                    document.Add(new iTextSharp.text.Paragraph("\n"));

                    var totalsTable = new iTextSharp.text.pdf.PdfPTable(2)
                    {
                        HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT,
                        WidthPercentage = 40f
                    };

                    iTextSharp.text.pdf.PdfPCell MakeTotalCell(string txt, iTextSharp.text.Font f, bool borderless = true, int align = iTextSharp.text.Element.ALIGN_RIGHT)
                    {
                        return new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(txt, f))
                        {
                            Border = borderless ? iTextSharp.text.Rectangle.NO_BORDER : iTextSharp.text.Rectangle.BOX,
                            HorizontalAlignment = align,
                            Padding = 2
                        };
                    }

                    totalsTable.AddCell(MakeTotalCell("Ara Toplam", normalFont));
                    totalsTable.AddCell(MakeTotalCell(saleTotal.ToString("0.00") + " ₺", normalFont));

                    decimal kdv = Math.Round(saleTotal * 0.20m, 2);
                    totalsTable.AddCell(MakeTotalCell("KDV (%20)", normalFont));
                    totalsTable.AddCell(MakeTotalCell(kdv.ToString("0.00") + " ₺", normalFont));

                    totalsTable.AddCell(MakeTotalCell("Ödenecek Toplam", headerFont));
                    totalsTable.AddCell(MakeTotalCell((saleTotal + kdv).ToString("0.00") + " ₺", headerFont));

                    document.Add(totalsTable);
                    document.Add(new iTextSharp.text.Paragraph("\n"));

                    var note = new iTextSharp.text.Paragraph("Bu belge elektronik ortamda üretilmistir. Irsaliye yerine geçer. Anavatan Group A.S", normalFont);
                    document.Add(note);

                    document.Close();
                    writer.Close();
                    fs.Close();
                }

                try
                {
                    var psi = new ProcessStartInfo(filePath)
                    {
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
                catch
                {
                }

                MessageBox.Show("PDF fatura olusturuldu:\n" + filePath, "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF olusturulurken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tblProduct WHERE pcode LIKE @pcode", conn);
            cmd.Parameters.AddWithValue("@pcode", "%" + txtbarcod.Text + "%");
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }

}
