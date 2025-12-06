namespace Proyecto.InnovaStock
{
    partial class frmSesionAdmin
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
            mnsBarra = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            iNVENTARIOToolStripMenuItem = new ToolStripMenuItem();
            pROVEEDORESToolStripMenuItem = new ToolStripMenuItem();
            pEDIDOSToolStripMenuItem = new ToolStripMenuItem();
            agregarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            aLERTASToolStripMenuItem = new ToolStripMenuItem();
            sESIONToolStripMenuItem = new ToolStripMenuItem();
            mnsBarra.SuspendLayout();
            SuspendLayout();
            // 
            // mnsBarra
            // 
            mnsBarra.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnsBarra.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, iNVENTARIOToolStripMenuItem, pROVEEDORESToolStripMenuItem, pEDIDOSToolStripMenuItem, agregarEmpleadoToolStripMenuItem, aLERTASToolStripMenuItem, sESIONToolStripMenuItem });
            mnsBarra.Location = new Point(0, 0);
            mnsBarra.Name = "mnsBarra";
            mnsBarra.Size = new Size(1066, 29);
            mnsBarra.TabIndex = 0;
            mnsBarra.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(69, 25);
            iNICIOToolStripMenuItem.Text = "INICIO";
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click;
            // 
            // iNVENTARIOToolStripMenuItem
            // 
            iNVENTARIOToolStripMenuItem.Name = "iNVENTARIOToolStripMenuItem";
            iNVENTARIOToolStripMenuItem.Size = new Size(113, 25);
            iNVENTARIOToolStripMenuItem.Text = "INVENTARIO";
            iNVENTARIOToolStripMenuItem.Click += iNVENTARIOToolStripMenuItem_Click;
            // 
            // pROVEEDORESToolStripMenuItem
            // 
            pROVEEDORESToolStripMenuItem.Name = "pROVEEDORESToolStripMenuItem";
            pROVEEDORESToolStripMenuItem.Size = new Size(134, 25);
            pROVEEDORESToolStripMenuItem.Text = "PROVEEDORES";
            pROVEEDORESToolStripMenuItem.Click += pROVEEDORESToolStripMenuItem_Click;
            // 
            // pEDIDOSToolStripMenuItem
            // 
            pEDIDOSToolStripMenuItem.Name = "pEDIDOSToolStripMenuItem";
            pEDIDOSToolStripMenuItem.Size = new Size(89, 25);
            pEDIDOSToolStripMenuItem.Text = "PEDIDOS";
            pEDIDOSToolStripMenuItem.Click += pEDIDOSToolStripMenuItem_Click;
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            agregarEmpleadoToolStripMenuItem.Size = new Size(181, 25);
            agregarEmpleadoToolStripMenuItem.Text = "AGREGAR EMPLEADO";
            agregarEmpleadoToolStripMenuItem.Click += agregarEmpleadoToolStripMenuItem_Click;
            // 
            // aLERTASToolStripMenuItem
            // 
            aLERTASToolStripMenuItem.Name = "aLERTASToolStripMenuItem";
            aLERTASToolStripMenuItem.Size = new Size(89, 25);
            aLERTASToolStripMenuItem.Text = "ALERTAS";
            aLERTASToolStripMenuItem.Click += aLERTASToolStripMenuItem_Click;
            // 
            // sESIONToolStripMenuItem
            // 
            sESIONToolStripMenuItem.Name = "sESIONToolStripMenuItem";
            sESIONToolStripMenuItem.Size = new Size(78, 25);
            sESIONToolStripMenuItem.Text = "SESION";
            sESIONToolStripMenuItem.Click += sESIONToolStripMenuItem_Click;
            // 
            // frmSesionAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1066, 615);
            Controls.Add(mnsBarra);
            IsMdiContainer = true;
            MainMenuStrip = mnsBarra;
            Name = "frmSesionAdmin";
            Text = "frmSesionAdmin";
            Load += frmSesionAdmin_Load;
            mnsBarra.ResumeLayout(false);
            mnsBarra.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsBarra;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem iNVENTARIOToolStripMenuItem;
        private ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem pROVEEDORESToolStripMenuItem;
        private ToolStripMenuItem pEDIDOSToolStripMenuItem;
        private ToolStripMenuItem sESIONToolStripMenuItem;
        private ToolStripMenuItem aLERTASToolStripMenuItem;
    }
}