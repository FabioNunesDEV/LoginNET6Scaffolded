using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjetoMVC.Areas.Identity.Data;

// Add profile data for application users by adding properties to the UsuarioModel class
[Table("Usuario")]
public class UsuarioModel : IdentityUser
{
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho máximo do campo {0} é de {1} caracteres")]
    public string Nome { get; set; }

    [MaxLength(15, ErrorMessage = "O tamanho máximo do campo {0} é de {1} caracteres")]
    public string Telefone { get; set; }     
}

