namespace Proyecto.InnovaStock
{
    partial class frmSesionEmple
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
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            pEDIDOSToolStripMenuItem = new ToolStripMenuItem();
            sEToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, pEDIDOSToolStripMenuItem, sEToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1050, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(69, 25);
            iNICIOToolStripMenuItem.Text = "INICIO";
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click;
            // 
            // pEDIDOSToolStripMenuItem
            // 
            pEDIDOSToolStripMenuItem.Name = "pEDIDOSToolStripMenuItem";
            pEDIDOSToolStripMenuItem.Size = new Size(89, 25);
            pEDIDOSToolStripMenuItem.Text = "PEDIDOS";
            pEDIDOSToolStripMenuItem.Click += pEDIDOSToolStripMenuItem_Click;
            // 
            // sEToolStripMenuItem
            // 
            sEToolStripMenuItem.Name = "sEToolStripMenuItem";
            sEToolStripMenuItem.Size = new Size(78, 25);
            sEToolStripMenuItem.Text = "SESION";
            sEToolStripMenuItem.Click += sEToolStripMenuItem_Click;
            // 
            // frmSesionEmple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1050, 576);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmSesionEmple";
            Text = "frmSesionEmple";
            Load += frmSesionEmple_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem pEDIDOSToolStripMenuItem;
        private ToolStripMenuItem sEToolStripMenuItem;
    }
}