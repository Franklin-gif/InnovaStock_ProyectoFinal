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
    public partial class frmSesionAdmin : Form
    {
        public frmSesionAdmin()
        {
            InitializeComponent();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleadoAdmin agregarEmpleadoAdmin = new frmAgregarEmpleadoAdmin();
            agregarEmpleadoAdmin.MdiParent = this;
            agregarEmpleadoAdmin.WindowState = FormWindowState.Maximized;
            agregarEmpleadoAdmin.Show();
        }

        private void aÑADIRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventarioAdmin inventarioAdmin = new frmInventarioAdmin();
            inventarioAdmin.MdiParent = this;
            inventarioAdmin.WindowState = FormWindowState.Maximized;
            inventarioAdmin.Show();
        }

        private void pROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProovedoresAdmin proveedoresAdmin = new frmProovedoresAdmin();
            proveedoresAdmin.MdiParent = this;
            proveedoresAdmin.WindowState = FormWindowState.Maximized;
            proveedoresAdmin.Show();
        }

        private void pEDIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidosAdmin pedidosAdmin = new frmPedidosAdmin();
            pedidosAdmin.MdiParent = this;
            pedidosAdmin.WindowState = FormWindowState.Maximized;
            pedidosAdmin.Show();
        }

        private void aLERTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlertasAdmin alertasAdmin = new frmAlertasAdmin();
            alertasAdmin.MdiParent = this;
            alertasAdmin.WindowState = FormWindowState.Maximized;
            alertasAdmin.Show();
        }

        private void sESIONToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void frmSesionAdmin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
