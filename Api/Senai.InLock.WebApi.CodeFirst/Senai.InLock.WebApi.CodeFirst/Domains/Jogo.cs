using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Domains
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdJogo{ get; set; }

        [Column(TypeName = "varchar(255)")]
        [Required(ErrorMessage = "O nome do jogo é obrigatório!")]
        public string NomeJogo{ get; set; }
        
        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrção do jogo é obrigatória!")]
        public string  Descricao{ get; set; }

        [Column(TypeName = "DATE")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "A data de lançamento é obrigatória")]
        public DateTime DataDeLancamento{ get; set; }

        [Column("Preco", TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "É necessario informar o estúdio que produziu o jogo")]
        public int IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public Estudio estudio { get; set; } 
    }
}
