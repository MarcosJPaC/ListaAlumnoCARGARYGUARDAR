using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAlumno
{
    public partial class Form1 : Form
    {
        Lista miLista;
        public Form1()
        {
            InitializeComponent();
            miLista = new Lista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                string matricula = txtMatricula.Text;
                string nombre = txtNombre.Text;
                string apellidoP = txtApellidoP.Text;
                string apellidoM = txtApellidoM.Text;
                string carrera = txtCarrera.Text;
                Nodo n = new Nodo(numero, matricula, nombre, apellidoP, apellidoM, carrera);
                miLista.Agregar(n);
                txtMatricula.Clear();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtCarrera.Clear();
                txtNumero.Focus();
                miLista.Mostrar(LstAlumno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                miLista.Eliminar(numero);
                txtMatricula.Clear();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtCarrera.Clear();
                txtNumero.Focus();
                miLista.Mostrar(LstAlumno);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                Nodo b = new Nodo();
                if (miLista.Buscar(numero, ref b))
                {
                    txtMatricula.Text = b.Matricula;
                    txtNombre.Text = b.Nombre;
                    txtApellidoP.Text = b.ApellidoP;
                    txtApellidoM.Text = b.ApellidoM;
                    txtCarrera.Text = b.Carrera;
                }
                else
                {
                    txtNumero.Clear();
                    txtMatricula.Clear();
                    txtNombre.Clear();
                    txtApellidoP.Clear();
                    txtApellidoM.Clear();
                    txtCarrera.Clear();
                    MessageBox.Show("NO Existe ");
                }
                txtNumero.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                miLista.Modificar(numero, txtMatricula.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtCarrera.Text, null);
                txtNumero.Clear();
                txtMatricula.Clear();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtCarrera.Clear();
                txtNumero.Focus();
                miLista.Mostrar(LstAlumno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
        private void txtAgregarCalificacion_Click(object sender, EventArgs e)
        {
            try
            {
            int numero = int.Parse(txtNumeroCal.Text);
            string materia = txtMateria.Text;
            double calificacion = double.Parse(txtCalificacion.Text);
            NodoC n = new NodoC(numero, materia, calificacion);
            miLista.AgregarMateria(n, numero);
            txtNumeroCal.Clear();
            txtMateria.Clear(); 
            txtCalificacion.Clear();
            txtNumeroCal.Focus();
            miLista.Mostrar(LstAlumno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }


        }

        private void btnBuscarCal_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            miLista.Guardar("Lista");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miLista.Cargar("Lista");
        }
    }
}
