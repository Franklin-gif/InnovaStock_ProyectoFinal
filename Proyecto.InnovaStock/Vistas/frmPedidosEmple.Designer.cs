namespace Proyecto.InnovaStock.Vistas
{
    partial class frmPedidosEmple
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            grpPedidos = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Image = Properties.Resources.fondo;
            label1.Location = new Point(462, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 26);
            label1.TabIndex = 0;
            label1.Text = "PEDIDOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Image = Properties.Resources.fondo;
            label2.Location = new Point(416, 228);
            label2.Name = "label2";
            label2.Size = new Size(233, 26);
            label2.TabIndex = 2;
            label2.Text = "Hacer un nuevo pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Heavy", 12F);
            label3.ForeColor = Color.White;
            label3.Image = Properties.Resources.fondo;
            label3.Location = new Point(169, 328);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 3;
            label3.Text = "Producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DimGray;
            label4.Font = new Font("Franklin Gothic Heavy", 12F);
            label4.ForeColor = Color.Transparent;
            label4.Image = Properties.Resources.fondo;
            label4.Location = new Point(169, 273);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 4;
            label4.Text = "Proveedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Heavy", 12F);
            label5.ForeColor = Color.White;
            label5.Image = Properties.Resources.fondo;
            label5.Location = new Point(169, 384);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 5;
            label5.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Heavy", 12F);
            label6.ForeColor = Color.White;
            label6.Image = Properties.Resources.fondo;
            label6.Location = new Point(169, 437);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 6;
            label6.Text = "Descripcion:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 326);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(280, 382);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(298, 437);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(414, 83);
            textBox4.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.fondo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1070, 569);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // grpPedidos
            // 
            grpPedidos.BackColor = Color.White;
            grpPedidos.BackgroundImage = Properties.Resources.fondo;
            grpPedidos.Controls.Add(dataGridView1);
            grpPedidos.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPedidos.ForeColor = Color.White;
            grpPedidos.Location = new Point(119, 38);
            grpPedidos.Name = "grpPedidos";
            grpPedidos.Size = new Size(790, 187);
            grpPedidos.TabIndex = 12;
            grpPedidos.TabStop = false;
            grpPedidos.Text = "Pedidos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(742, 148);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(416, 526);
            button1.Name = "button1";
            button1.Size = new Size(171, 31);
            button1.TabIndex = 13;
            button1.Text = "Realizar Pedido";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmPedidosEmple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 569);
            Controls.Add(button1);
            Controls.Add(grpPedidos);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmPedidosEmple";
            Text = "frmPedidosEmple";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private GroupBox grpPedidos;
        private DataGridView dataGridView1;
        private Button button1;
    }
}