namespace AgendaTelefonica
{
    partial class PrincipalForm
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
            this.tbCampoBuscar = new System.Windows.Forms.TextBox();
            this.cmbMetodoBuscar = new System.Windows.Forms.ComboBox();
            this.lbMetodoBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgContactos = new System.Windows.Forms.DataGridView();
            this.lbUltimaFila = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCampoBuscar
            // 
            this.tbCampoBuscar.Location = new System.Drawing.Point(133, 65);
            this.tbCampoBuscar.Name = "tbCampoBuscar";
            this.tbCampoBuscar.Size = new System.Drawing.Size(165, 20);
            this.tbCampoBuscar.TabIndex = 1;
            // 
            // cmbMetodoBuscar
            // 
            this.cmbMetodoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoBuscar.FormattingEnabled = true;
            this.cmbMetodoBuscar.Items.AddRange(new object[] {
            "ID",
            "Nombre"});
            this.cmbMetodoBuscar.Location = new System.Drawing.Point(12, 64);
            this.cmbMetodoBuscar.Name = "cmbMetodoBuscar";
            this.cmbMetodoBuscar.Size = new System.Drawing.Size(115, 21);
            this.cmbMetodoBuscar.TabIndex = 3;
            // 
            // lbMetodoBuscar
            // 
            this.lbMetodoBuscar.AutoSize = true;
            this.lbMetodoBuscar.Location = new System.Drawing.Point(9, 48);
            this.lbMetodoBuscar.Name = "lbMetodoBuscar";
            this.lbMetodoBuscar.Size = new System.Drawing.Size(118, 13);
            this.lbMetodoBuscar.TabIndex = 4;
            this.lbMetodoBuscar.Text = "Metodo de Busqueda : ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(304, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(422, 109);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(422, 138);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(422, 226);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(422, 354);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgContactos
            // 
            this.dgContactos.AllowUserToAddRows = false;
            this.dgContactos.AllowUserToDeleteRows = false;
            this.dgContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContactos.Location = new System.Drawing.Point(12, 109);
            this.dgContactos.Name = "dgContactos";
            this.dgContactos.ReadOnly = true;
            this.dgContactos.RowHeadersVisible = false;
            this.dgContactos.Size = new System.Drawing.Size(307, 255);
            this.dgContactos.TabIndex = 10;
            // 
            // lbUltimaFila
            // 
            this.lbUltimaFila.AutoSize = true;
            this.lbUltimaFila.Location = new System.Drawing.Point(9, 367);
            this.lbUltimaFila.Name = "lbUltimaFila";
            this.lbUltimaFila.Size = new System.Drawing.Size(118, 13);
            this.lbUltimaFila.TabIndex = 11;
            this.lbUltimaFila.Text = "Metodo de Busqueda : ";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 389);
            this.Controls.Add(this.lbUltimaFila);
            this.Controls.Add(this.dgContactos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbMetodoBuscar);
            this.Controls.Add(this.cmbMetodoBuscar);
            this.Controls.Add(this.tbCampoBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Telefónica";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCampoBuscar;
        private System.Windows.Forms.ComboBox cmbMetodoBuscar;
        private System.Windows.Forms.Label lbMetodoBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.DataGridView dgContactos;
        private System.Windows.Forms.Label lbUltimaFila;
    }
}

