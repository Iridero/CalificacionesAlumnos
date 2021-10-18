
namespace CalificacionesAlumnos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgAlumnos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenTeorico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenPractico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAlumnos
            // 
            this.dtgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.ExamenTeorico,
            this.ExamenPractico,
            this.Participaciones,
            this.Promedio});
            this.dtgAlumnos.Location = new System.Drawing.Point(24, 25);
            this.dtgAlumnos.Name = "dtgAlumnos";
            this.dtgAlumnos.RowTemplate.Height = 25;
            this.dtgAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlumnos.Size = new System.Drawing.Size(764, 182);
            this.dtgAlumnos.TabIndex = 0;
            this.dtgAlumnos.DoubleClick += new System.EventHandler(this.dtgAlumnos_DoubleClick);
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // ExamenTeorico
            // 
            this.ExamenTeorico.DataPropertyName = "ExamenTeorico";
            this.ExamenTeorico.HeaderText = "Examen teórico";
            this.ExamenTeorico.Name = "ExamenTeorico";
            // 
            // ExamenPractico
            // 
            this.ExamenPractico.DataPropertyName = "ExamenPractico";
            this.ExamenPractico.HeaderText = "Examen Práctico";
            this.ExamenPractico.Name = "ExamenPractico";
            // 
            // Participaciones
            // 
            this.Participaciones.DataPropertyName = "Participaciones";
            this.Participaciones.HeaderText = "Participaciones";
            this.Participaciones.Name = "Participaciones";
            // 
            // Promedio
            // 
            this.Promedio.DataPropertyName = "Promedio";
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenTeorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenPractico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
    }
}

