using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanalMF
{
    public partial class Sorumlular : Form
    {
        public Sorumlular()
        {
            InitializeComponent();
        }
        KanalContainer baglanti = new KanalContainer();
        
        public void Goruntule()
        {
            bunifuCustomDataGrid1.DataSource = baglanti.SorumluSet.ToList();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Goruntule();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtSorumluAdSoyad.Tag);
            Sorumlu sil = baglanti.SorumluSet.SingleOrDefault(a => a.SorumluId == no);
            baglanti.SorumluSet.Remove(sil);
            baglanti.SaveChanges();
            Goruntule();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sorumlu ekle = new Sorumlu();
            ekle.SAdSoyad = txtSorumluAdSoyad.Text;
            ekle.SGorevi = txtSorumluGorev.Text;
            ekle.SMaas = Convert.ToDecimal(txtMaas.Text);
            ekle.SorumluGorevSayisi = txtGorevSayisi.Text;
            ekle.YayinYayinId = Convert.ToInt32(comboYayinID.SelectedItem);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtSorumluAdSoyad.Tag);
            Sorumlu update = baglanti.SorumluSet.SingleOrDefault(a => a.SorumluId == no);
            update.SAdSoyad = txtSorumluAdSoyad.Text;
            update.SGorevi = txtSorumluGorev.Text;
            update.SMaas = Convert.ToDecimal(txtMaas.Text);
            update.SorumluGorevSayisi = txtGorevSayisi.Text;
            update.YayinYayinId = Convert.ToInt32(comboYayinID.SelectedItem);

        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = bunifuCustomDataGrid1.CurrentRow;
            txtSorumluAdSoyad.Tag = satir.Cells["SorumluId"].Value.ToString();
            txtSorumluAdSoyad.Text = satir.Cells["SAdSoyad"].Value.ToString();
            txtSorumluGorev.Text = satir.Cells["SGorevi"].Value.ToString();
            txtMaas.Text = satir.Cells["SMaas"].Value.ToString();
            txtGorevSayisi.Text = satir.Cells["SorumluGorevSayisi"].Value.ToString();
            comboYayinID.Text = satir.Cells["YayinYayinID"].Value.ToString();

        }

        
    }
}
