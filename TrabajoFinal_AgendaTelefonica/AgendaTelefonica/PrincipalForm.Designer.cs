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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dgContactos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbMetodoBuscar = new System.Windows.Forms.Label();
            this.cmbMetodoBuscar = new System.Windows.Forms.ComboBox();
            this.tbCampoBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.label3);
            this.gbMenu.Controls.Add(this.label1);
            this.gbMenu.Controls.Add(this.lbTitulo);
            this.gbMenu.Controls.Add(this.dgContactos);
            this.gbMenu.Controls.Add(this.btnSalir);
            this.gbMenu.Controls.Add(this.btnBorrar);
            this.gbMenu.Controls.Add(this.btnEditar);
            this.gbMenu.Controls.Add(this.btnAgregar);
            this.gbMenu.Controls.Add(this.btnBuscar);
            this.gbMenu.Controls.Add(this.lbMetodoBuscar);
            this.gbMenu.Controls.Add(this.cmbMetodoBuscar);
            this.gbMenu.Controls.Add(this.tbCampoBuscar);
            this.gbMenu.Location = new System.Drawing.Point(7, 1);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(462, 433);
            this.gbMenu.TabIndex = 13;
            this.gbMenu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "DE CONTACTOS";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(7, 10);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(98, 34);
            this.lbTitulo.TabIndex = 22;
            this.lbTitulo.Text = "AGENDA";
            // 
            // dgContactos
            // 
            this.dgContactos.AllowUserToAddRows = false;
            this.dgContactos.AllowUserToDeleteRows = false;
            this.dgContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContactos.Location = new System.Drawing.Point(126, 130);
            this.dgContactos.Name = "dgContactos";
            this.dgContactos.ReadOnly = true;
            this.dgContactos.RowHeadersVisible = false;
            this.dgContactos.Size = new System.Drawing.Size(320, 277);
            this.dgContactos.TabIndex = 21;
            this.dgContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContactos_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(6, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(6, 211);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(104, 23);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(6, 182);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 23);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(371, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbMetodoBuscar
            // 
            this.lbMetodoBuscar.AutoSize = true;
            this.lbMetodoBuscar.Location = new System.Drawing.Point(278, 23);
            this.lbMetodoBuscar.Name = "lbMetodoBuscar";
            this.lbMetodoBuscar.Size = new System.Drawing.Size(118, 13);
            this.lbMetodoBuscar.TabIndex = 15;
            this.lbMetodoBuscar.Text = "Metodo de Busqueda : ";
            // 
            // cmbMetodoBuscar
            // 
            this.cmbMetodoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoBuscar.FormattingEnabled = true;
            this.cmbMetodoBuscar.Items.AddRange(new object[] {
            "ID",
            "Nombre"});
            this.cmbMetodoBuscar.Location = new System.Drawing.Point(281, 39);
            this.cmbMetodoBuscar.Name = "cmbMetodoBuscar";
            this.cmbMetodoBuscar.Size = new System.Drawing.Size(115, 21);
            this.cmbMetodoBuscar.TabIndex = 14;
            // 
            // tbCampoBuscar
            // 
            this.tbCampoBuscar.Location = new System.Drawing.Point(281, 66);
            this.tbCampoBuscar.Name = "tbCampoBuscar";
            this.tbCampoBuscar.Size = new System.Drawing.Size(165, 20);
            this.tbCampoBuscar.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "© Anthony Reyes - Franddy Thomas - Robinson Remigio";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 441);
            this.Controls.Add(this.gbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Telefónica";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitulo;
        public System.Windows.Forms.DataGridView dgContactos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbMetodoBuscar;
        private System.Windows.Forms.ComboBox cmbMetodoBuscar;
        private System.Windows.Forms.TextBox tbCampoBuscar;
        public System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Label label3;
    }
}

