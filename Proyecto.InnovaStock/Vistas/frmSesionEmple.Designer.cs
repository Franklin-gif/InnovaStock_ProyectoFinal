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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSesionEmple));
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            pEDIDOSToolStripMenuItem = new ToolStripMenuItem();
            sEToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(846, 464);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.fondo;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1050, 576);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // frmSesionEmple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 576);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox2);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmSesionEmple";
            Text = "frmSesionEmple";
            Load += frmSesionEmple_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem pEDIDOSToolStripMenuItem;
        private ToolStripMenuItem sEToolStripMenuItem;
        private PictureBox pictureBox2;
    }
}