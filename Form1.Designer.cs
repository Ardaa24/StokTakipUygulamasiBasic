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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Düğüm0");
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPriceDown = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnListAdd = new System.Windows.Forms.Button();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tvList = new System.Windows.Forms.TreeView();
            this.btnCloseTree = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnPriceDown);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnListAdd);
            this.panel1.Controls.Add(this.btnGroupAdd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnPriceDown
            // 
            this.btnPriceDown.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPriceDown.FlatAppearance.BorderSize = 0;
            this.btnPriceDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPriceDown.Location = new System.Drawing.Point(794, 3);
            this.btnPriceDown.Name = "btnPriceDown";
            this.btnPriceDown.Size = new System.Drawing.Size(215, 47);
            this.btnPriceDown.TabIndex = 4;
            this.btnPriceDown.Text = "Kampanya Ekle";
            this.btnPriceDown.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlus.Location = new System.Drawing.Point(561, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(215, 47);
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
            this.panel3.Size = new System.Drawing.Size(21, 53);
            this.panel3.TabIndex = 2;
            // 
            // btnListAdd
            // 
            this.btnListAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.btnListAdd.FlatAppearance.BorderSize = 0;
            this.btnListAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListAdd.Location = new System.Drawing.Point(325, 3);
            this.btnListAdd.Name = "btnListAdd";
            this.btnListAdd.Size = new System.Drawing.Size(215, 47);
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
            this.btnGroupAdd.Location = new System.Drawing.Point(86, 3);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(215, 47);
            this.btnGroupAdd.TabIndex = 1;
            this.btnGroupAdd.Text = "Kategoriler";
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
            this.button1.Location = new System.Drawing.Point(1080, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 53);
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
            this.tvList.Location = new System.Drawing.Point(0, 53);
            this.tvList.Name = "tvList";
            treeNode2.Name = "Düğüm0";
            treeNode2.Text = "Düğüm0";
            this.tvList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvList.Size = new System.Drawing.Size(191, 590);
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
            this.btnCloseTree.Location = new System.Drawing.Point(0, 606);
            this.btnCloseTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseTree.Name = "btnCloseTree";
            this.btnCloseTree.Size = new System.Drawing.Size(191, 37);
            this.btnCloseTree.TabIndex = 4;
            this.btnCloseTree.Text = "Kapat";
            this.btnCloseTree.UseVisualStyleBackColor = false;
            this.btnCloseTree.Visible = false;
            this.btnCloseTree.Click += new System.EventHandler(this.btnCloseTree_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 643);
            this.Controls.Add(this.btnCloseTree);
            this.Controls.Add(this.tvList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListAdd;
        private System.Windows.Forms.Button btnGroupAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPriceDown;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TreeView tvList;
        private System.Windows.Forms.Button btnCloseTree;
    }
}

