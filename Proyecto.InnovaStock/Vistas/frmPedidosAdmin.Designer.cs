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
            tableLayoutPanel1 = new TableLayoutPanel();
            grpPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpPedidos
            // 
            grpPedidos.Anchor = AnchorStyles.None;
            grpPedidos.BackColor = Color.White;
            grpPedidos.BackgroundImage = Properties.Resources.fondo;
            grpPedidos.Controls.Add(dataGridView1);
            grpPedidos.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPedidos.ForeColor = Color.White;
            grpPedidos.Location = new Point(47, 3);
            grpPedidos.Name = "grpPedidos";
            grpPedidos.Size = new Size(971, 423);
            grpPedidos.TabIndex = 0;
            grpPedidos.TabStop = false;
            grpPedidos.Text = "Pedidos";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(965, 398);
            dataGridView1.TabIndex = 0;
            // 
            // btmActu
            // 
            btmActu.Anchor = AnchorStyles.Top;
            btmActu.BackColor = Color.DimGray;
            btmActu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmActu.ForeColor = Color.White;
            btmActu.Location = new Point(445, 432);
            btmActu.Name = "btmActu";
            btmActu.Size = new Size(176, 45);
            btmActu.TabIndex = 1;
            btmActu.Text = "Actualizar Pedidos";
            btmActu.UseVisualStyleBackColor = false;
            btmActu.Click += btmActu_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImage = Properties.Resources.fondo;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(grpPedidos, 0, 0);
            tableLayoutPanel1.Controls.Add(btmActu, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 186F));
            tableLayoutPanel1.Size = new Size(1066, 615);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // frmPedidosAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 615);
            Controls.Add(tableLayoutPanel1);
            Name = "frmPedidosAdmin";
            Text = "frmPedidosAdmin";
            Load += frmPedidosAdmin_Load;
            grpPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPedidos;
        private DataGridView dataGridView1;
        private Button btmActu;
        private TableLayoutPanel tableLayoutPanel1;
    }
}