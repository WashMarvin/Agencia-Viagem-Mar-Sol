using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaMareSol.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required]
        [StringLength(15)]
        public string CPF { get; set; }

        [Required]
        [StringLength(20)]
        public string Email { get; set; }
    }
}
