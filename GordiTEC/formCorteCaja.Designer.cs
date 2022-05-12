
namespace GordiTEC
{
    partial class formCorteCaja
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
            this.dgvMostrarCorte = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCorteAceptar = new System.Windows.Forms.Button();
            this.btnCorteCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCorte = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarCorte)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrarCorte
            // 
            this.dgvMostrarCorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarCorte.Location = new System.Drawing.Point(89, 61);
            this.dgvMostrarCorte.Name = "dgvMostrarCorte";
            this.dgvMostrarCorte.Size = new System.Drawing.Size(535, 160);
            this.dgvMostrarCorte.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnCorteAceptar
            // 
            this.btnCorteAceptar.Location = new System.Drawing.Point(468, 276);
            this.btnCorteAceptar.Name = "btnCorteAceptar";
            this.btnCorteAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnCorteAceptar.TabIndex = 2;
            this.btnCorteAceptar.Text = "Aceptar";
            this.btnCorteAceptar.UseVisualStyleBackColor = true;
            this.btnCorteAceptar.Click += new System.EventHandler(this.btnCorteAceptar_Click);
            // 
            // btnCorteCancelar
            // 
            this.btnCorteCancelar.Location = new System.Drawing.Point(549, 276);
            this.btnCorteCancelar.Name = "btnCorteCancelar";
            this.btnCorteCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCorteCancelar.TabIndex = 3;
            this.btnCorteCancelar.Text = "Cancelar";
            this.btnCorteCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dinero en caja";
            // 
            // dtpFechaCorte
            // 
            this.dtpFechaCorte.Location = new System.Drawing.Point(184, 250);
            this.dtpFechaCorte.Name = "dtpFechaCorte";
            this.dtpFechaCorte.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCorte.TabIndex = 5;
            this.dtpFechaCorte.ValueChanged += new System.EventHandler(this.dtpFechaCorte_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCorteAceptar);
            this.panel1.Controls.Add(this.dgvMostrarCorte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFechaCorte);
            this.panel1.Controls.Add(this.btnCorteCancelar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 315);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Corte";
            // 
            // formCorteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(727, 348);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCorteCaja";
            this.Text = "formCorteCaja";
            this.Load += new System.EventHandler(this.formCorteCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarCorte)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarCorte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCorteAceptar;
        private System.Windows.Forms.Button btnCorteCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCorte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}