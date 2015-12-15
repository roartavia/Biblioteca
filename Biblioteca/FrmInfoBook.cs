using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmInfoBook : Form
    {
        public FrmInfoBook()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmSesion nueva = new FrmSesion();
            nueva.Show();
            this.SetVisibleCore(false);
        }
    }
}
