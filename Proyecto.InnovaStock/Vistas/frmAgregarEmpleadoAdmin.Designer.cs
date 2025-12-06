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
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpAñadirProve = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2.SuspendLayout();
            grpAñadirProve.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(180, 327);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(706, 268);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Añadir";
            // 
            // button1
            // 
            button1.Location = new Point(295, 184);
            button1.Name = "button1";
            button1.Size = new Size(101, 28);
            button1.TabIndex = 12;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(485, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(154, 26);
            textBox4.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 26);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 26);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 80);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 80);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 80);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // grpAñadirProve
            // 
            grpAñadirProve.Anchor = AnchorStyles.None;
            grpAñadirProve.BackColor = Color.Transparent;
            grpAñadirProve.Controls.Add(radioButton3);
            grpAñadirProve.Controls.Add(radioButton2);
            grpAñadirProve.Controls.Add(radioButton1);
            grpAñadirProve.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAñadirProve.Location = new Point(286, 42);
            grpAñadirProve.Name = "grpAñadirProve";
            grpAñadirProve.Size = new Size(494, 222);
            grpAñadirProve.TabIndex = 3;
            grpAñadirProve.TabStop = false;
            grpAñadirProve.Text = "Añadir";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(272, 94);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(90, 25);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Eliminar";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(163, 94);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Modificar ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(64, 94);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Añadir";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.fondo;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(grpAñadirProve, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpAñadirProve.ResumeLayout(false);
            grpAñadirProve.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpAñadirProve;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}