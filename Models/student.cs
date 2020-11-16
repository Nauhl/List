using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List.Models
{
    public class student
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public string Turno { get; set; }
        public string Grado { get; set; }
        public string Grupo { get; set; }

        public student()
        {

        }
    }
}
