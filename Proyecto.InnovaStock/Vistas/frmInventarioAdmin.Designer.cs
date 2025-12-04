namespace Proyecto.InnovaStock
{
    partial class frmInventarioAdmin
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
            grpInventario = new GroupBox();
            dataGridView1 = new DataGridView();
            btmActu = new Button();
            grpPedidoInv = new GroupBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            nudCant = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            grpInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpPedidoInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpInventario
            // 
            grpInventario.BackColor = Color.Silver;
            grpInventario.BackgroundImage = Properties.Resources.fondo;
            grpInventario.Controls.Add(dataGridView1);
            grpInventario.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpInventario.ForeColor = Color.White;
            grpInventario.Location = new Point(203, 65);
            grpInventario.Name = "grpInventario";
            grpInventario.Size = new Size(652, 233);
            grpInventario.TabIndex = 0;
            grpInventario.TabStop = false;
            grpInventario.Text = "Inventario";
            grpInventario.Enter += grpInventario_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(18, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(613, 194);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btmActu
            // 
            btmActu.BackColor = Color.DimGray;
            btmActu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmActu.ForeColor = Color.White;
            btmActu.Location = new Point(460, 304);
            btmActu.Name = "btmActu";
            btmActu.Size = new Size(140, 44);
            btmActu.TabIndex = 1;
            btmActu.Text = "Actualizar";
            btmActu.UseVisualStyleBackColor = false;
            btmActu.Click += btmActu_Click;
            // 
            // grpPedidoInv
            // 
            grpPedidoInv.BackColor = Color.Silver;
            grpPedidoInv.BackgroundImage = Properties.Resources.fondo;
            grpPedidoInv.Controls.Add(button1);
            grpPedidoInv.Controls.Add(comboBox2);
            grpPedidoInv.Controls.Add(comboBox1);
            grpPedidoInv.Controls.Add(nudCant);
            grpPedidoInv.Controls.Add(label3);
            grpPedidoInv.Controls.Add(label2);
            grpPedidoInv.Controls.Add(label1);
            grpPedidoInv.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPedidoInv.ForeColor = Color.White;
            grpPedidoInv.Location = new Point(231, 354);
            grpPedidoInv.Name = "grpPedidoInv";
            grpPedidoInv.Size = new Size(579, 199);
            grpPedidoInv.TabIndex = 2;
            grpPedidoInv.TabStop = false;
            grpPedidoInv.Text = "Reeabastecer";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(216, 145);
            button1.Name = "button1";
            button1.Size = new Size(171, 31);
            button1.TabIndex = 3;
            button1.Text = "Realizar Pedido";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(132, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 29);
            comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 14;
            // 
            // nudCant
            // 
            nudCant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCant.Location = new Point(375, 93);
            nudCant.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            nudCant.Name = "nudCant";
            nudCant.Size = new Size(157, 29);
            nudCant.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(165, 31);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "Proovedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(293, 96);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(57, 96);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.fondo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1066, 615);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmInventarioAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 615);
            Controls.Add(grpPedidoInv);
            Controls.Add(btmActu);
            Controls.Add(grpInventario);
            Controls.Add(pictureBox1);
            Name = "frmInventarioAdmin";
            Text = "frmInventarioAdmin";
            grpInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpPedidoInv.ResumeLayout(false);
            grpPedidoInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCant).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInventario;
        private DataGridView dataGridView1;
        private Button btmActu;
        private GroupBox grpPedidoInv;
        private NumericUpDown nudCant;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}