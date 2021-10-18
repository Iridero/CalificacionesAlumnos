
namespace CalificacionesAlumnos
{
    partial class FrmDatosAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTeorico = new System.Windows.Forms.TextBox();
            this.txtPractico = new System.Windows.Forms.TextBox();
            this.txtParticipaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Examen teórico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Examen práctico";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(299, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtTeorico
            // 
            this.txtTeorico.Location = new System.Drawing.Point(113, 35);
            this.txtTeorico.Name = "txtTeorico";
            this.txtTeorico.Size = new System.Drawing.Size(100, 23);
            this.txtTeorico.TabIndex = 4;
            // 
            // txtPractico
            // 
            this.txtPractico.Location = new System.Drawing.Point(113, 64);
            this.txtPractico.Name = "txtPractico";
            this.txtPractico.Size = new System.Drawing.Size(100, 23);
            this.txtPractico.TabIndex = 5;
            // 
            // txtParticipaciones
            // 
            this.txtParticipaciones.Location = new System.Drawing.Point(312, 35);
            this.txtParticipaciones.Name = "txtParticipaciones";
            this.txtParticipaciones.Size = new System.Drawing.Size(100, 23);
            this.txtParticipaciones.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Participaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Promedio";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(312, 64);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 23);
            this.txtPromedio.TabIndex = 9;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(312, 104);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmDatosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 139);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtParticipaciones);
            this.Controls.Add(this.txtPractico);
            this.Controls.Add(this.txtTeorico);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDatosAlumno";
            this.Text = "FrmDatosAlumno";
            this.Load += new System.EventHandler(this.FrmDatosAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTeorico;
        private System.Windows.Forms.TextBox txtPractico;
        private System.Windows.Forms.TextBox txtParticipaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Button btnCerrar;
    }
}