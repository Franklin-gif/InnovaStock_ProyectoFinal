namespace Proyecto.InnovaStock
{
    partial class frmAgregarEmpleadoAdmin
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
            grpEmpleado = new GroupBox();
            btnVer = new Button();
            txtUsuario = new TextBox();
            label4 = new Label();
            btnRegistarLider = new Button();
            txtContrasena = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            grpEmpleado.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpEmpleado
            // 
            grpEmpleado.Anchor = AnchorStyles.None;
            grpEmpleado.BackColor = Color.Transparent;
            grpEmpleado.Controls.Add(btnVer);
            grpEmpleado.Controls.Add(txtUsuario);
            grpEmpleado.Controls.Add(label4);
            grpEmpleado.Controls.Add(btnRegistarLider);
            grpEmpleado.Controls.Add(txtContrasena);
            grpEmpleado.Controls.Add(txtCorreo);
            grpEmpleado.Controls.Add(txtNombre);
            grpEmpleado.Controls.Add(label3);
            grpEmpleado.Controls.Add(label2);
            grpEmpleado.Controls.Add(label1);
            grpEmpleado.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpEmpleado.ForeColor = Color.White;
            grpEmpleado.Location = new Point(180, 152);
            grpEmpleado.Name = "grpEmpleado";
            grpEmpleado.Size = new Size(706, 311);
            grpEmpleado.TabIndex = 2;
            grpEmpleado.TabStop = false;
            grpEmpleado.Text = "Agregar Empleado (Lider)";
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.MediumOrchid;
            btnVer.BackgroundImage = Properties.Resources.fondo;
            btnVer.ForeColor = Color.Black;
            btnVer.Location = new Point(185, 248);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(57, 28);
            btnVer.TabIndex = 15;
            btnVer.Text = "👀";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(25, 110);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(154, 26);
            txtUsuario.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 154);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 13;
            label4.Text = "Correo";
            // 
            // btnRegistarLider
            // 
            btnRegistarLider.BackColor = Color.DimGray;
            btnRegistarLider.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistarLider.ForeColor = Color.White;
            btnRegistarLider.Location = new Point(312, 236);
            btnRegistarLider.Name = "btnRegistarLider";
            btnRegistarLider.Size = new Size(156, 38);
            btnRegistarLider.TabIndex = 12;
            btnRegistarLider.Text = "Registar Lider";
            btnRegistarLider.UseVisualStyleBackColor = false;
            btnRegistarLider.Click += btnRegistarLider_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(25, 248);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(154, 26);
            txtContrasena.TabIndex = 9;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(25, 178);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(154, 26);
            txtCorreo.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 26);
            txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 224);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 86);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.fondo;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(grpEmpleado, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1066, 615);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // frmAgregarEmpleadoAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1066, 615);
            Controls.Add(tableLayoutPanel1);
            Name = "frmAgregarEmpleadoAdmin";
            Text = "frmAgregarEmpleadoAdmin";
            Load += frmAgregarEmpleadoAdmin_Load;
            grpEmpleado.ResumeLayout(false);
            grpEmpleado.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpEmpleado;
        private Button btnRegistarLider;
        private TextBox txtContrasena;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtUsuario;
        private Label label4;
        private Button btnVer;
    }
}