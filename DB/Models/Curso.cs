using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DB.Models
{
    // : IValidatableObject
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CursoID { get; set; }
        public string NombreCurso { get; set; }
        public string Descripcion { get; set; }
        //[JsonIgnore]
        //public virtual ICollection<Inscripcion> ?Inscripciones { get; set; }
    }
}