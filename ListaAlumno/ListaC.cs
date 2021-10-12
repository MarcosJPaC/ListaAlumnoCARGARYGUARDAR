using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAlumno
{
    class ListaC
    {
        private NodoC head;

        public NodoC Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaC()
        {
            head = null;
        }
        public void AgregarC(NodoC n)
        {
            if (head == null)
            {
                head = n;
                return;
            }
            if (n.Numero < head.Numero)
            {
                n.SiguienteCal = head;
                head = n;
                return;
            }
            NodoC h = head;
            while (h.SiguienteCal != null)
            {
                if (n.Numero < h.SiguienteCal.Numero)
                {
                    break;
                }
                h = h.SiguienteCal;
            }
            n.SiguienteCal = h.SiguienteCal;
            h.SiguienteCal = n;
        }
        public void MostrarC(ListView caja)
        {
            NodoC h = head;
            caja.Items.Clear();
            while (h != null)
            {
                ListViewItem lista = new ListViewItem(h.Numero.ToString());
                lista.SubItems.Add(h.Materia);
                lista.SubItems.Add(h.Calificacion);
                caja.Items.Add(lista);
                h = h.SiguienteCal;
            }
        }
        public void EliminarC(int d)
        {
            if (head == null)
            {
                return;
            }
            if (head.Numero == d)
            {
                head = head.SiguienteCal;
                return;
            }
            NodoC h = Head;
            while (h.SiguienteCal != null)
            {
                if (h.SiguienteCal.Numero == d)
                {
                    break;
                }
                h = h.SiguienteCal;
            }
            if (h.SiguienteCal != null)
            {
                h.SiguienteCal = h.SiguienteCal.SiguienteCal;
            }
        }
    }
}
