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
    public partial class formMenu : Form
    {
        //variables 
        private static int Amen = 0;
        private static string Total;
        private static int IdEmpleado;
        private static string Nombre, Permiso;
        public static formMenu instance = null;

        //Conexiones
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-89F36QFK\TBD_CSR;Initial Catalog = Cafeteria;Integrated Security=True");
        SPConexionDataContext db = new SPConexionDataContext();


        public formMenu(int idEmpleado, string nombre, string permiso)
        {
            InitializeComponent();
            instance = this;
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Permiso = permiso;

        }

        /// <summary>
        /// Muestra los datos del ticket en el Datagridview del formulario
        /// </summary>
        public void cargarDatos()
        {
            valorUltimoTicket();
            valorTotalTicket();
            var Stlist = db.mostrarTicketDos(Amen);
            dgvMostrarTicket.DataSource = Stlist;
            txtTotal.Text = Total;

        }




        //Valor de ticket
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


        public void valorTotalTicket()
        {
            try
            {
                con.Open();
                SqlCommand cme = new SqlCommand("SELECT SUM((ArticuloTicket.Cantidad * Producto.precioVenta)) as [Total] FROM ArticuloTicket INNER JOIN Producto ON Producto.idProducto = ArticuloTicket.idProducto where ArticuloTicket.idTicket = (SELECT TOP 1 MAX(idTicket) FROM  Ticket) ", con);
                SqlDataAdapter sdb = new SqlDataAdapter(cme);
                DataTable df = new DataTable();
                sdb.Fill(df);
                Total = df.Rows[0][0].ToString();
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form Gorditas = new Gorditas(IdEmpleado, Nombre, Permiso);
            Gorditas.Show();
        }


        private void formMenu_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Amen = 0;
            timer1.Start();
            
            cargarDatos();
            
        }

        private void txtMontoEntregado_TextChanged(object sender, EventArgs e)
        {
            int ejem = 0;

            if (int.TryParse(txtMontoEntregado.Text, out ejem))
            {
                txtMonto.Text = txtMontoEntregado.Text;
                txtCambio.Text = Convert.ToString(decimal.Parse(txtMonto.Text) - decimal.Parse(txtTotal.Text));
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarDatos();
        }


    

        private void crearTicket()
        {
            crearTicket ticket = new crearTicket();
            productos p = new productos();
            ticket.empresa = "GordiTec";
            ticket.direccion = "Col. El Tecnologico 53 27800 " +
                                 " San Pedro Coah.";
            ticket.telefono = "8722959671";
            ticket.logotipo = pictureBox1.Image;
            ticket.total = Convert.ToDouble(txtTotal.Text);
            ticket.montoEntregado = Convert.ToDouble(txtMonto.Text);
            ticket.cambio = Convert.ToDouble(txtCambio.Text);
            for (int i = 0; i < dgvMostrarTicket.Rows.Count; i++)
            {
                p = new productos();
                p.numeroTicket = Convert.ToInt32(dgvMostrarTicket.Rows[i].Cells[0].Value);
                p.producto = Convert.ToString(dgvMostrarTicket.Rows[i].Cells[1].Value);
                p.guiso = Convert.ToString(dgvMostrarTicket.Rows[i].Cells[2].Value);
                p.cantidad = Convert.ToInt32(dgvMostrarTicket.Rows[i].Cells[3].Value);
                p.precio = Convert.ToDouble(dgvMostrarTicket.Rows[i].Cells[4].Value);
                ticket.listaProducto.Add(p);
                ticket.imprimir(ticket);
            }
        }

    

        private void btnPagar_Click(object sender, EventArgs e)
        {
            

            var ps = db.mostrarTicketTres(decimal.Parse(txtTotal.Text), decimal.Parse(txtMonto.Text), decimal.Parse(txtCambio.Text), Amen);
            cargarDatos();
            crearTicket();
            
        }



        // Animacion y color para el boton gorditas
        private void pbGorditas_MouseHover(object sender, EventArgs e)
        {
            pbGorditas.Size = new Size(115, 99);
        }
        private void pbGorditas_MouseLeave(object sender, EventArgs e)
        {
            pbGorditas.Size = new Size(100, 84);
        }


        //Eventos del boton papitas
        private void pbPapitas_Click(object sender, EventArgs e)
        {

        }
        private void pbPapitas_MouseHover(object sender, EventArgs e)
        {
            pbPapitas.Size = new Size(115, 99);
        }
        private void pbPapitas_MouseLeave(object sender, EventArgs e)
        {
            pbPapitas.Size = new Size(100, 84);
        }

  

        //Eventos del boton refrescos
        private void pbRefrescos_Click(object sender, EventArgs e)
        {
            
        }
        private void pbRefrescos_MouseHover(object sender, EventArgs e)
        {
            pbRefrescos.Size = new Size(115, 99);
        }
        private void pbRefrescos_MouseLeave(object sender, EventArgs e)
        {
            pbRefrescos.Size = new Size(100, 84);
        }



        //Eventos del boton galletas
        private void pbGalletas_Click(object sender, EventArgs e)
        {

        }
        private void pbGalletas_MouseHover(object sender, EventArgs e)
        {
            pbGalletas.Size = new Size(115, 99);
        }
        private void pbGalletas_MouseLeave(object sender, EventArgs e)
        {
            pbGalletas.Size = new Size(100, 84);
        }



        //Eventos del boton desayunos
        private void pbDesayunos_Click(object sender, EventArgs e)
        {

        }
        private void pbDesayunos_MouseHover(object sender, EventArgs e)
        {
            pbDesayunos.Size = new Size(115, 99);
        }
        private void pbDesayunos_MouseLeave(object sender, EventArgs e)
        {
            pbDesayunos.Size = new Size(100, 84);
        }


        //Eventos del boton dulces
        private void pbDulces_Click(object sender, EventArgs e)
        {

        }
        private void pbDulces_MouseHover(object sender, EventArgs e)
        {
            pbDulces.Size = new Size(115, 99);
        }



        private void txtMontoEntregado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                formMenu mostrar = new formMenu(IdEmpleado, Nombre, Permiso);
                var ps = db.mostrarTicketTres(decimal.Parse(txtTotal.Text), decimal.Parse(txtMonto.Text), decimal.Parse(txtCambio.Text), Amen);
                cargarDatos();
                crearTicket();

                txtMonto.ResetText();
                txtCambio.ResetText();
                txtMontoEntregado.ResetText();
                txtTotal.ResetText();
                dgvMostrarTicket.DataSource = null;

            }
        }

        private void txtCambio_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbDulces_MouseLeave(object sender, EventArgs e)
        {
            pbDulces.Size = new Size(100, 84);
        }




    }
}
