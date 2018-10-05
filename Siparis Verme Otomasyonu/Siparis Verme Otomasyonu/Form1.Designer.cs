namespace Siparis_Verme_Otomasyonu
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.rdbShipper1 = new System.Windows.Forms.RadioButton();
            this.rdbShipper2 = new System.Windows.Forms.RadioButton();
            this.rdbShipper3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 154);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(105, 12);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(130, 28);
            this.cmbKategori.TabIndex = 2;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adi:";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Urun Fiyati:";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stok:";
            this.columnHeader3.Width = 125;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(24, 242);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(118, 51);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Sepete Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisVer.Location = new System.Drawing.Point(293, 242);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(118, 51);
            this.btnSiparisVer.TabIndex = 4;
            this.btnSiparisVer.Text = "Siparis Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 25;
            this.lstSepet.Location = new System.Drawing.Point(24, 313);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(221, 104);
            this.lstSepet.TabIndex = 5;
            // 
            // rdbShipper1
            // 
            this.rdbShipper1.AutoSize = true;
            this.rdbShipper1.Location = new System.Drawing.Point(417, 81);
            this.rdbShipper1.Name = "rdbShipper1";
            this.rdbShipper1.Size = new System.Drawing.Size(14, 13);
            this.rdbShipper1.TabIndex = 6;
            this.rdbShipper1.TabStop = true;
            this.rdbShipper1.UseVisualStyleBackColor = true;
            // 
            // rdbShipper2
            // 
            this.rdbShipper2.AutoSize = true;
            this.rdbShipper2.Location = new System.Drawing.Point(417, 116);
            this.rdbShipper2.Name = "rdbShipper2";
            this.rdbShipper2.Size = new System.Drawing.Size(14, 13);
            this.rdbShipper2.TabIndex = 7;
            this.rdbShipper2.TabStop = true;
            this.rdbShipper2.UseVisualStyleBackColor = true;
            // 
            // rdbShipper3
            // 
            this.rdbShipper3.AutoSize = true;
            this.rdbShipper3.Location = new System.Drawing.Point(417, 151);
            this.rdbShipper3.Name = "rdbShipper3";
            this.rdbShipper3.Size = new System.Drawing.Size(14, 13);
            this.rdbShipper3.TabIndex = 8;
            this.rdbShipper3.TabStop = true;
            this.rdbShipper3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 433);
            this.Controls.Add(this.rdbShipper3);
            this.Controls.Add(this.rdbShipper2);
            this.Controls.Add(this.rdbShipper1);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.RadioButton rdbShipper1;
        private System.Windows.Forms.RadioButton rdbShipper2;
        private System.Windows.Forms.RadioButton rdbShipper3;
    }
}

