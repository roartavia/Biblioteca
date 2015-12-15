using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmSearchResultTres : Form
    {
        public FrmSearchResultTres()
        {
            InitializeComponent();
        }

        private void FrmSearchResultTres_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmInfoBook frmnuev = new FrmInfoBook();
            frmnuev.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmSesion nuevaSession = new FrmSesion();
            nuevaSession.Show();
            this.SetVisibleCore(false);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmSesion nueva = new FrmSesion();
            nueva.Show();
            this.SetVisibleCore(false);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
