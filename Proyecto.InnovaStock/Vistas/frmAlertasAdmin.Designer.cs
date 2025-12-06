namespace Proyecto.InnovaStock
{
    partial class frmAlertasAdmin
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
            grpAlertas = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            grpAlertas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpAlertas
            // 
            grpAlertas.Anchor = AnchorStyles.None;
            grpAlertas.BackColor = Color.Transparent;
            grpAlertas.Controls.Add(dataGridView1);
            grpAlertas.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAlertas.ForeColor = SystemColors.ControlLightLight;
            grpAlertas.Location = new Point(87, 25);
            grpAlertas.Name = "grpAlertas";
            grpAlertas.Size = new Size(891, 350);
            grpAlertas.TabIndex = 0;
            grpAlertas.TabStop = false;
            grpAlertas.Text = "ALERTAS";
            grpAlertas.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(856, 308);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(414, 489);
            button1.Name = "button1";
            button1.Size = new Size(238, 37);
            button1.TabIndex = 1;
            button1.Text = "Ver alertas gmail";
            button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.fondo;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(grpAlertas, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.04065F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.95935F));
            tableLayoutPanel1.Size = new Size(1066, 615);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // frmAlertasAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 615);
            Controls.Add(tableLayoutPanel1);
            Name = "frmAlertasAdmin";
            Text = "frmAlertasAdmin";
            grpAlertas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAlertas;
        private DataGridView dataGridView1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}