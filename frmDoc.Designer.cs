namespace StokTakip
{
    partial class frmDoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblSafe = new System.Windows.Forms.Label();
            this.pbSafe = new System.Windows.Forms.PictureBox();
            this.pbDe = new System.Windows.Forms.PictureBox();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 39);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "DÖKÜMASYON";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 39);
            this.panel3.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(504, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 39);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Son Fişi Çıkart";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(248, 203);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(127, 28);
            this.lblDe.TabIndex = 23;
            this.lblDe.Text = "Gün Sonu Al";
            // 
            // lblSafe
            // 
            this.lblSafe.AutoSize = true;
            this.lblSafe.Location = new System.Drawing.Point(418, 203);
            this.lblSafe.Name = "lblSafe";
            this.lblSafe.Size = new System.Drawing.Size(122, 28);
            this.lblSafe.TabIndex = 24;
            this.lblSafe.Text = "Güncel Kasa";
            // 
            // pbSafe
            // 
            this.pbSafe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSafe.Image = global::StokTakip.Properties.Resources._10920724;
            this.pbSafe.Location = new System.Drawing.Point(423, 91);
            this.pbSafe.Name = "pbSafe";
            this.pbSafe.Size = new System.Drawing.Size(82, 83);
            this.pbSafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSafe.TabIndex = 21;
            this.pbSafe.TabStop = false;
            // 
            // pbDe
            // 
            this.pbDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDe.Image = global::StokTakip.Properties.Resources._1055644;
            this.pbDe.Location = new System.Drawing.Point(253, 91);
            this.pbDe.Name = "pbDe";
            this.pbDe.Size = new System.Drawing.Size(82, 83);
            this.pbDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDe.TabIndex = 20;
            this.pbDe.TabStop = false;
            // 
            // pbPrint
            // 
            this.pbPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPrint.Image = global::StokTakip.Properties.Resources.fatura_arsivi;
            this.pbPrint.Location = new System.Drawing.Point(53, 91);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(92, 83);
            this.pbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrint.TabIndex = 18;
            this.pbPrint.TabStop = false;
            this.pbPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(556, 240);
            this.Controls.Add(this.lblSafe);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSafe);
            this.Controls.Add(this.pbDe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbPrint);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoc";
            this.Load += new System.EventHandler(this.frmDoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbDe;
        private System.Windows.Forms.PictureBox pbSafe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblSafe;
    }
}