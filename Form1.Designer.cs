namespace MarketStokTakipApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCategoryListe = new System.Windows.Forms.Button();
            this.btnCatalogAdd = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnListAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbarcod = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSrc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlCost = new System.Windows.Forms.Panel();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tvList = new System.Windows.Forms.TreeView();
            this.btnCloseTree = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.PictureBox();
            this.btnSale = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSale)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnCategoryListe);
            this.panel1.Controls.Add(this.btnCatalogAdd);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnListAdd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnCategoryListe
            // 
            this.btnCategoryListe.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCategoryListe.FlatAppearance.BorderSize = 0;
            this.btnCategoryListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryListe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategoryListe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoryListe.Location = new System.Drawing.Point(367, 4);
            this.btnCategoryListe.Name = "btnCategoryListe";
            this.btnCategoryListe.Size = new System.Drawing.Size(215, 34);
            this.btnCategoryListe.TabIndex = 7;
            this.btnCategoryListe.Text = "Kategori Listesi";
            this.btnCategoryListe.UseVisualStyleBackColor = false;
            this.btnCategoryListe.Click += new System.EventHandler(this.btnCategoryListe_Click);
            // 
            // btnCatalogAdd
            // 
            this.btnCatalogAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCatalogAdd.FlatAppearance.BorderSize = 0;
            this.btnCatalogAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatalogAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCatalogAdd.Location = new System.Drawing.Point(603, 5);
            this.btnCatalogAdd.Name = "btnCatalogAdd";
            this.btnCatalogAdd.Size = new System.Drawing.Size(215, 34);
            this.btnCatalogAdd.TabIndex = 5;
            this.btnCatalogAdd.Text = "Kategori Ekle";
            this.btnCatalogAdd.UseVisualStyleBackColor = false;
            this.btnCatalogAdd.Click += new System.EventHandler(this.btnCatalogAdd_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlus.Location = new System.Drawing.Point(1071, 5);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(215, 34);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "Stok Görüntüle";
            this.btnPlus.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 45);
            this.panel3.TabIndex = 2;
            // 
            // btnListAdd
            // 
            this.btnListAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.btnListAdd.FlatAppearance.BorderSize = 0;
            this.btnListAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListAdd.Location = new System.Drawing.Point(835, 5);
            this.btnListAdd.Name = "btnListAdd";
            this.btnListAdd.Size = new System.Drawing.Size(215, 34);
            this.btnListAdd.TabIndex = 0;
            this.btnListAdd.Text = "Ürün Ekle";
            this.btnListAdd.UseVisualStyleBackColor = false;
            this.btnListAdd.Click += new System.EventHandler(this.btnListAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1395, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(590, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 512);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Barkod Numarası İle Ara";
            // 
            // txtbarcod
            // 
            this.txtbarcod.Location = new System.Drawing.Point(43, 90);
            this.txtbarcod.Name = "txtbarcod";
            this.txtbarcod.Size = new System.Drawing.Size(227, 34);
            this.txtbarcod.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(43, 197);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 34);
            this.txtName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "İsimİle Ara";
            // 
            // btnSrc
            // 
            this.btnSrc.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSrc.FlatAppearance.BorderSize = 0;
            this.btnSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSrc.Location = new System.Drawing.Point(43, 270);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(227, 34);
            this.btnSrc.TabIndex = 10;
            this.btnSrc.Text = "Listele";
            this.btnSrc.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbarcod);
            this.groupBox1.Controls.Add(this.btnSrc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(255, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 407);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ara";
            // 
            // pnlCost
            // 
            this.pnlCost.Controls.Add(this.lbCart);
            this.pnlCost.Controls.Add(this.lblTotal);
            this.pnlCost.Controls.Add(this.label3);
            this.pnlCost.Location = new System.Drawing.Point(1115, 87);
            this.pnlCost.Name = "pnlCost";
            this.pnlCost.Size = new System.Drawing.Size(322, 625);
            this.pnlCost.TabIndex = 13;
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 28;
            this.lbCart.Location = new System.Drawing.Point(14, 17);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(295, 564);
            this.lbCart.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(177, 583);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 28);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 583);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toplam Fiyat:";
            // 
            // tvList
            // 
            this.tvList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvList.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvList.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tvList.LineColor = System.Drawing.Color.White;
            this.tvList.Location = new System.Drawing.Point(0, 45);
            this.tvList.Name = "tvList";
            this.tvList.Size = new System.Drawing.Size(237, 679);
            this.tvList.TabIndex = 14;
            this.tvList.Visible = false;
            this.tvList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvList_AfterSelect_1);
            // 
            // btnCloseTree
            // 
            this.btnCloseTree.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCloseTree.FlatAppearance.BorderSize = 0;
            this.btnCloseTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseTree.Location = new System.Drawing.Point(0, 667);
            this.btnCloseTree.Name = "btnCloseTree";
            this.btnCloseTree.Size = new System.Drawing.Size(237, 34);
            this.btnCloseTree.TabIndex = 15;
            this.btnCloseTree.Text = "Kapat";
            this.btnCloseTree.UseVisualStyleBackColor = false;
            this.btnCloseTree.Click += new System.EventHandler(this.btnCloseTree_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPrint.Image = global::StokTakip.Properties.Resources._2832794;
            this.btnPrint.Location = new System.Drawing.Point(493, 565);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 83);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrint.TabIndex = 17;
            this.btnPrint.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRestart.Image = global::StokTakip.Properties.Resources.restart_icon_9;
            this.btnRestart.Location = new System.Drawing.Point(376, 565);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(82, 83);
            this.btnRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestart.TabIndex = 16;
            this.btnRestart.TabStop = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSale
            // 
            this.btnSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSale.Image = global::StokTakip.Properties.Resources.sale;
            this.btnSale.Location = new System.Drawing.Point(255, 565);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(89, 83);
            this.btnSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSale.TabIndex = 12;
            this.btnSale.TabStop = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 724);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnCloseTree);
            this.Controls.Add(this.tvList);
            this.Controls.Add(this.pnlCost);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlCost.ResumeLayout(false);
            this.pnlCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnCatalogAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbarcod;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btnSale;
        private System.Windows.Forms.Panel pnlCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.Button btnCloseTree;
        private System.Windows.Forms.Button btnCategoryListe;
        internal System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox btnRestart;
        private System.Windows.Forms.PictureBox btnPrint;
        internal System.Windows.Forms.TreeView tvList;
    }
}

