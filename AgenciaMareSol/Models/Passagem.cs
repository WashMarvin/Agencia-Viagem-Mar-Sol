using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaMareSol.Models
{
    public class Passagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Numero { get; set; }

        public Contato Contato { get; set; }
        public int Contato_Id { get; set; }

        public Promocao Promocao { get; set; }
        public int Promocao_Id { get; set; }
    }
}
