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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSesionAdmin));
            mnsBarra = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            iNVENTARIOToolStripMenuItem = new ToolStripMenuItem();
            pROVEEDORESToolStripMenuItem = new ToolStripMenuItem();
            pEDIDOSToolStripMenuItem = new ToolStripMenuItem();
            agregarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            aLERTASToolStripMenuItem = new ToolStripMenuItem();
            sESIONToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            mnsBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(818, 469);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(854, 65);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // frmSesionAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1066, 615);
            Controls.Add(label1);
            Controls.Add(mnsBarra);
            Controls.Add(pictureBox1);
            IsMdiContainer = true;
            MainMenuStrip = mnsBarra;
            Name = "frmSesionAdmin";
            Text = "frmSesionAdmin";
            mnsBarra.ResumeLayout(false);
            mnsBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsBarra;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem iNVENTARIOToolStripMenuItem;
        private ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem pROVEEDORESToolStripMenuItem;
        private ToolStripMenuItem pEDIDOSToolStripMenuItem;
        private ToolStripMenuItem sESIONToolStripMenuItem;
        private ToolStripMenuItem aLERTASToolStripMenuItem;
        private Label label1;
    }
}