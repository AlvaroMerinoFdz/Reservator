using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2019
{
    public partial class FrmPrincipal : Form
    {
        private int perfil;
        public FrmPrincipal(int perfil)
        {
            InitializeComponent();
            this.perfil = perfil;
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (this.perfil == 2)
            {
                tsAdministrar.Visible = true;
            }
        }

        private void tsUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Dock = DockStyle.Fill;
            frmUsuarios.Show();
            
        }
    }
}
