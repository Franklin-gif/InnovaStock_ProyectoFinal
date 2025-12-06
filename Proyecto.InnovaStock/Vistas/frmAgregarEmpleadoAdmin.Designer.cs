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
            button1 = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            textBox3 = new TextBox();
            grpEmpleado.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpEmpleado
            // 
            grpEmpleado.Anchor = AnchorStyles.None;
            grpEmpleado.BackColor = Color.Transparent;
            grpEmpleado.Controls.Add(textBox3);
            grpEmpleado.Controls.Add(label4);
            grpEmpleado.Controls.Add(button1);
            grpEmpleado.Controls.Add(textBox4);
            grpEmpleado.Controls.Add(textBox2);
            grpEmpleado.Controls.Add(textBox1);
            grpEmpleado.Controls.Add(label3);
            grpEmpleado.Controls.Add(label2);
            grpEmpleado.Controls.Add(label1);
            grpEmpleado.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpEmpleado.ForeColor = Color.White;
            grpEmpleado.Location = new Point(180, 8);
            grpEmpleado.Name = "grpEmpleado";
            grpEmpleado.Size = new Size(706, 291);
            grpEmpleado.TabIndex = 2;
            grpEmpleado.TabStop = false;
            grpEmpleado.Text = "Agregar Empleado (Lider)";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(312, 236);
            button1.Name = "button1";
            button1.Size = new Size(156, 38);
            button1.TabIndex = 12;
            button1.Text = "Registar Lider";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(25, 248);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(154, 26);
            textBox4.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 26);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 26);
            textBox1.TabIndex = 6;
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
            label2.Location = new Point(25, 154);
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
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1066, 615);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 86);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 13;
            label4.Text = "Correo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 26);
            textBox3.TabIndex = 14;
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
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox3;
        private Label label4;
    }
}