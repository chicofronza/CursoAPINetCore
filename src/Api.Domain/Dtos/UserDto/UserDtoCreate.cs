using System.ComponentModel.DataAnnotations;

namespace src.Api.Domain.Dtos.UserDto
{
    public class UserDtoCreate
    {
        [Required(ErrorMessage = "Nome é o campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email é um campo obrigatório para Login")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        [StringLength(100, ErrorMessage = "Email deve ter no maximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
