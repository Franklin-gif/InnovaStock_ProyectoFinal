namespace Proyecto.InnovaStock
{
    partial class frmPedidosAdmin
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
            grpPedidos = new GroupBox();
            dataGridView1 = new DataGridView();
            btmActu = new Button();
            pictureBox1 = new PictureBox();
            grpPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpPedidos
            // 
            grpPedidos.BackColor = Color.White;
            grpPedidos.BackgroundImage = Properties.Resources.fondo;
            grpPedidos.Controls.Add(dataGridView1);
            grpPedidos.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPedidos.ForeColor = Color.White;
            grpPedidos.Location = new Point(43, 51);
            grpPedidos.Name = "grpPedidos";
            grpPedidos.Size = new Size(971, 425);
            grpPedidos.TabIndex = 0;
            grpPedidos.TabStop = false;
            grpPedidos.Text = "Pedidos";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(931, 381);
            dataGridView1.TabIndex = 0;
            // 
            // btmActu
            // 
            btmActu.BackColor = Color.DimGray;
            btmActu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmActu.ForeColor = Color.White;
            btmActu.Location = new Point(438, 495);
            btmActu.Name = "btmActu";
            btmActu.Size = new Size(176, 45);
            btmActu.TabIndex = 1;
            btmActu.Text = "Actualizar Pedidos";
            btmActu.UseVisualStyleBackColor = false;
            btmActu.Click += btmActu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.fondo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1066, 615);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // frmPedidosAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 615);
            Controls.Add(btmActu);
            Controls.Add(grpPedidos);
            Controls.Add(pictureBox1);
            Name = "frmPedidosAdmin";
            Text = "frmPedidosAdmin";
            grpPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPedidos;
        private DataGridView dataGridView1;
        private Button btmActu;
        private PictureBox pictureBox1;
    }
}