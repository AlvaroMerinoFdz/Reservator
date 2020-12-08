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
    public partial class frmAula : Form
    {
        public frmAula()
        {
            InitializeComponent();
        }
        private void cargarNavigator()
        {
            using (reservatorEntities BDreservator = new reservatorEntities())
            {
                var aulas = from u in BDreservator.AULAS
                               where u.Borrado != -1
                               select u.Cod_aula;
                var users = aulas.ToList();
                sourceNav.DataSource = users;
                this.navAula.BindingSource = sourceNav;
            }
        }
        private void cargarDatos()
        {
            using (reservatorEntities BDreservator = new reservatorEntities())
            {
                var usuario = from u in BDreservator.AULAS
                              select new { u.Cod_aula, u.Descripcion, u.Foto, u.Borrado };
                String aula = sourceNav.Current.ToString();
                var user = usuario.First(a => a.Cod_aula.Equals(aula));
                txtCodigo.Text = user.Cod_aula;
                txtDescripcion.Text = user.Descripcion;
                //pbFoto.Image = user.Foto;

            }
        }

        private void frmAula_Load(object sender, EventArgs e)
        {
            cargarNavigator();
        }

        private void sourceNav_CurrentItemChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            ofdImagen.ShowDialog();
        }
    }
}
