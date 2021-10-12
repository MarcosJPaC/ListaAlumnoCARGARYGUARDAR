using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlumno
{
    class Nodo
    {
        private int numero;
        private string matricula;
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private string carrera;
        private Nodo siguiente;
        private ListaMateria listaMateria;

        public ListaMateria ListaMateria
        {
            get { return listaMateria; }
            set { listaMateria = value; }
        }


        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string ApellidoP
        {
            get { return apellidoP; }
            set { apellidoP = value; }
        }


        public string ApellidoM
        {
            get { return apellidoM; }
            set { apellidoM = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodo()
        {
            numero = 0;
            matricula = "";
            nombre = "";
            apellidoP = "";
            apellidoM = "";
            carrera = "";
            listaMateria = new ListaMateria();
            siguiente = null;
        }
        public Nodo(int num, string mat, string nom, string app, string apm, string car)
        {
            numero = num;
            matricula = mat;
            nombre = nom;
            apellidoP = app;
            apellidoM = apm;
            carrera = car;
            listaMateria = new ListaMateria();
            siguiente = null;
        }
        public override string ToString()
        {
            if (listaMateria == null)
            {
                return numero + " - " + matricula + " - " + nombre + " " + apellidoP + " " + apellidoM + " - " + carrera;

            }
            return numero + " - " + matricula + " - " + nombre + " - " + apellidoP + " - " + apellidoM + " - " + carrera + " - " + listaMateria.ToString() + " - ";
        }
    }
}
