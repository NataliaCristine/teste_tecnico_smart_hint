namespace smartHint.Models;

public class Loja
{

    public Loja()
    {
        Users = new List<User>();
    }
    public long LojaId { get; set; }
    public string Nome { get; set; }

    public List<User> Users { get; set; }

}