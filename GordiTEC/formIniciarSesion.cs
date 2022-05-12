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
    public partial class formIniciarSesion : Form
    {
        public formIniciarSesion()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-89F36QFK\TBD_CSR;Initial Catalog = Cafeteria;Integrated Security=True");
        SPConexionDataContext db = new SPConexionDataContext();




        public void loguear (string usuario, string contraseña)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT idEmpleado, Usuario, Permiso, (nombreEmpleado + ' '  + appEmpleado + ' ' + apmEmpleado) as Nombre FROM Empleado WHERE Usuario = @Usuario AND Contraseña = @Contraseña", con);
                cmd.Parameters.AddWithValue("Usuario", usuario);
                cmd.Parameters.AddWithValue("Contraseña", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                            
                    new formMenuPrincipal(int.Parse(dt.Rows[0][0].ToString()), dt.Rows[0][3].ToString(), dt.Rows[0][2].ToString()).Show();



                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
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

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            loguear(this.txtIniciarUsuario.Text, this.txtIniciarContraseña.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresarUsuario_Click(object sender, EventArgs e)
        {
            formUsuarios mostrar = new formUsuarios();
            this.Hide();
            mostrar.Show();

        }

        //new formMenuPrincipal(dt.Rows[0][6].ToString()).Show();    


    }


    /*
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            string respuestaCapturada = " ";
            db.iniciarSesion(txtIniciarUsuario.Text, txtIniciarContraseña.Text, ref respuestaCapturada);

            if (respuestaCapturada == "1")
            {
                MessageBox.Show("Datos correctos");
                this.Hide();
                loguear(this.txtIniciarUsuario.Text, this.txtIniciarContraseña.Text);
                
            }
            else if (respuestaCapturada == "0")
            {
                MessageBox.Show("Datos Incorrecto");
            }

            
    */


        
        
    
}
