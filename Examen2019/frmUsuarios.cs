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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarNavigator();
        }
        private void cargarNavigator()
        {
            using (reservatorEntities BDreservator = new reservatorEntities())
            {
                var usuarios = from u in BDreservator.USUARIOS
                               where u.Borrado != -1
                               select u.Login;
                var users = usuarios.ToList();
                navSource.DataSource = users;
                this.bnUsuarios.BindingSource = navSource;
            }
        }
        private void cargarDatos()
        {
            using (reservatorEntities BDreservator = new reservatorEntities())
            {
                var usuario = from u in BDreservator.USUARIOS
                              select new { u.Login, u.Password, u.Email, u.Perfil };
                String login = navSource.Current.ToString();
                var user = usuario.First(a => a.Login.Equals(login));
                txtLogin.Text = user.Login;
                txtPass.Text = user.Password;
                txtEmail.Text = user.Email;
                cmbPerfil.SelectedIndex = user.Perfil - 1;
            }
        }
        private void tsEliminar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            using (reservatorEntities BDreservator = new reservatorEntities())
            {
                var users = from u in BDreservator.USUARIOS
                            where u.Login == login
                            select u.Login;
                if (users.Contains(login))
                {
                    USUARIOS user = BDreservator.USUARIOS.First(x => x.Login.Equals(login));
                    user.Borrado = -1;
                    BDreservator.SaveChanges();
                    MessageBox.Show("Usuario borrado correctamente", "Usuario borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void navSource_CurrentItemChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
