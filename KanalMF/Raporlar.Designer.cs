
namespace KanalMF
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMaasSirala = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1353, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMaasSirala
            // 
            this.btnMaasSirala.ActiveBorderThickness = 1;
            this.btnMaasSirala.ActiveCornerRadius = 20;
            this.btnMaasSirala.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnMaasSirala.ActiveForecolor = System.Drawing.Color.White;
            this.btnMaasSirala.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnMaasSirala.BackColor = System.Drawing.SystemColors.Control;
            this.btnMaasSirala.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaasSirala.BackgroundImage")));
            this.btnMaasSirala.ButtonText = "Maaşa Göre Sıralama";
            this.btnMaasSirala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaasSirala.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaasSirala.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnMaasSirala.IdleBorderThickness = 1;
            this.btnMaasSirala.IdleCornerRadius = 20;
            this.btnMaasSirala.IdleFillColor = System.Drawing.Color.White;
            this.btnMaasSirala.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnMaasSirala.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnMaasSirala.Location = new System.Drawing.Point(181, 400);
            this.btnMaasSirala.Margin = new System.Windows.Forms.Padding(5);
            this.btnMaasSirala.Name = "btnMaasSirala";
            this.btnMaasSirala.Size = new System.Drawing.Size(181, 41);
            this.btnMaasSirala.TabIndex = 23;
            this.btnMaasSirala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaasSirala.Click += new System.EventHandler(this.btnMaasSirala_Click);
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 636);
            this.Controls.Add(this.btnMaasSirala);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMaasSirala;
    }
}