using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAviones()
        {
            gridAviones.DataSource = AdmAvion.Listar();
        }

        private void btnInsertarAvion_Click(object sender, EventArgs e)
        {
            List<Avión> ListaAviones = new List <Avión>();
            LineaAerea lineaAerea = new LineaAerea("JetSmart", new DateTime (1995,05,23), ListaAviones);
            Avión avión = new Avión(250, "Avion comercial", lineaAerea);

            int filasAfectadas = AdmAvion.Insertar(avión);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Ok");
                MostrarAviones();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                int id = Convert.ToInt32(txtID.Text);
                Avión avión = AdmAvion.TraerUno(id);
                if (avión != null)
                {
                    avión.Denominación = "Avion Privado";
                    int filasAfectadas = AdmAvion.Modificar(avión);

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Ok");
                        MostrarAviones();
                    }
                }
            }

            else
            {
                MessageBox.Show("Debe ingresar un número ID.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                int id = Convert.ToInt32(txtID.Text);
                Avión avión = AdmAvion.TraerUno(id);
                if (avión != null)
                {
                    avión.IdAvion = id;
                    int filasAfectadas = AdmAvion.Eliminar(avión.IdAvion);

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Ok");
                        MostrarAviones();
                    }
                }
            }

            else
            {
                MessageBox.Show("Debe ingresar un número ID.");
            }
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                int id = Convert.ToInt32(txtID.Text);

                Avión avión = AdmAvion.TraerUno(id);
                MessageBox.Show(avión.Denominación);
            }

            else
            {
                MessageBox.Show("Debe ingresar un número ID.");
            }
        }
    }
}
