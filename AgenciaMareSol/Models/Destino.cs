using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaMareSol.Models
{
    public class Destino
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string Estado { get; set; }

        [Required]
        [StringLength(8)]
        public double Preco { get; set; }
    }
}
