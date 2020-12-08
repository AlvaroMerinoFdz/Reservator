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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtUsuario.Text;
            string pass = txtContraseña.Text;
            
            using(reservatorEntities BDreservator = new reservatorEntities())
            {
                var query = from u in BDreservator.USUARIOS
                            where u.Login==login && u.Password==pass && u.Borrado!=-1
                            select new { u.Login, u.Perfil };
                

                if (query.Count() > 0)
                {
                    var usuario = query.First(x => x.Login.Equals(login));
                    MessageBox.Show("Login correcto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmPrincipal frmPrincipal = new FrmPrincipal(usuario.Perfil);
                    this.Hide();
                    frmPrincipal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                }
               
                

                    
                
            }
            



                       
           
        }
    }
}
