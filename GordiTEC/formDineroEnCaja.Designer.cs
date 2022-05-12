
namespace GordiTEC
{
    partial class formDineroEnCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCajaDinero = new System.Windows.Forms.TextBox();
            this.btnCajaAceptar = new System.Windows.Forms.Button();
            this.btnCajaCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCajaDinero
            // 
            this.txtCajaDinero.Location = new System.Drawing.Point(50, 89);
            this.txtCajaDinero.Name = "txtCajaDinero";
            this.txtCajaDinero.Size = new System.Drawing.Size(307, 20);
            this.txtCajaDinero.TabIndex = 0;
            // 
            // btnCajaAceptar
            // 
            this.btnCajaAceptar.Location = new System.Drawing.Point(196, 143);
            this.btnCajaAceptar.Name = "btnCajaAceptar";
            this.btnCajaAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnCajaAceptar.TabIndex = 1;
            this.btnCajaAceptar.Text = "Aceptar";
            this.btnCajaAceptar.UseVisualStyleBackColor = true;
            this.btnCajaAceptar.Click += new System.EventHandler(this.btnCajaAceptar_Click);
            // 
            // btnCajaCancelar
            // 
            this.btnCajaCancelar.Location = new System.Drawing.Point(282, 143);
            this.btnCajaCancelar.Name = "btnCajaCancelar";
            this.btnCajaCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCajaCancelar.TabIndex = 2;
            this.btnCajaCancelar.Text = "Cancelar";
            this.btnCajaCancelar.UseVisualStyleBackColor = true;
            this.btnCajaCancelar.Click += new System.EventHandler(this.btnCajaCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCajaDinero);
            this.panel1.Controls.Add(this.btnCajaCancelar);
            this.panel1.Controls.Add(this.btnCajaAceptar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 201);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dinero en caja";
            // 
            // formDineroEnCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(437, 225);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDineroEnCaja";
            this.Text = "Ingresar dinero";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCajaDinero;
        private System.Windows.Forms.Button btnCajaAceptar;
        private System.Windows.Forms.Button btnCajaCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}