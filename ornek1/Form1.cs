using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek1
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

        private void txturunler_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSebeteEkle_Click(object sender, EventArgs e)
        {
            lstMeyveler.Items.Add(txturunler.Text);
            txturunler.Text = "";
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMeyveler.Items.Remove(lstMeyveler.SelectedItem);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstMeyveler.Items.Clear();
        }
    }
}
