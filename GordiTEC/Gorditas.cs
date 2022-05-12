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
    public partial class Gorditas : Form
    {
        private static int IdEmpleado;
        private static string Nombre, Permiso;

        public Gorditas(int idEmpleado, string nombre, string permiso)
        {
            InitializeComponent();
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Permiso = permiso;
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-89F36QFK\TBD_CSR;Initial Catalog = Cafeteria;Integrated Security=True");
        SPConexionDataContext db = new SPConexionDataContext();

        void cargarDatos()
        {
            var Stlist = db.mostrarGorditasCompleto();
            dataGridView1.DataSource = Stlist;


        }




        private void Gorditas_Load(object sender, EventArgs e)
        {
            valorUltimoTicket();
            cargarDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private static int Amen;
        public void valorUltimoTicket()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 MAX(idTicket) FROM  Ticket ", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Amen = int.Parse(dt.Rows[0][0].ToString());

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

        private void btnInsertarGordita_Click(object sender, EventArgs e)
        {
            var ps = db.insertarArticulosTicket(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),Convert.ToInt32(Amen), Convert.ToInt32(numericUpDown1.Value));
            cargarDatos();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            formMenu F = new formMenu(IdEmpleado, Nombre, Permiso);
            this.Close();
        }
    }
}
