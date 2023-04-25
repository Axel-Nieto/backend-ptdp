﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_ptdp.Models
{
    [Table("usuarios")]
    public class Usuarios
    {
        [Key]
        public int id { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
