namespace Proyecto.InnovaStock.Vistas
{
    partial class frmAgregarArticuloAdm
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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = Properties.Resources.fondo;
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Franklin Gothic Heavy", 12F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(122, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(741, 463);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Articulo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 26);
            textBox3.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 191);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 21;
            label4.Text = "Cantidad";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 288);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 26);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 26);
            textBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 339);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 17;
            label3.Text = "Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 264);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 16;
            label2.Text = "Stock Minimo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 47);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 15;
            label1.Text = "Nombre del Articulo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 115);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 23;
            label5.Text = "Categoria";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboBox1.Location = new Point(30, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 29);
            comboBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboBox2.Location = new Point(30, 357);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(154, 29);
            comboBox2.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.fondo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(973, 557);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmAgregarArticuloAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 557);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "frmAgregarArticuloAdm";
            Text = "frmAgregarArticuloAdm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}