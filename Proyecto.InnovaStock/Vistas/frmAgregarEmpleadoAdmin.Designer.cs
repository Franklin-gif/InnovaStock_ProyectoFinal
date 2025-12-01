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
            label4 = new Label();
            groupBox2.SuspendLayout();
            grpAñadirProve.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(372, 167);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(645, 276);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Añadir";
            // 
            // button1
            // 
            button1.Location = new Point(275, 218);
            button1.Name = "button1";
            button1.Size = new Size(101, 28);
            button1.TabIndex = 12;
            button1.Text = "button1";
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
            grpAñadirProve.Controls.Add(radioButton3);
            grpAñadirProve.Controls.Add(radioButton2);
            grpAñadirProve.Controls.Add(radioButton1);
            grpAñadirProve.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAñadirProve.Location = new Point(25, 41);
            grpAñadirProve.Name = "grpAñadirProve";
            grpAñadirProve.Size = new Size(297, 512);
            grpAñadirProve.TabIndex = 3;
            grpAñadirProve.TabStop = false;
            grpAñadirProve.Text = "Añadir";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(64, 417);
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
            radioButton2.Location = new Point(64, 251);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 89);
            label4.Name = "label4";
            label4.Size = new Size(645, 30);
            label4.TabIndex = 4;
            label4.Text = "NOTA: \r\nSi se quiere eliminar que salga un datagrip con todos los usuarios de empleados en la bd y que al dar 2blo click se elimine";
            // 
            // frmAgregarEmpleadoAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 615);
            Controls.Add(label4);
            Controls.Add(grpAñadirProve);
            Controls.Add(groupBox2);
            Name = "frmAgregarEmpleadoAdmin";
            Text = "frmAgregarEmpleadoAdmin";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpAñadirProve.ResumeLayout(false);
            grpAñadirProve.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label4;
    }
}