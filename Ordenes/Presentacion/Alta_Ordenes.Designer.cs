namespace Ordenes
{
    partial class Alta_Ordenes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtp_fecha = new DateTimePicker();
            label1 = new Label();
            txt_responsable = new TextBox();
            label2 = new Label();
            cbo_material = new ComboBox();
            nud_cantidad = new NumericUpDown();
            btn_agregar = new Button();
            dgv_ordenes = new DataGridView();
            CodMaterial = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewButtonColumn();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ordenes).BeginInit();
            SuspendLayout();
            // 
            // dtp_fecha
            // 
            dtp_fecha.Format = DateTimePickerFormat.Short;
            dtp_fecha.Location = new Point(104, 18);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(105, 23);
            dtp_fecha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 24);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha";
            // 
            // txt_responsable
            // 
            txt_responsable.Location = new Point(104, 54);
            txt_responsable.Name = "txt_responsable";
            txt_responsable.Size = new Size(296, 23);
            txt_responsable.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 57);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Responsable";
            // 
            // cbo_material
            // 
            cbo_material.FormattingEnabled = true;
            cbo_material.Location = new Point(12, 96);
            cbo_material.Name = "cbo_material";
            cbo_material.Size = new Size(197, 23);
            cbo_material.TabIndex = 4;
            // 
            // nud_cantidad
            // 
            nud_cantidad.Location = new Point(225, 97);
            nud_cantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_cantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_cantidad.Name = "nud_cantidad";
            nud_cantidad.Size = new Size(175, 23);
            nud_cantidad.TabIndex = 5;
            nud_cantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(423, 97);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(111, 23);
            btn_agregar.TabIndex = 6;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // dgv_ordenes
            // 
            dgv_ordenes.AllowUserToAddRows = false;
            dgv_ordenes.AllowUserToDeleteRows = false;
            dgv_ordenes.AllowUserToResizeColumns = false;
            dgv_ordenes.AllowUserToResizeRows = false;
            dgv_ordenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ordenes.Columns.AddRange(new DataGridViewColumn[] { CodMaterial, Material, Stock, Cantidad, Acciones });
            dgv_ordenes.Location = new Point(12, 140);
            dgv_ordenes.Name = "dgv_ordenes";
            dgv_ordenes.RowTemplate.Height = 25;
            dgv_ordenes.Size = new Size(522, 150);
            dgv_ordenes.TabIndex = 7;
            dgv_ordenes.CellContentClick += dgv_ordenes_CellContentClick;
            // 
            // CodMaterial
            // 
            CodMaterial.HeaderText = "CodMaterial";
            CodMaterial.Name = "CodMaterial";
            CodMaterial.Visible = false;
            // 
            // Material
            // 
            Material.HeaderText = "Material";
            Material.Name = "Material";
            Material.Width = 220;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.Width = 80;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 80;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.Name = "Acciones";
            Acciones.Width = 80;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(125, 320);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(111, 23);
            btn_aceptar.TabIndex = 8;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(260, 320);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(111, 23);
            btn_cancelar.TabIndex = 9;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // Alta_Ordenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 353);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(dgv_ordenes);
            Controls.Add(btn_agregar);
            Controls.Add(nud_cantidad);
            Controls.Add(cbo_material);
            Controls.Add(label2);
            Controls.Add(txt_responsable);
            Controls.Add(label1);
            Controls.Add(dtp_fecha);
            Name = "Alta_Ordenes";
            Text = "Registrar Orden Retiro";
            Load += Alta_Ordenes_Load;
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ordenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_fecha;
        private Label label1;
        private TextBox txt_responsable;
        private Label label2;
        private ComboBox cbo_material;
        private NumericUpDown nud_cantidad;
        private Button btn_agregar;
        private DataGridView dgv_ordenes;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private DataGridViewTextBoxColumn CodMaterial;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewButtonColumn Acciones;
    }
}