using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lnim.Text = "25.11.6396";
            lnama.Text = "Arif Wibowo Pangestu";
            lkelas.Text = "S1-IF03";
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lnim.Text = "";
            lnama.Text = "";
            lkelas.Text = "";
        }
    }
}
