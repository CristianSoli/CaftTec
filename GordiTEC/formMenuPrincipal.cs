using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GordiTEC
{
    public partial class formMenuPrincipal : Form
    {
        SPConexionDataContext db = new SPConexionDataContext();
        private static int miVariable;
        private static string Nombre, Permiso;

        public formMenuPrincipal(int idEmpleado, string nombre, string permiso)
        {
            InitializeComponent();
            lblNombreEmpleado.Text = nombre;
            label1.Text = Convert.ToString(idEmpleado);
            miVariable = idEmpleado;
            Nombre = nombre;
            Permiso = permiso;
            string a = label1.Text;
            if (permiso == "11")
            {
                lblMatriculaEmpleado.Text = "Admin";

            }
            if (permiso == "00")
            {
                lblMatriculaEmpleado.Text = "Cajero";
            }

        }

    






        private void btnIngresarDineroACaja_Click(object sender, EventArgs e)
        {
            new formDineroEnCaja(miVariable).Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new formCorteCaja(miVariable).Show();
        }

        private void lbCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCambiarUsuario_Click(object sender, EventArgs e)
        {

        }





        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            formIniciarSesion mostrar = new formIniciarSesion();
            mostrar.Show();
            this.Close();
        }

 
       
        public void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();


        }




        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            formMenu.instance.timer1.Stop();
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void BTNventas_Click(object sender, EventArgs e)
        {
            formMenu frm = new formMenu(miVariable, Nombre, Permiso);
            AbrirFormEnPanel(frm);
            var ps = db.insertarTicketUno(miVariable);
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formCorteCaja(miVariable));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formIniciarSesion mostrar = new formIniciarSesion();
            mostrar.Show();
            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formDineroEnCaja(miVariable));
        }



        private void formMenuPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formInicio());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formUsuarioAdministrador());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formInicio());
        }

















    }
}
