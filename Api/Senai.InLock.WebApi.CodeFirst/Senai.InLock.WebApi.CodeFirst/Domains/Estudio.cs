using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Domains
{
    [Table("Estudio")]
    public class Estudio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEstudio { get; set; }

        [Column(TypeName ="varchar(255)")]
        [Required(ErrorMessage = "O nome do estudio é necessario")]
        public string NomeEstudio { get; set; }

        public List<Jogo> Jogos { get; set; }

    }
}
