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
            tableLayoutPanel1 = new TableLayoutPanel();
            grpInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpInventario
            // 
            grpInventario.Anchor = AnchorStyles.None;
            grpInventario.BackColor = Color.Silver;
            grpInventario.BackgroundImage = Properties.Resources.fondo;
            grpInventario.Controls.Add(dataGridView1);
            grpInventario.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpInventario.ForeColor = Color.White;
            grpInventario.Location = new Point(153, 28);
            grpInventario.Name = "grpInventario";
            grpInventario.Size = new Size(760, 376);
            grpInventario.TabIndex = 0;
            grpInventario.TabStop = false;
            grpInventario.Text = "Inventario";
            grpInventario.Enter += grpInventario_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(6, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(748, 345);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btmActu
            // 
            btmActu.Anchor = AnchorStyles.None;
            btmActu.BackColor = Color.DimGray;
            btmActu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmActu.ForeColor = Color.White;
            btmActu.Location = new Point(463, 501);
            btmActu.Name = "btmActu";
            btmActu.Size = new Size(140, 44);
            btmActu.TabIndex = 1;
            btmActu.Text = "Actualizar";
            btmActu.UseVisualStyleBackColor = false;
            btmActu.Click += btmActu_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImage = Properties.Resources.fondo;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(grpInventario, 0, 0);
            tableLayoutPanel1.Controls.Add(btmActu, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70.29178F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.7082233F));
            tableLayoutPanel1.Size = new Size(1066, 615);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // frmInventarioAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 615);
            Controls.Add(tableLayoutPanel1);
            Name = "frmInventarioAdmin";
            Text = "frmInventarioAdmin";
            grpInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInventario;
        private DataGridView dataGridView1;
        private Button btmActu;
        private TableLayoutPanel tableLayoutPanel1;
    }
}