using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmSearchResultDos : Form
    {
        public FrmSearchResultDos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSearchResult_Load(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmInfoBook frmnuev = new FrmInfoBook();
            frmnuev.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmSesion nueva = new FrmSesion();
            nueva.Show();
            this.SetVisibleCore(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSearchResult nueva = new FrmSearchResult();
            nueva.Show();
            this.SetVisibleCore(false);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
