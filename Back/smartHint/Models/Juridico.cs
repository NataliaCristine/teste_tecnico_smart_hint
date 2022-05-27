
using System.ComponentModel.DataAnnotations;

namespace smartHint.Models;

public class Juridico
{
    public long JuridicoId { get; set; }


    [Required]
    public long Cnpj { get; set; }
    // [RegularExpression()]


    public long InscricaoEstadual { get; set; }
}
