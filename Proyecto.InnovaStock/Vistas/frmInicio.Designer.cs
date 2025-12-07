namespace Proyecto.InnovaStock
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            panel1 = new Panel();
            btmIcon = new TableLayoutPanel();
            btmInicio = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            btmIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btmIcon);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1218, 820);
            panel1.TabIndex = 0;
            // 
            // btmIcon
            // 
            btmIcon.BackColor = Color.Transparent;
            btmIcon.BackgroundImage = Properties.Resources.fondo;
            btmIcon.ColumnCount = 1;
            btmIcon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            btmIcon.Controls.Add(btmInicio, 0, 2);
            btmIcon.Controls.Add(pictureBox1, 0, 0);
            btmIcon.Controls.Add(panel2, 0, 1);
            btmIcon.Dock = DockStyle.Fill;
            btmIcon.Location = new Point(0, 0);
            btmIcon.Margin = new Padding(3, 4, 3, 4);
            btmIcon.Name = "btmIcon";
            btmIcon.RowCount = 3;
            btmIcon.RowStyles.Add(new RowStyle(SizeType.Percent, 52.7649765F));
            btmIcon.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2350235F));
            btmIcon.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            btmIcon.Size = new Size(1218, 820);
            btmIcon.TabIndex = 7;
            // 
            // btmInicio
            // 
            btmInicio.Anchor = AnchorStyles.None;
            btmInicio.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmInicio.Location = new Point(493, 662);
            btmInicio.Margin = new Padding(3, 4, 3, 4);
            btmInicio.Name = "btmInicio";
            btmInicio.Size = new Size(232, 75);
            btmInicio.TabIndex = 0;
            btmInicio.Text = "Iniciar Sesion";
            btmInicio.UseVisualStyleBackColor = true;
            btmInicio.Click += btmInicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(738, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtContra);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(350, 346);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(517, 192);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.fondo;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(449, 91);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(48, 39);
            button1.TabIndex = 5;
            button1.Text = "👀\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtContra
            // 
            txtContra.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContra.Location = new Point(249, 80);
            txtContra.Margin = new Padding(3, 4, 3, 4);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(193, 52);
            txtContra.TabIndex = 4;
            txtContra.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(249, 3);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(193, 52);
            txtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 80);
            label2.Name = "label2";
            label2.Size = new Size(189, 46);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 3);
            label1.Name = "label1";
            label1.Size = new Size(133, 46);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 820);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInicio";
            Text = "frmInicio";
            Load += frmInicio_Load;
            panel1.ResumeLayout(false);
            btmIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btmInicio;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Label label2;
        private PictureBox pictureBox1;
        private TableLayoutPanel btmIcon;
        private Panel panel2;
        private Button button1;
    }
}
