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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }
        KanalContainer baglanti = new KanalContainer();
        private void btnMaasSirala_Click(object sender, EventArgs e)
        {

            var sonuc = from m in baglanti.SorumluSet
                        orderby m.SMaas 
                        select m;
            dataGridView1.DataSource = sonuc.Soru

        }
    }
}
