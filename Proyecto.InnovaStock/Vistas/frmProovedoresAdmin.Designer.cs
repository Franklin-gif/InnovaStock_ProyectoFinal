namespace Proyecto.InnovaStock
{
    partial class frmProovedoresAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            grpProveedor = new GroupBox();
            lblSub = new Label();
            btnConfirmar = new Button();
            cbEstadoPro = new ComboBox();
            txtTelefonoPro = new TextBox();
            txtCorreoPro = new TextBox();
            txtNombrePro = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            cbxEliminar = new CheckBox();
            cbxEditar = new CheckBox();
            cbxAñadir = new CheckBox();
            dgvProveedores = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            grpProveedor.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImage = Properties.Resources.fondo;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1032F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 197F));
            tableLayoutPanel1.Controls.Add(grpProveedor, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvProveedores, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 589F));
            tableLayoutPanel1.Size = new Size(1218, 820);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // grpProveedor
            // 
            grpProveedor.Anchor = AnchorStyles.Right;
            grpProveedor.BackgroundImage = Properties.Resources.fondo;
            grpProveedor.Controls.Add(lblSub);
            grpProveedor.Controls.Add(btnConfirmar);
            grpProveedor.Controls.Add(cbEstadoPro);
            grpProveedor.Controls.Add(txtTelefonoPro);
            grpProveedor.Controls.Add(txtCorreoPro);
            grpProveedor.Controls.Add(txtNombrePro);
            grpProveedor.Controls.Add(label6);
            grpProveedor.Controls.Add(label5);
            grpProveedor.Controls.Add(label4);
            grpProveedor.Controls.Add(label1);
            grpProveedor.Font = new Font("Franklin Gothic Heavy", 12F);
            grpProveedor.ForeColor = Color.White;
            grpProveedor.Location = new Point(255, 235);
            grpProveedor.Margin = new Padding(3, 4, 3, 4);
            grpProveedor.Name = "grpProveedor";
            grpProveedor.Padding = new Padding(3, 4, 3, 4);
            grpProveedor.Size = new Size(774, 581);
            grpProveedor.TabIndex = 1;
            grpProveedor.TabStop = false;
            grpProveedor.Text = "Proveedor";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Location = new Point(38, 27);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(677, 25);
            lblSub.TabIndex = 14;
            lblSub.Text = "Editando Proveedor (Haga doble click sobre el provedor para editarlo)";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ControlDarkDark;
            btnConfirmar.Font = new Font("Segoe UI", 12F);
            btnConfirmar.Location = new Point(282, 519);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(251, 53);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // cbEstadoPro
            // 
            cbEstadoPro.FormattingEnabled = true;
            cbEstadoPro.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbEstadoPro.Location = new Point(42, 437);
            cbEstadoPro.Margin = new Padding(3, 4, 3, 4);
            cbEstadoPro.Name = "cbEstadoPro";
            cbEstadoPro.Size = new Size(175, 33);
            cbEstadoPro.TabIndex = 11;
            // 
            // txtTelefonoPro
            // 
            txtTelefonoPro.Location = new Point(42, 313);
            txtTelefonoPro.Margin = new Padding(3, 4, 3, 4);
            txtTelefonoPro.Name = "txtTelefonoPro";
            txtTelefonoPro.Size = new Size(175, 30);
            txtTelefonoPro.TabIndex = 10;
            // 
            // txtCorreoPro
            // 
            txtCorreoPro.Location = new Point(42, 203);
            txtCorreoPro.Margin = new Padding(3, 4, 3, 4);
            txtCorreoPro.Name = "txtCorreoPro";
            txtCorreoPro.Size = new Size(175, 30);
            txtCorreoPro.TabIndex = 8;
            // 
            // txtNombrePro
            // 
            txtNombrePro.Location = new Point(42, 92);
            txtNombrePro.Margin = new Padding(3, 4, 3, 4);
            txtNombrePro.Name = "txtNombrePro";
            txtNombrePro.Size = new Size(175, 30);
            txtNombrePro.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(38, 405);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(42, 281);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 4;
            label5.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(42, 171);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 3;
            label4.Text = "Correo Electrónico";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(42, 60);
            label1.Name = "label1";
            label1.Size = new Size(225, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre del proveedor";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(cbxEliminar);
            panel1.Controls.Add(cbxEditar);
            panel1.Controls.Add(cbxAñadir);
            panel1.Location = new Point(1074, 19);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(113, 192);
            panel1.TabIndex = 15;
            // 
            // cbxEliminar
            // 
            cbxEliminar.AutoSize = true;
            cbxEliminar.Location = new Point(14, 120);
            cbxEliminar.Margin = new Padding(3, 4, 3, 4);
            cbxEliminar.Name = "cbxEliminar";
            cbxEliminar.Size = new Size(85, 24);
            cbxEliminar.TabIndex = 14;
            cbxEliminar.Text = "Eliminar";
            cbxEliminar.UseVisualStyleBackColor = true;
            // 
            // cbxEditar
            // 
            cbxEditar.AutoSize = true;
            cbxEditar.Location = new Point(14, 71);
            cbxEditar.Margin = new Padding(3, 4, 3, 4);
            cbxEditar.Name = "cbxEditar";
            cbxEditar.Size = new Size(70, 24);
            cbxEditar.TabIndex = 13;
            cbxEditar.Text = "Editar";
            cbxEditar.UseVisualStyleBackColor = true;
            // 
            // cbxAñadir
            // 
            cbxAñadir.AutoSize = true;
            cbxAñadir.Location = new Point(14, 25);
            cbxAñadir.Margin = new Padding(3, 4, 3, 4);
            cbxAñadir.Name = "cbxAñadir";
            cbxAñadir.Size = new Size(75, 24);
            cbxAñadir.TabIndex = 3;
            cbxAñadir.Text = "Añadir";
            cbxAñadir.UseVisualStyleBackColor = true;
            // 
            // dgvProveedores
            // 
            dgvProveedores.Anchor = AnchorStyles.Right;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(416, 10);
            dgvProveedores.Margin = new Padding(3, 4, 3, 4);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(613, 211);
            dgvProveedores.TabIndex = 3;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            // 
            // frmProovedoresAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 820);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProovedoresAdmin";
            Text = "frmProovedoresAdmin";
            Load += frmProovedoresAdmin_Load;
            tableLayoutPanel1.ResumeLayout(false);
            grpProveedor.ResumeLayout(false);
            grpProveedor.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpProveedor;

        // TU VERSIÓN CONSERVADA
        private Button btnConfirmar;
        private ComboBox cbEstadoPro;
        private TextBox txtTelefonoPro;
        private TextBox txtCorreoPro;
        private TextBox txtNombrePro;

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private DataGridView dgvProveedores;
        private CheckBox cbxEliminar;
        private CheckBox cbxEditar;
        private CheckBox cbxAñadir;
        private Panel panel1;
        private Label lblSub;
    }
}
