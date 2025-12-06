namespace Proyecto.InnovaStock
{
    partial class frmProovedoresAdmin
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvProveedores = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            grpProveedor = new GroupBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            grpProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImage = Properties.Resources.fondo;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1055F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(grpProveedor, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvProveedores, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 442F));
            tableLayoutPanel1.Size = new Size(1066, 615);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // dgvProveedores
            // 
            dgvProveedores.Anchor = AnchorStyles.None;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(265, 7);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(536, 158);
            dgvProveedores.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(37, 45);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre del proveedor";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(37, 128);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 3;
            label4.Text = "Correo Electrónico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(37, 211);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 4;
            label5.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(33, 304);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 26);
            textBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 26);
            textBox3.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(37, 235);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(154, 26);
            textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboBox1.Location = new Point(37, 328);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 29);
            comboBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(247, 389);
            button1.Name = "button1";
            button1.Size = new Size(220, 40);
            button1.TabIndex = 12;
            button1.Text = "Guardar Proveedor";
            button1.UseVisualStyleBackColor = false;
            // 
            // grpProveedor
            // 
            grpProveedor.Anchor = AnchorStyles.None;
            grpProveedor.BackgroundImage = Properties.Resources.fondo;
            grpProveedor.Controls.Add(button1);
            grpProveedor.Controls.Add(comboBox1);
            grpProveedor.Controls.Add(textBox5);
            grpProveedor.Controls.Add(textBox3);
            grpProveedor.Controls.Add(textBox1);
            grpProveedor.Controls.Add(label6);
            grpProveedor.Controls.Add(label5);
            grpProveedor.Controls.Add(label4);
            grpProveedor.Controls.Add(label1);
            grpProveedor.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpProveedor.ForeColor = Color.White;
            grpProveedor.Location = new Point(203, 176);
            grpProveedor.Name = "grpProveedor";
            grpProveedor.Size = new Size(659, 436);
            grpProveedor.TabIndex = 1;
            grpProveedor.TabStop = false;
            grpProveedor.Text = "Añadir Proveedor";
            // 
            // frmProovedoresAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 615);
            Controls.Add(tableLayoutPanel1);
            Name = "frmProovedoresAdmin";
            Text = "frmProovedoresAdmin";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            grpProveedor.ResumeLayout(false);
            grpProveedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpProveedor;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private DataGridView dgvProveedores;
    }
}