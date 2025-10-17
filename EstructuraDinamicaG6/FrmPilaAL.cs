using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstructuraDinamicaG6
{
    public partial class FrmPilaAL : Form
    {
        public FrmPilaAL()
        {
            InitializeComponent();
        }
        Stack<int> pila = new Stack<int>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(tbEdad.Text);
            pila.Push(edad);
            Mostrar();
        }
        private void Mostrar()
        {
            string msn = "";
            foreach (int edad in pila)
            {
                msn += edad + "|";
            }
            lblEdades.Text = msn;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                pila.Pop();
                Mostrar();
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }
    }
}