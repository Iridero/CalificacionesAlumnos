using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionesAlumnos
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public float ExamenTeorico { get; set; }
        public float ExamenPractico { get; set; }
        public float Participaciones { get; set; }
        public float Promedio
        {
            get { return ExamenPractico * 0.4f 
                        + ExamenTeorico * 0.4f 
                        + Participaciones * 0.2f; }
        }
    }
}
