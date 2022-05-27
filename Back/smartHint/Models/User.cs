
using System.ComponentModel.DataAnnotations;


namespace smartHint.Models;

public class User
{
    public int UserId { get; set; }

    [Required]
    [StringLength(150, MinimumLength = 2)]
    public string NomeRazaoSocial { get; set; }

    [Required]
    [StringLength(150)]
    public string Email { get; set; }

    [Required]
    public long Telefone { get; set; }

    public DateTime DataCadastro { get; set; }

    [StringLength(18, MinimumLength = 8)]
    public string Password { get; set; }

    [Required]
    public int TipoPessoa { get; set; }

    public bool Bloqueado { get; set; }

    public Juridico? Juridico { get; set; }
    public Fisica? Fisica { get; set; }
    public Loja Loja { get; set; }
}
