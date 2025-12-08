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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Düğüm0");
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnCatalogAdd = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnListAdd = new System.Windows.Forms.Button();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tvList = new System.Windows.Forms.TreeView();
            this.btnCloseTree = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbarcod = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSrc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCost = new System.Windows.Forms.Panel();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnDoc);
            this.panel1.Controls.Add(this.btnCatalogAdd);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnListAdd);
            this.panel1.Controls.Add(this.btnGroupAdd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDoc.FlatAppearance.BorderSize = 0;
            this.btnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoc.Location = new System.Drawing.Point(1134, 6);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(215, 34);
            this.btnDoc.TabIndex = 6;
            this.btnDoc.Text = "Dökümanlar";
            this.btnDoc.UseVisualStyleBackColor = false;
            // 
            // btnCatalogAdd
            // 
            this.btnCatalogAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCatalogAdd.FlatAppearance.BorderSize = 0;
            this.btnCatalogAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatalogAdd.Location = new System.Drawing.Point(433, 6);
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
            this.btnPlus.Location = new System.Drawing.Point(901, 6);
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
            this.btnListAdd.Location = new System.Drawing.Point(665, 6);
            this.btnListAdd.Name = "btnListAdd";
            this.btnListAdd.Size = new System.Drawing.Size(215, 34);
            this.btnListAdd.TabIndex = 0;
            this.btnListAdd.Text = "Ürün Ekle";
            this.btnListAdd.UseVisualStyleBackColor = false;
            this.btnListAdd.Click += new System.EventHandler(this.btnListAdd_Click);
            // 
            // btnGroupAdd
            // 
            this.btnGroupAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.btnGroupAdd.FlatAppearance.BorderSize = 0;
            this.btnGroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGroupAdd.Location = new System.Drawing.Point(202, 5);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(215, 34);
            this.btnGroupAdd.TabIndex = 1;
            this.btnGroupAdd.Text = "Kategori Listesi";
            this.btnGroupAdd.UseVisualStyleBackColor = false;
            this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
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
            // tvList
            // 
            this.tvList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvList.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvList.ForeColor = System.Drawing.SystemColors.Menu;
            this.tvList.LineColor = System.Drawing.Color.White;
            this.tvList.Location = new System.Drawing.Point(0, 45);
            this.tvList.Name = "tvList";
            treeNode1.Name = "Düğüm0";
            treeNode1.Text = "Düğüm0";
            this.tvList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvList.Size = new System.Drawing.Size(201, 679);
            this.tvList.TabIndex = 1;
            this.tvList.Visible = false;
            // 
            // btnCloseTree
            // 
            this.btnCloseTree.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCloseTree.FlatAppearance.BorderSize = 0;
            this.btnCloseTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTree.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloseTree.ForeColor = System.Drawing.Color.White;
            this.btnCloseTree.Location = new System.Drawing.Point(0, 686);
            this.btnCloseTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseTree.Name = "btnCloseTree";
            this.btnCloseTree.Size = new System.Drawing.Size(201, 37);
            this.btnCloseTree.TabIndex = 4;
            this.btnCloseTree.Text = "Kapat";
            this.btnCloseTree.UseVisualStyleBackColor = false;
            this.btnCloseTree.Visible = false;
            this.btnCloseTree.Click += new System.EventHandler(this.btnCloseTree_Click_1);
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.txtbarcod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbarcod);
            this.groupBox1.Controls.Add(this.btnSrc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(231, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 394);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ara";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StokTakip.Properties.Resources.sale;
            this.pictureBox1.Location = new System.Drawing.Point(231, 565);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 724);
            this.Controls.Add(this.pnlCost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCloseTree);
            this.Controls.Add(this.tvList);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCost.ResumeLayout(false);
            this.pnlCost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListAdd;
        private System.Windows.Forms.Button btnGroupAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TreeView tvList;
        private System.Windows.Forms.Button btnCloseTree;
        private System.Windows.Forms.Button btnCatalogAdd;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbarcod;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlCost;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCart;
    }
}

