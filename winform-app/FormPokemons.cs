using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class FormPokemons : Form
    {
        private List<Pokemon> listaPokemons;
        public FormPokemons()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            comboBoxCampo.Items.Add("Numero");
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Descripcion");
        }

        private void dataGridViewPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dataGridViewPokemons.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemons = negocio.listar();
                dataGridViewPokemons.DataSource = listaPokemons;
                ocultarColumnas();
                cargarImagen(listaPokemons[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dataGridViewPokemons.Columns["UrlImagen"].Visible = false;
            dataGridViewPokemons.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxPokemons.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxPokemons.Load("https://img.freepik.com/premium-vector/modern-flat-icon-landscape_203633-11062.jpg");
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormAltaPokemon alta = new FormAltaPokemon();
            alta.ShowDialog();
            cargar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dataGridViewPokemons.CurrentRow.DataBoundItem;

            FormAltaPokemon modificar = new FormAltaPokemon(seleccionado);
            modificar.ShowDialog();
            cargar();

        }

        private void buttonEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void buttonEliminarLogica_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dataGridViewPokemons.CurrentRow.DataBoundItem;

                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminarfisico(seleccionado.Id);

                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private bool validarFiltro()
        {
            if (comboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un CAMPO para poder realizar la busqueda");
                return true;
            }
            else if (comboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un CRITERIO para poder realizar la busqueda");
                return true;
            }

            if (comboBoxCampo.SelectedItem.ToString() == "Numero")
            {
                if(string.IsNullOrEmpty(textBoxFiltroAvanzado.Text))
                {
                    MessageBox.Show("Por favor diligencie el cuadro 'FILTRO' para realizar la busqueda");
                    return true;
                }
                if(!(soloNumeros(textBoxFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Por favor ingrese solo NUMEROS para poder realizar la busqueda");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena) 
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void buttonFiltro_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if(validarFiltro())
                    return;

                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAvanzado.Text;

                dataGridViewPokemons.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = textBoxFiltro.Text;
            if (filtro.Length >= 3)
            {
                listaFiltrada = listaPokemons.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaPokemons;
            }
            dataGridViewPokemons.DataSource = null;
            dataGridViewPokemons.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();

            if (opcion == "Numero")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Comienza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
        }
    }
}
