using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_7.Models
{
    public partial class Pacientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int? VacunaId { get; set; }
        public int? ProvinciaId { get; set; }
        public int? SignoId { get; set; }
        public DateTime? FechaPrimeraVacuna { get; set; }
        public DateTime? FechaSegundaVacuna { get; set; }

        public virtual Provincias Provincia { get; set; }
        public virtual Signozodiacal Signo { get; set; }
        public virtual Vacunas Vacuna { get; set; }
    }
}
