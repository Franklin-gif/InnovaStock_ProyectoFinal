using Proyecto.InnovaStock.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.InnovaStock
{
    public partial class frmSesionEmple : Form
    {
        public frmSesionEmple()
        {
            InitializeComponent();
        }

        private void frmSesionEmple_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pEDIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidosEmple PedidosEmple = new frmPedidosEmple();
            PedidosEmple.MdiParent = this;
            PedidosEmple.WindowState = FormWindowState.Maximized;
            PedidosEmple.Show();
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Deseas cerrar sesión?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Cerrar todos los formularios excepto frmInicio
                foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(frm is frmInicio))  // NO cerrar el formulario de inicio
                    {
                        frm.Close();
                    }
                }

                // Crear y mostrar nuevamente el inicio de sesión
                frmInicio inicio = new frmInicio();
                inicio.Show();
            }
        }
    }
}
