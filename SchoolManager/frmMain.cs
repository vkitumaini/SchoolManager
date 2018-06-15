using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }

        private void paramètreFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void identificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEleve el= new frmEleve();
            el.MdiParent = this;
            el.Show();
        }
    }
}
