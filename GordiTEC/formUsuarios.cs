using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GordiTEC
{
    public partial class formUsuarios : Form
    {
        //Cadenas de conexion
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-89F36QFK\TBD_CSR;Initial Catalog = Cafeteria;Integrated Security=True");
        SPConexionDataContext db = new SPConexionDataContext();
        private int numeroEmpleados;


        public formUsuarios()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var ps = db.insertarEmpleados(txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtUsuario.Text, txtContraseña.Text, "01");
            
        }

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







        private void formUsuarios_Load(object sender, EventArgs e)
        {
            
        }
    }
}
