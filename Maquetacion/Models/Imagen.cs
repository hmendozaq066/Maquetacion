using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Maquetacion.Models
{
    public class Imagen
    {
        [Key]
        public int Imagen_id { get; set; }
        [Required]
        public string Nombre { get; set;}
        [Required]
        public string Comentarios { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
