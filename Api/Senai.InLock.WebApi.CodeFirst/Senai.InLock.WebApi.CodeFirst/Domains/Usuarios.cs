using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Domains 
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Required(ErrorMessage ="O e-mail do usuário é obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 5, ErrorMessage ="A senha deve conter no minímo 5 dígitos e no maxímo 30 dígito")]
        public string Senha { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public int IdTipoUsuario{ get; set; }

        TipoUsuario tipoUsuario = new TipoUsuario();
    }
}
