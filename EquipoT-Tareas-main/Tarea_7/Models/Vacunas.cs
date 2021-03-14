using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_7.Models
{
    public partial class Vacunas
    {
        public Vacunas()
        {
            Pacientes = new HashSet<Pacientes>();
        }

        public int Id { get; set; }
        public string Marca { get; set; }
        public int? Cantidad { get; set; }

        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
