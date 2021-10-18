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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Alumno> clase = new List<Alumno>();
        private void Form1_Load(object sender, EventArgs e)
        {
            clase.Add(new Alumno()
            {
                Nombre = "Pablo",
                ExamenTeorico = 100,
                ExamenPractico=100,
                Participaciones=100
            });
            clase.Add(new Alumno()
            {
                Nombre = "Tyrone",
                ExamenTeorico = 80,
                ExamenPractico = 90,
                Participaciones = 100
            });

            ActualizarDatos();
        }
        private void ActualizarDatos()
        {
            dtgAlumnos.DataSource = null;
            dtgAlumnos.DataSource = clase;
        }

        private void dtgAlumnos_DoubleClick(object sender, EventArgs e)
        {
            Alumno alumno = (Alumno)dtgAlumnos.CurrentRow.DataBoundItem;
            FrmDatosAlumno f = new FrmDatosAlumno();
            f.MiAlumno = alumno;
            f.ShowDialog();
        }
    }
}
