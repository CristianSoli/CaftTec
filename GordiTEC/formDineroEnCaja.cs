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
    public partial class formDineroEnCaja : Form
    {
        private int idEmpleado;

        SPConexionDataContext db = new SPConexionDataContext();
        public formDineroEnCaja(int Caja)
        {
            InitializeComponent();
            idEmpleado = Caja;

        }

        private void btnCajaAceptar_Click(object sender, EventArgs e)
        {
            var ps = db.insertarCaja(decimal.Parse(txtCajaDinero.Text), idEmpleado);
            this.Close();

        }

        private void btnCajaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
