
namespace ADO_BANCO
{
    partial class Clientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.textBoxNombreBuscado = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
          
            this.labelIDCLIENTE = new System.Windows.Forms.Label();
            this.labelNOMBRE = new System.Windows.Forms.Label();
            this.labelAPELLIDOS = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNOMBRE = new System.Windows.Forms.TextBox();
            this.textBoxAPELLIDOS = new System.Windows.Forms.TextBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
          
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
          
            // 
            // aDODataSet
            // 
          
            // 
            // textBoxNombreBuscado
            // 
            this.textBoxNombreBuscado.Location = new System.Drawing.Point(166, 26);
            this.textBoxNombreBuscado.Name = "textBoxNombreBuscado";
            this.textBoxNombreBuscado.Size = new System.Drawing.Size(235, 22);
            this.textBoxNombreBuscado.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCLIENTEDataGridViewTextBoxColumn,
            this.aPELLIDOSDataGridViewTextBoxColumn,
            this.nOMBRESDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(369, 293);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDCLIENTEDataGridViewTextBoxColumn
            // 
            this.iDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "IDCLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.HeaderText = "IDCLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCLIENTEDataGridViewTextBoxColumn.Name = "iDCLIENTEDataGridViewTextBoxColumn";
            this.iDCLIENTEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aPELLIDOSDataGridViewTextBoxColumn
            // 
            this.aPELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS";
            this.aPELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS";
            this.aPELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aPELLIDOSDataGridViewTextBoxColumn.Name = "aPELLIDOSDataGridViewTextBoxColumn";
            this.aPELLIDOSDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOMBRESDataGridViewTextBoxColumn
            // 
            this.nOMBRESDataGridViewTextBoxColumn.DataPropertyName = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.HeaderText = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMBRESDataGridViewTextBoxColumn.Name = "nOMBRESDataGridViewTextBoxColumn";
            this.nOMBRESDataGridViewTextBoxColumn.Width = 125;
            // 
            // cLIENTETableAdapter
            // 
        
            // 
            // labelIDCLIENTE
            // 
            this.labelIDCLIENTE.AutoSize = true;
            this.labelIDCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDCLIENTE.Location = new System.Drawing.Point(465, 134);
            this.labelIDCLIENTE.Name = "labelIDCLIENTE";
            this.labelIDCLIENTE.Size = new System.Drawing.Size(115, 25);
            this.labelIDCLIENTE.TabIndex = 3;
            this.labelIDCLIENTE.Text = "IDCLIENTE";
            // 
            // labelNOMBRE
            // 
            this.labelNOMBRE.AutoSize = true;
            this.labelNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOMBRE.Location = new System.Drawing.Point(482, 198);
            this.labelNOMBRE.Name = "labelNOMBRE";
            this.labelNOMBRE.Size = new System.Drawing.Size(98, 25);
            this.labelNOMBRE.TabIndex = 4;
            this.labelNOMBRE.Text = "NOMBRE";
            // 
            // labelAPELLIDOS
            // 
            this.labelAPELLIDOS.AutoSize = true;
            this.labelAPELLIDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAPELLIDOS.Location = new System.Drawing.Point(465, 274);
            this.labelAPELLIDOS.Name = "labelAPELLIDOS";
            this.labelAPELLIDOS.Size = new System.Drawing.Size(123, 25);
            this.labelAPELLIDOS.TabIndex = 5;
            this.labelAPELLIDOS.Text = "APELLIDOS";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(609, 133);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(170, 30);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxNOMBRE
            // 
            this.textBoxNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNOMBRE.Location = new System.Drawing.Point(609, 193);
            this.textBoxNOMBRE.Name = "textBoxNOMBRE";
            this.textBoxNOMBRE.Size = new System.Drawing.Size(170, 30);
            this.textBoxNOMBRE.TabIndex = 7;
            // 
            // textBoxAPELLIDOS
            // 
            this.textBoxAPELLIDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAPELLIDOS.Location = new System.Drawing.Point(609, 269);
            this.textBoxAPELLIDOS.Name = "textBoxAPELLIDOS";
            this.textBoxAPELLIDOS.Size = new System.Drawing.Size(170, 30);
            this.textBoxAPELLIDOS.TabIndex = 8;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.Color.Red;
            this.btSalir.Location = new System.Drawing.Point(609, 318);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(152, 43);
            this.btSalir.TabIndex = 9;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(32, 390);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(134, 40);
            this.btAgregar.TabIndex = 10;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(172, 390);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(134, 40);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(312, 390);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(134, 40);
            this.btModificar.TabIndex = 12;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // comboBoxID
            // 
            this.comboBoxID.DataSource = this.cLIENTEBindingSource;
            this.comboBoxID.DisplayMember = "IDCLIENTE";
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(42, 26);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(106, 24);
            this.comboBoxID.TabIndex = 13;
            this.comboBoxID.ValueMember = "IDCLIENTE";
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.textBoxAPELLIDOS);
            this.Controls.Add(this.textBoxNOMBRE);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelAPELLIDOS);
            this.Controls.Add(this.labelNOMBRE);
            this.Controls.Add(this.labelIDCLIENTE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxNombreBuscado);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
        
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombreBuscado;
        private System.Windows.Forms.DataGridView dataGridView1;
  
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
   
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelIDCLIENTE;
        private System.Windows.Forms.Label labelNOMBRE;
        private System.Windows.Forms.Label labelAPELLIDOS;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNOMBRE;
        private System.Windows.Forms.TextBox textBoxAPELLIDOS;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.ComboBox comboBoxID;
    }
}

