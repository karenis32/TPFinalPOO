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
            Camion camion = new Camion("Mercedes-Benz", "1995", "ABC 123", 100.56);
            MessageBox.Show(camion.ToString());

        }

        private void btnAutoElectrico_Click(object sender, EventArgs e)
        {
            AutoElectrico autoElectrico = new AutoElectrico("Ford", "2020", "HGF 466", true);
            MessageBox.Show(autoElectrico.ToString());
        }

        private void btnQuitarRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque();
            Camion camion = new Camion("Mercedes-Benz", "1995", "ABC 123", 100.56);

            camion.remolque = remolque;
            camion.QuitarRemolque();

            if (camion.remolque == null)
            {
                MessageBox.Show("Se quitó el remolque");
            }

        }

        private void btn_acelerarCamion_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion("Mercedes-Benz", "1995", "ABC 123", 100.56);

            MessageBox.Show(camion.Acelerar());
        }

        private void btnFrenarCamion_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion("Mercedes-Benz", "1995", "ABC 123", 100.56);

            MessageBox.Show(camion.Frenar());
        }

        private void btnAcelerarElectrico_Click(object sender, EventArgs e)
        {
            AutoElectrico autoEléctrico = new AutoElectrico("Ford", "2020", "HGF 466", true);

            MessageBox.Show(autoEléctrico.Acelerar());
        }

        private void btnFrenarElectrico_Click(object sender, EventArgs e)
        {
            AutoElectrico autoEléctrico = new AutoElectrico("Ford", "2020", "HGF 466", true);

            MessageBox.Show(autoEléctrico.Frenar());
        }


    }
}
