using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaMareSol.Models
{
    public class Promocao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nome { get; set; }

        [Required]
        [StringLength(20)]
        public DateTime DataViagem { get; set; }

        public Destino Destino { get; set; }
        public int Destino_Id { get; set; }
    }
}
