using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GordiTEC
{
    public partial class fornIngesarDinero : Form
    {
        public fornIngesarDinero()
        {
            InitializeComponent();
        }
        SPConexionDataContext db = new SPConexionDataContext();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
          //  formMenu mostrar = new formMenu();
            int temp = 0;

            try
            {
                if (int.TryParse(txtIngresarDinero.Text, out temp))
                {
                    var ps = db.insertarCaja(decimal.Parse(txtIngresarDinero.Text), int.Parse(txtIngresarUsuario.Text));
                    MessageBox.Show("Guardado Satisfactoriamente");
                   // mostrar.Show();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("La cantidad debe ser un valor numerico");
                }
            }

            catch
            {
                MessageBox.Show("Algo salio mal");
            }


        }
    }
}
