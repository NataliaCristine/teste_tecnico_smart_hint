namespace smartHint.Controllers;

public class ClientDTO
{
    public string nomeRazaoSocial { get; set; }
    public string email { get; set; }
    public int telefone { get; set; }
    public DateTime dataCadastro { get; set; }
    public string password { get; set; }
    public int tipoPessoa { get; set; }
    public bool bloqueado { get; set; }

    public int cpf { get; set; }
    public string? genero { get; set; }
    public DateTime dataNascimento { get; set; }

    public int cnpj { get; set; }
    public int inscricaoEstadual { get; set; }

}