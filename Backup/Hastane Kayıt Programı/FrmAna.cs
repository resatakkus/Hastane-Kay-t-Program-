using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void btnSekreter_Click(object sender, EventArgs e)
        {
            FrmSekreter frm = new FrmSekreter();
            frm.ShowDialog();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            FrmDoktor frm = new FrmDoktor();
            frm.ShowDialog();
        }
    }
}
