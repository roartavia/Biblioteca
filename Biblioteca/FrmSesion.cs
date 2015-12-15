using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmSesion : Form
    {
        public FrmSesion()
        {
            InitializeComponent();
        }

        private void FrmSesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")) 
            {
                FrmSearchResult frmNewSearch = new FrmSearchResult();
                this.SetVisibleCore(false);
                frmNewSearch.Show();
            }
            else if ("Isaac Asimov".ToLower().Contains(textBox1.Text.ToLower()))
            {
                FrmSearchResultTres frmNewSearch = new FrmSearchResultTres();
                this.SetVisibleCore(false);
                frmNewSearch.Show();
            }
            else 
            {
                MessageBox.Show("No se encontraron resultados.");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
