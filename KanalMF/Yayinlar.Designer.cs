
namespace KanalMF
{
    partial class Yayinlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yayinlar));
            this.txtYayinRayting = new System.Windows.Forms.TextBox();
            this.dateYayinTarih = new System.Windows.Forms.DateTimePicker();
            this.txtYayinAdi = new System.Windows.Forms.TextBox();
            this.comboKanalId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnGuncelle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnListele = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYayinRayting
            // 
            this.txtYayinRayting.Location = new System.Drawing.Point(381, 318);
            this.txtYayinRayting.Name = "txtYayinRayting";
            this.txtYayinRayting.Size = new System.Drawing.Size(100, 20);
            this.txtYayinRayting.TabIndex = 15;
            // 
            // dateYayinTarih
            // 
            this.dateYayinTarih.Location = new System.Drawing.Point(381, 249);
            this.dateYayinTarih.Name = "dateYayinTarih";
            this.dateYayinTarih.Size = new System.Drawing.Size(200, 20);
            this.dateYayinTarih.TabIndex = 14;
            // 
            // txtYayinAdi
            // 
            this.txtYayinAdi.Location = new System.Drawing.Point(381, 166);
            this.txtYayinAdi.Name = "txtYayinAdi";
            this.txtYayinAdi.Size = new System.Drawing.Size(100, 20);
            this.txtYayinAdi.TabIndex = 13;
            // 
            // comboKanalId
            // 
            this.comboKanalId.FormattingEnabled = true;
            this.comboKanalId.Location = new System.Drawing.Point(381, 112);
            this.comboKanalId.Name = "comboKanalId";
            this.comboKanalId.Size = new System.Drawing.Size(121, 21);
            this.comboKanalId.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yayın Reytingi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yayın Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yayın Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kanal Id";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(811, 112);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(560, 227);
            this.bunifuCustomDataGrid1.TabIndex = 16;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ActiveBorderThickness = 1;
            this.btnGuncelle.ActiveCornerRadius = 20;
            this.btnGuncelle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuncelle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.ButtonText = "Guncelle";
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.IdleBorderThickness = 1;
            this.btnGuncelle.IdleCornerRadius = 20;
            this.btnGuncelle.IdleFillColor = System.Drawing.Color.White;
            this.btnGuncelle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.Location = new System.Drawing.Point(1083, 398);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(181, 41);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEkle
            // 
            this.btnEkle.ActiveBorderThickness = 1;
            this.btnEkle.ActiveCornerRadius = 20;
            this.btnEkle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEkle.ActiveForecolor = System.Drawing.Color.White;
            this.btnEkle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.ButtonText = "Ekle";
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEkle.IdleBorderThickness = 1;
            this.btnEkle.IdleCornerRadius = 20;
            this.btnEkle.IdleFillColor = System.Drawing.Color.White;
            this.btnEkle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEkle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEkle.Location = new System.Drawing.Point(892, 398);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(181, 41);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSil
            // 
            this.btnSil.ActiveBorderThickness = 1;
            this.btnSil.ActiveCornerRadius = 20;
            this.btnSil.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSil.ActiveForecolor = System.Drawing.Color.White;
            this.btnSil.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSil.BackColor = System.Drawing.SystemColors.Control;
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.ButtonText = "Sil";
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSil.IdleBorderThickness = 1;
            this.btnSil.IdleCornerRadius = 20;
            this.btnSil.IdleFillColor = System.Drawing.Color.White;
            this.btnSil.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSil.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSil.Location = new System.Drawing.Point(1083, 347);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(181, 41);
            this.btnSil.TabIndex = 18;
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListele
            // 
            this.btnListele.ActiveBorderThickness = 1;
            this.btnListele.ActiveCornerRadius = 20;
            this.btnListele.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnListele.ActiveForecolor = System.Drawing.Color.White;
            this.btnListele.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnListele.BackColor = System.Drawing.SystemColors.Control;
            this.btnListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListele.BackgroundImage")));
            this.btnListele.ButtonText = "Listele";
            this.btnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListele.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnListele.IdleBorderThickness = 1;
            this.btnListele.IdleCornerRadius = 20;
            this.btnListele.IdleFillColor = System.Drawing.Color.White;
            this.btnListele.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnListele.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnListele.Location = new System.Drawing.Point(892, 347);
            this.btnListele.Margin = new System.Windows.Forms.Padding(5);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(181, 41);
            this.btnListele.TabIndex = 17;
            this.btnListele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Yayinlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 683);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.txtYayinRayting);
            this.Controls.Add(this.dateYayinTarih);
            this.Controls.Add(this.txtYayinAdi);
            this.Controls.Add(this.comboKanalId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Yayinlar";
            this.Text = "Yayinlar";
            this.Load += new System.EventHandler(this.Yayinlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYayinRayting;
        private System.Windows.Forms.DateTimePicker dateYayinTarih;
        private System.Windows.Forms.TextBox txtYayinAdi;
        private System.Windows.Forms.ComboBox comboKanalId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuncelle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEkle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSil;
        private Bunifu.Framework.UI.BunifuThinButton2 btnListele;
    }
}