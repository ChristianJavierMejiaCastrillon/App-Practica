namespace winform_app
{
    partial class FormAltaPokemon
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
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonAcpetar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelDebilidad = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxDebilidad = new System.Windows.Forms.ComboBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.pictureBoxUrlPokemon = new System.Windows.Forms.PictureBox();
            this.buttonAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrlPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(54, 44);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(47, 13);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Numero:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(54, 70);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(35, 122);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(107, 37);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumero.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(107, 63);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(107, 115);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(121, 20);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // buttonAcpetar
            // 
            this.buttonAcpetar.Location = new System.Drawing.Point(57, 229);
            this.buttonAcpetar.Name = "buttonAcpetar";
            this.buttonAcpetar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcpetar.TabIndex = 6;
            this.buttonAcpetar.Text = "ACEPTAR";
            this.buttonAcpetar.UseVisualStyleBackColor = true;
            this.buttonAcpetar.Click += new System.EventHandler(this.buttonAcpetar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(211, 229);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(70, 149);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 8;
            this.labelTipo.Text = "Tipo:";
            // 
            // labelDebilidad
            // 
            this.labelDebilidad.AutoSize = true;
            this.labelDebilidad.Location = new System.Drawing.Point(47, 176);
            this.labelDebilidad.Name = "labelDebilidad";
            this.labelDebilidad.Size = new System.Drawing.Size(54, 13);
            this.labelDebilidad.TabIndex = 9;
            this.labelDebilidad.Text = "Debilidad:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(107, 141);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 4;
            // 
            // comboBoxDebilidad
            // 
            this.comboBoxDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDebilidad.FormattingEnabled = true;
            this.comboBoxDebilidad.Location = new System.Drawing.Point(107, 168);
            this.comboBoxDebilidad.Name = "comboBoxDebilidad";
            this.comboBoxDebilidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDebilidad.TabIndex = 5;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(40, 95);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(61, 13);
            this.labelUrl.TabIndex = 12;
            this.labelUrl.Text = "Url Imagen:";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(107, 88);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(121, 20);
            this.textBoxUrl.TabIndex = 2;
            this.textBoxUrl.Leave += new System.EventHandler(this.textBoxUrl_Leave);
            // 
            // pictureBoxUrlPokemon
            // 
            this.pictureBoxUrlPokemon.Location = new System.Drawing.Point(353, 37);
            this.pictureBoxUrlPokemon.Name = "pictureBoxUrlPokemon";
            this.pictureBoxUrlPokemon.Size = new System.Drawing.Size(251, 215);
            this.pictureBoxUrlPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUrlPokemon.TabIndex = 14;
            this.pictureBoxUrlPokemon.TabStop = false;
            // 
            // buttonAgregarImagen
            // 
            this.buttonAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarImagen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAgregarImagen.Location = new System.Drawing.Point(234, 88);
            this.buttonAgregarImagen.Name = "buttonAgregarImagen";
            this.buttonAgregarImagen.Size = new System.Drawing.Size(27, 20);
            this.buttonAgregarImagen.TabIndex = 15;
            this.buttonAgregarImagen.Text = "+";
            this.buttonAgregarImagen.UseVisualStyleBackColor = true;
            this.buttonAgregarImagen.Click += new System.EventHandler(this.buttonAgregarImagen_Click);
            // 
            // FormAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 304);
            this.Controls.Add(this.buttonAgregarImagen);
            this.Controls.Add(this.pictureBoxUrlPokemon);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.comboBoxDebilidad);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelDebilidad);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAcpetar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNumero);
            this.Name = "FormAltaPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pokemon";
            this.Load += new System.EventHandler(this.FormAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrlPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonAcpetar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelDebilidad;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxDebilidad;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.PictureBox pictureBoxUrlPokemon;
        private System.Windows.Forms.Button buttonAgregarImagen;
    }
}