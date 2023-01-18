using LibTransportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónVehiculos
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void btnCamion_Click(object sender, EventArgs e)
        {
            Camión camion = new Camión("Mercedes-Benz", "1995", "ABC 123", 100.56);
            MessageBox.Show("Marca: " + camion.Marca + "\nModelo: " + camion.Modelo + "\nPatente: " + camion.Patente +
                "\nPeso Máximo: " + camion.PesoMaximo);
        }

        private void btnAutoElectrico_Click(object sender, EventArgs e)
        {
            AutoEléctrico autoEléctrico = new AutoEléctrico("Ford", "2020", "HGF 466", true);
            MessageBox.Show("Marca: " + autoEléctrico.Marca + "\nModelo: " + autoEléctrico.Modelo + "\nPatente: " + autoEléctrico.Patente + "\nBateria cargada: " + autoEléctrico.BateriaCargada);
        }

        private void btnQuitarRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque();
            Camión camion = new Camión("Mercedes-Benz", "1995", "ABC 123", 100.56);

            camion.remolque = remolque;
            camion.QuitarRemolque();

            if (camion.remolque == null)
            {
                MessageBox.Show("Se quitó el remolque");
            }

        }

        private void btn_acelerarCamion_Click(object sender, EventArgs e)
        {
            Camión camion = new Camión("Mercedes-Benz", "1995", "ABC 123", 100.56);

            MessageBox.Show(camion.Acelerar());
        }

        private void btnFrenarCamion_Click(object sender, EventArgs e)
        {
            Camión camion = new Camión("Mercedes-Benz", "1995", "ABC 123", 100.56);

            MessageBox.Show(camion.Frenar());
        }

        private void btnAcelerarElectrico_Click(object sender, EventArgs e)
        {
            AutoEléctrico autoEléctrico = new AutoEléctrico("Ford", "2020", "HGF 466", true);

            MessageBox.Show(autoEléctrico.Acelerar());
        }

        private void btnFrenarElectrico_Click(object sender, EventArgs e)
        {
            AutoEléctrico autoEléctrico = new AutoEléctrico("Ford", "2020", "HGF 466", true);

            MessageBox.Show(autoEléctrico.Frenar());
        }


    }
}
