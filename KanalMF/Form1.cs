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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Kanallar")
            {
                Kanallar git = new Kanallar();
                git.Show();
                this.Hide();
            }
            if (comboBox1.SelectedItem == "Yayınlar")
            {
                Yayinlar git = new Yayinlar();
                git.Show();
                this.Hide();
            }
            if (comboBox1.SelectedItem == "Sorumlular")
            {
                Sorumlular git = new Sorumlular();
                git.Show();
                this.Hide();
            }
        }
    }
}
