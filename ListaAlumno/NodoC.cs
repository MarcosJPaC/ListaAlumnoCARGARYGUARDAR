using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlumno
{
    class NodoC
    {
        private int numero;
        private string materia;
        private double calificacion;
        private NodoC siguiente;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public double Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        public NodoC Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoC()
        {
            numero = 0;
            calificacion = 0;
            materia = "";
            siguiente = null;
        }
        public NodoC(int num, string mat, double cal)
        {
            numero = num;
            materia = mat;
            calificacion = cal;
            siguiente = null;
        }
        public override string ToString()
        {
            return materia + " - " + calificacion;
        }
    }
}
