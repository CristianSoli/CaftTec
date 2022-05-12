using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GordiTEC
{
    class crearTicket : productos
    {
        public string empresa { get; set; }
        public string direccion { get; set; }

        public string telefono { get; set; }


        public Image logotipo { get; set; }

        public List<productos> listaProducto = new List<productos>();

        private PrintDocument doc = new PrintDocument();
        private PrintPreviewDialog vista = new PrintPreviewDialog();

        public void imprimir(crearTicket p)
        {
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(imprimeticket);
            vista.Document = doc;
            //vista.Show();
            doc.Print();
        }

        public void imprimeticket(object sender, PrintPageEventArgs e)
        {

            int posX, posY;
            Font fuente = new Font("consola", 5, FontStyle.Bold);
            try
            {
                posX = 10;
                posY = 10;
                e.Graphics.DrawImage(logotipo, 15, 20, 100, 100);
                posY += 110;
                e.Graphics.DrawString(empresa, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(direccion, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(telefono, fuente, Brushes.Black, posX, posY);
                posY += 50;

                fuente = new Font("consola", 5, FontStyle.Bold);
                e.Graphics.DrawString("----------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 15;
                e.Graphics.DrawString("PRODUCTO              CANT.   PRECIO", fuente, Brushes.Black, posX, posY);
                posY += 15;
                e.Graphics.DrawString("----------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 25;
                fuente = new Font("consola", 5, FontStyle.Bold);
                for (int i = 0; i < listaProducto.Count - 1; i++)
                {

                    e.Graphics.DrawString(Convert.ToString(listaProducto[i].producto) + " " + Convert.ToString(listaProducto[i].guiso) + "          " + Convert.ToString(listaProducto[i].cantidad) +" pzs.  "  + "$ "+ Convert.ToString(listaProducto[i].precio), fuente, Brushes.Black, posX, posY);
                    posY += 15;
                    // e.Graphics.DrawString(Convert.ToString(listaProducto[i].cantidad) + espaciar(listaProducto[i].cantidad.ToString().Length, 18) + Convert.ToString(listaProducto[i].precio) + (listaProducto[i].precio.ToString().Length, 24) , fuente, Brushes.Black, posX, posY);
                    // posY += 25;
                    //e.Graphics.DrawString("-----------------------------------------------------", fuente, Brushes.Black, posX, posY);



                }


                posY += 20;
                e.Graphics.DrawString("                                  TOTAL :  " + total, fuente, Brushes.Black, posX, posY);
                posY += 5;

                posY += 5;
                e.Graphics.DrawString("                                  MONTO :  " + montoEntregado, fuente, Brushes.Black, posX, posY);
                posY += 5;

                posY += 5;
                e.Graphics.DrawString("                                  CAMBIO :  " + cambio, fuente, Brushes.Black, posX, posY);
                posY += 45;
                

                fuente = new Font("consola", 5, FontStyle.Bold);
                e.Graphics.DrawString("GRACIAS POR SU COMPRA ... ", fuente, Brushes.Black, posX, posY);
                posY += 25;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        public string espaciar(int tamaño, int valor)
        {
            string espacio = "";
            int subvalor = 0;
            subvalor = valor - tamaño;

            for (int i = 0; i < subvalor; i++)
            {
                espacio = espacio + " ";
            }

            return espacio;

        }

    }
}
