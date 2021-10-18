using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalificacionesAlumnos
{
    public partial class FrmDatosAlumno : Form
    {
        public Alumno MiAlumno { get; set; }
        public FrmDatosAlumno()
        {
            InitializeComponent();
        }

        private void FrmDatosAlumno_Load(object sender, EventArgs e)
        {
            txtNombre.Text = MiAlumno.Nombre;
            txtTeorico.Text = MiAlumno.ExamenTeorico.ToString();
            txtPractico.Text = MiAlumno.ExamenPractico.ToString();
            txtParticipaciones.Text = MiAlumno.Participaciones.ToString();
            txtPromedio.Text = MiAlumno.Promedio.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
