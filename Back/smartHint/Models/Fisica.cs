
using System.ComponentModel.DataAnnotations;
namespace smartHint.Models;

public class Fisica
{
    public long FisicaId { get; set; }


    [Required]
    public long Cpf { get; set; }


    [Required]
    public string Genero { get; set; }

    [Required]
    public DateTime DataNascimento { get; set; }
}
