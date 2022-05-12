
namespace GordiTEC
{
    partial class fornIngesarDinero
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
            this.txtIngresarUsuario = new System.Windows.Forms.TextBox();
            this.txtIngresarDinero = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIngresarUsuario
            // 
            this.txtIngresarUsuario.Location = new System.Drawing.Point(12, 76);
            this.txtIngresarUsuario.Name = "txtIngresarUsuario";
            this.txtIngresarUsuario.Size = new System.Drawing.Size(252, 20);
            this.txtIngresarUsuario.TabIndex = 0;
            // 
            // txtIngresarDinero
            // 
            this.txtIngresarDinero.Location = new System.Drawing.Point(12, 39);
            this.txtIngresarDinero.Name = "txtIngresarDinero";
            this.txtIngresarDinero.Size = new System.Drawing.Size(252, 20);
            this.txtIngresarDinero.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(139, 114);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(99, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // fornIngesarDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 149);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtIngresarDinero);
            this.Controls.Add(this.txtIngresarUsuario);
            this.Name = "fornIngesarDinero";
            this.Text = "fornIngesarDinero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngresarUsuario;
        private System.Windows.Forms.TextBox txtIngresarDinero;
        private System.Windows.Forms.Button btnIngresar;
    }
}