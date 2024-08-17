namespace winform_app
{
    partial class FormPokemons
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
            this.dataGridViewPokemons = new System.Windows.Forms.DataGridView();
            this.pictureBoxPokemons = new System.Windows.Forms.PictureBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminarFisico = new System.Windows.Forms.Button();
            this.buttonEliminarLogica = new System.Windows.Forms.Button();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.buttonFiltro = new System.Windows.Forms.Button();
            this.labelCampo = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.labelFiltroAvanzado = new System.Windows.Forms.Label();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPokemons
            // 
            this.dataGridViewPokemons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPokemons.Location = new System.Drawing.Point(33, 40);
            this.dataGridViewPokemons.Name = "dataGridViewPokemons";
            this.dataGridViewPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPokemons.Size = new System.Drawing.Size(448, 268);
            this.dataGridViewPokemons.TabIndex = 0;
            this.dataGridViewPokemons.SelectionChanged += new System.EventHandler(this.dataGridViewPokemons_SelectionChanged);
            // 
            // pictureBoxPokemons
            // 
            this.pictureBoxPokemons.Location = new System.Drawing.Point(551, 40);
            this.pictureBoxPokemons.Name = "pictureBoxPokemons";
            this.pictureBoxPokemons.Size = new System.Drawing.Size(284, 268);
            this.pictureBoxPokemons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPokemons.TabIndex = 1;
            this.pictureBoxPokemons.TabStop = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(33, 308);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(128, 308);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 3;
            this.buttonModificar.Text = "MODIFICAR";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminarFisico
            // 
            this.buttonEliminarFisico.Location = new System.Drawing.Point(223, 308);
            this.buttonEliminarFisico.Name = "buttonEliminarFisico";
            this.buttonEliminarFisico.Size = new System.Drawing.Size(115, 23);
            this.buttonEliminarFisico.TabIndex = 4;
            this.buttonEliminarFisico.Text = "ELIMINAR FISICO";
            this.buttonEliminarFisico.UseVisualStyleBackColor = true;
            this.buttonEliminarFisico.Click += new System.EventHandler(this.buttonEliminarFisico_Click);
            // 
            // buttonEliminarLogica
            // 
            this.buttonEliminarLogica.Location = new System.Drawing.Point(357, 308);
            this.buttonEliminarLogica.Name = "buttonEliminarLogica";
            this.buttonEliminarLogica.Size = new System.Drawing.Size(121, 23);
            this.buttonEliminarLogica.TabIndex = 5;
            this.buttonEliminarLogica.Text = "ELIMINAR LOGICO";
            this.buttonEliminarLogica.UseVisualStyleBackColor = true;
            this.buttonEliminarLogica.Click += new System.EventHandler(this.buttonEliminarLogica_Click);
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(33, 13);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(51, 13);
            this.labelFiltro.TabIndex = 6;
            this.labelFiltro.Text = "FILTRO: ";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(86, 10);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltro.TabIndex = 7;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            // 
            // buttonFiltro
            // 
            this.buttonFiltro.Location = new System.Drawing.Point(594, 363);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltro.TabIndex = 8;
            this.buttonFiltro.Text = "BUSCAR";
            this.buttonFiltro.UseVisualStyleBackColor = true;
            this.buttonFiltro.Click += new System.EventHandler(this.buttonFiltro_Click);
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(33, 370);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(48, 13);
            this.labelCampo.TabIndex = 9;
            this.labelCampo.Text = "CAMPO:";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(89, 366);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampo.TabIndex = 10;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(218, 370);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(61, 13);
            this.labelCriterio.TabIndex = 11;
            this.labelCriterio.Text = "CRITERIO:";
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(287, 366);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCriterio.TabIndex = 12;
            // 
            // labelFiltroAvanzado
            // 
            this.labelFiltroAvanzado.AutoSize = true;
            this.labelFiltroAvanzado.Location = new System.Drawing.Point(416, 370);
            this.labelFiltroAvanzado.Name = "labelFiltroAvanzado";
            this.labelFiltroAvanzado.Size = new System.Drawing.Size(48, 13);
            this.labelFiltroAvanzado.TabIndex = 13;
            this.labelFiltroAvanzado.Text = "FILTRO:";
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(472, 366);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltroAvanzado.TabIndex = 14;
            // 
            // FormPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 472);
            this.Controls.Add(this.textBoxFiltroAvanzado);
            this.Controls.Add(this.labelFiltroAvanzado);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.buttonFiltro);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.buttonEliminarLogica);
            this.Controls.Add(this.buttonEliminarFisico);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBoxPokemons);
            this.Controls.Add(this.dataGridViewPokemons);
            this.Name = "FormPokemons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Pokemons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPokemons;
        private System.Windows.Forms.PictureBox pictureBoxPokemons;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminarFisico;
        private System.Windows.Forms.Button buttonEliminarLogica;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button buttonFiltro;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.Label labelFiltroAvanzado;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
    }
}

