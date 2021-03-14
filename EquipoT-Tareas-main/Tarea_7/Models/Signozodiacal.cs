using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_7.Models
{
    public partial class Signozodiacal
    {
        public Signozodiacal()
        {
            Pacientes = new HashSet<Pacientes>();
        }

        public int Id { get; set; }
        public string Signo { get; set; }

        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
