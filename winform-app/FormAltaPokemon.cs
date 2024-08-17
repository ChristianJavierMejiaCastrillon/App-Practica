using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Configuration;

namespace winform_app
{
    public partial class FormAltaPokemon : Form
    {
        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;
        public FormAltaPokemon()
        {
            InitializeComponent();
            Text = "Nuevo Pokemon";
        }
        public FormAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonAcpetar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if(pokemon == null) 
                    pokemon = new Pokemon();

                pokemon.Numero = int.Parse(textBoxNumero.Text);
                pokemon.Nombre = textBoxNombre.Text;
                pokemon.UrlImagen = textBoxUrl.Text;
                pokemon.Descripcion = textBoxDescripcion.Text;
                pokemon.Tipo = (Elemento)comboBoxTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)comboBoxDebilidad.SelectedItem;

                if(pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                else 
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");
                }

                //guardo la imagen si la levanto localmente:
                if(archivo != null && !(textBoxUrl.Text.ToLower().Contains("http")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Imagenes-cargadas"] + archivo.SafeFileName);
                    
                }
                else
                {
                    pokemon.UrlImagen = textBoxUrl.Text;    
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try
            {
                comboBoxTipo.DataSource = elementoNegocio.listar();
                comboBoxTipo.ValueMember = "Id";
                comboBoxTipo.DisplayMember = "Descripcion";

                comboBoxDebilidad.DataSource = elementoNegocio.listar();
                comboBoxDebilidad.ValueMember = "Id";
                comboBoxDebilidad.DisplayMember = "Descripcion";

                if(pokemon != null) 
                {
                    textBoxNumero.Text = pokemon.Numero.ToString();
                    textBoxNombre.Text = pokemon.Nombre;
                    textBoxDescripcion.Text = pokemon.Descripcion;
                    textBoxUrl.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    comboBoxTipo.SelectedValue = pokemon.Tipo.Id;
                    comboBoxDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxUrlPokemon.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxUrlPokemon.Load("https://img.freepik.com/premium-vector/modern-flat-icon-landscape_203633-11062.jpg");
            }
        }

        private void textBoxUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxUrl.Text);
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg; |png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                textBoxUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
