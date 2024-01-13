using backend_ptdp.Obras;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_ptdp.Models
{
    [Table("obras")]
    public class Obra
    {
        [Key]
        public int id { get; set; }
        public TipoObra tipo { get; set; }
        public String titulo { get; set; }
        public String genero { get; set; }
        public int duracion { get; set; }
        public String equipo { get; set; }
        public String fotoPerfil { get; set; }
        public String pais { get; set; }
        public float calificacion { get; set; }
    }
}
