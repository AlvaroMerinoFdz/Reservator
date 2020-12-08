
namespace Examen2019
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAulas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReservar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdministrar,
            this.tsReservar,
            this.tsInformes,
            this.tsSalir});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(642, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsAdministrar
            // 
            this.tsAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAulas,
            this.tsUsuarios});
            this.tsAdministrar.Name = "tsAdministrar";
            this.tsAdministrar.Size = new System.Drawing.Size(95, 20);
            this.tsAdministrar.Text = "ADMINISTRAR";
            this.tsAdministrar.Visible = false;
            // 
            // tsAulas
            // 
            this.tsAulas.Name = "tsAulas";
            this.tsAulas.Size = new System.Drawing.Size(180, 22);
            this.tsAulas.Text = "Aulas";
            this.tsAulas.Click += new System.EventHandler(this.tsAulas_Click);
            // 
            // tsUsuarios
            // 
            this.tsUsuarios.Name = "tsUsuarios";
            this.tsUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsUsuarios.Text = "Usuarios";
            this.tsUsuarios.Click += new System.EventHandler(this.tsUsuarios_Click);
            // 
            // tsReservar
            // 
            this.tsReservar.Name = "tsReservar";
            this.tsReservar.Size = new System.Drawing.Size(71, 20);
            this.tsReservar.Text = "RESERVAS";
            // 
            // tsInformes
            // 
            this.tsInformes.Name = "tsInformes";
            this.tsInformes.Size = new System.Drawing.Size(76, 20);
            this.tsInformes.Text = "INFORMES";
            // 
            // tsSalir
            // 
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(49, 20);
            this.tsSalir.Text = "SALIR";
            this.tsSalir.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 318);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsAdministrar;
        private System.Windows.Forms.ToolStripMenuItem tsAulas;
        private System.Windows.Forms.ToolStripMenuItem tsUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsReservar;
        private System.Windows.Forms.ToolStripMenuItem tsInformes;
        private System.Windows.Forms.ToolStripMenuItem tsSalir;
    }
}