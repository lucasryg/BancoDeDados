using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Domains
{
    //Define o nome da tabela
    [Table("TipoUsuario")]
    public class TipoUsuario
    {
        //Defube que será a chave primaria
        [Key]
        //Define o auto-incremento
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoUsuario { get; set; }

        [Column(TypeName = "VARCHAR(225)")]
        [Required(ErrorMessage = "O título di tupo de usuario é obrigatório")]
        public string Titulo{ get; set; }
    }
}
