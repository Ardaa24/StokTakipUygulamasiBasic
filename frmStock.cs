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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokDB;Integrated Security=True");


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            LoadProducts();
            if (!dataGridView1.Columns.Contains("originalPrice"))
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = "originalPrice";
                col.Visible = false;
                dataGridView1.Columns.Add(col);
            }
        }

        private void LoadProducts()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM tblProduct", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Optional: conn close ve dispose işlemleri burada yapılabilir
            }
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tblProduct  WHERE(@pname = '' OR pname LIKE @pname)AND(@pcode = '' OR pcode LIKE @pcode)", conn);

            cmd.Parameters.AddWithValue("@pname", "%" + txtName.Text + "%");
            cmd.Parameters.AddWithValue("@pcode", "%" + txtbarcod.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
            txtbarcod.Clear();
            txtName.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtCode1.Text = row.Cells["pcode"].Value.ToString();
                txtCode2.Text = row.Cells["pcode"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode1.Text))
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin!");
                return;
            }

            DialogResult result = MessageBox.Show("Bu ürünü silmek istediğinizden emin misiniz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM tblProduct WHERE pcode = @pcode", conn);

                    cmd.Parameters.AddWithValue("@pcode", txtCode1.Text);

                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                    {
                        popupForm p = new popupForm();
                        p.lblMessage.Text = "Ürün silindi.";
                        p.lblMessage.Left = (p.Width - p.lblMessage.Width) / 2;
                        p.ShowDialog();
                    }
                    else
                        {
                        popupForm p = new popupForm();
                        p.lblMessage.Text = "Sepetiniz boş. Lütfen önce ürün ekleyin.";
                        p.lblMessage.Left = (p.Width - p.lblMessage.Width) / 2;
                        p.ShowDialog();
                        
                    }

                    LoadProducts(); // tabloyu yenile
                    txtCode1.Clear();
                    txtCode2.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnAddCut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode1.Text))
            {
                popupForm pop = new popupForm();
                pop.lblMessage.Text = "Lütfen önce ürün seçin.";
                pop.lblMessage.Left = (pop.Width - pop.lblMessage.Width) / 2;
                pop.ShowDialog();
                return;
            }

            if (!decimal.TryParse(txtCut.Text, out decimal cutRate))
            {
                popupForm p2 = new popupForm();
                p2.lblMessage.Text = "Lütfen geçerli bir indirim yüzdesi girin.";
                p2.lblMessage.Left = (p2.Width - p2.lblMessage.Width) / 2;
                p2.ShowDialog();
                return;
            }

            cutRate /= 100;


            //Geçici kampanya kısmı. İleride veritbanına eklenebilir. Şimdilik sadece UI üzerinde gösteriliyor.
            // İndirim uygulanmış ürünler yeşil renkle gösteriliyor.
            // İndirim geri alındığında orijinal fiyat geri yükleniyor.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["pcode"].Value.ToString() == txtCode1.Text)
                {
                    bool isCampaign = row.DefaultCellStyle.BackColor == Color.LightGreen;

                    if (!isCampaign)
                    {
                        row.Cells["originalPrice"].Value = row.Cells["sprice"].Value;

                        decimal originalPrice = Convert.ToDecimal(row.Cells["sprice"].Value);
                        decimal discountedPrice = originalPrice - (originalPrice * cutRate);

                        row.Cells["sprice"].Value = discountedPrice;
                        row.DefaultCellStyle.BackColor = Color.LightGreen;

                        popupForm p3 = new popupForm();
                        p3.lblMessage.Text = "Kampanya uygulandı. Kampanya yüzdesi:" + cutRate;
                        p3.lblMessage.Left = (p3.Width - p3.lblMessage.Width) / 2;
                        p3.ShowDialog();
                    }
                    else
                    {
                        row.Cells["sprice"].Value = row.Cells["originalPrice"].Value;
                        row.DefaultCellStyle.BackColor = Color.White;

                        popupForm p4 = new popupForm();
                        p4.lblMessage.Text = "Kampanya geri alındı.";
                        p4.lblMessage.Left = (p4.Width - p4.lblMessage.Width) / 2;
                        p4.ShowDialog();
                    }
                    return;

                }
            }

            popupForm p = new popupForm();
            p.lblMessage.Text = "Ürün bulunamadı.";
            p.lblMessage.Left = (p.Width - p.lblMessage.Width) / 2;
            p.ShowDialog();
            return;
        }
    }
}
