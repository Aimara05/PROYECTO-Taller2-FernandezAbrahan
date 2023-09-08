using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        private void personalizarDiseño ()
        {
            panelSubMenu.Visible = false;  
        }

        private void ocultarSubmenu ()
        {
            if (panelSubMenu.Visible) {
            panelSubMenu.Visible = false;
            }
        }

        private void mostrarSubmenu (Panel panelSubMenu)
        {
            if (!panelSubMenu.Visible)
            {
                ocultarSubmenu();
                panelSubMenu.Visible = true;
            }
            else
            {
                panelSubMenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar session?:"
           , "Confirmar Cancelar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void abrirFormularios (Button BUsuario, Form formulario) 
        { 
        }

        private void BProductos_Click(object sender, EventArgs e)
        {
            ocultarSubmenu ();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void BArticulos_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubMenu);
        }
    }
}
