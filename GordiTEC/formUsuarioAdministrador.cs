using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GordiTEC
{
    public partial class formUsuarioAdministrador : Form
    {
        public formUsuarioAdministrador()
        {
            InitializeComponent();
        }

        //Cadenas de conexion
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-89F36QFK\TBD_CSR;Initial Catalog = Cafeteria;Integrated Security=True");
        SPConexionDataContext db = new SPConexionDataContext();
        private int numeroEmpleados;

        public void valorUltimoUsuario()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from Empleado", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                numeroEmpleados = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void cargarDatos()
        {
            var Stlist = db.mostrarEmpleados();
            dgvEmpleados.DataSource = Stlist;
        }

        private void formUsuarioAdministrador_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var ps = db.insertarEmpleados(txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtUsuario.Text, txtContraseña.Text, "01");
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            valorUltimoUsuario();
            if (numeroEmpleados > 1)
            {
                var ps = db.eliminarEmpleados(Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value.ToString()));
                cargarDatos();
            }
            else
            {
                MessageBox.Show("No puedes borra todos los usuarios");
            }
        }

        private void txtCajero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
