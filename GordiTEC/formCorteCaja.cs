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
    public partial class formCorteCaja : Form
    {
        SPConexionDataContext db = new SPConexionDataContext();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-89F36QFK\TBD_CSR;Initial Catalog = Cafeteria;Integrated Security=True");

        private int IdEmpleado = 0;
        private decimal num1;
        private decimal num3 = 0;
        private string num2;
        private decimal suma;


        public formCorteCaja(int idEmpleado)
        {
            InitializeComponent();
            IdEmpleado = idEmpleado;
        }


        //Numero 1
        public void valorNumeroUno()
        {

            for (int i = 0; i < dgvMostrarCorte.Rows.Count; i++)
            {
                num1 = Convert.ToDecimal(dgvMostrarCorte.Rows[i].Cells[4].Value);
                num3 = num1 + num3;
           
            }











            /*
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(Ticket.Total) - SUM(Ticket.cambio) FROM Ticket WHERE fecha between DATEADD(HH, -48, GETDATE()) and GETDATE()", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                num1 = dt.Rows[0][0].ToString();
                if (num1 == "")
                    {
                        num1 = "0";
                    }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            */
        }



        //Numero 2
        public void valorNumeroDos()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT top 1 MAX(idDineroCaja), Movimientos.Monto FROM Movimientos group by idDineroCaja, Monto order by idDineroCaja desc", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                num2 = dt.Rows[0][1].ToString();

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

        //SUMA
        public void valorSuma()
        {
            suma = num3 + decimal.Parse(num2);
        }
















        void cargarDatos()
        {
            var Stlist = db.mostrarCorte(IdEmpleado, dtpFechaCorte.Value);
            dgvMostrarCorte.DataSource = Stlist;
        }

        private void formCorteCaja_Load(object sender, EventArgs e)
        {


            
            
        }

        private void dtpFechaCorte_ValueChanged(object sender, EventArgs e)
        {
            cargarDatos();
            
        }

        private void btnCorteAceptar_Click(object sender, EventArgs e)

        {
            valorNumeroUno();
            valorNumeroDos();
            valorSuma();
            textBox1.Text = suma.ToString();
        }
    }
}
