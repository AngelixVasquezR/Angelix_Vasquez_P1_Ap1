using System.ComponentModel.DataAnnotations;

namespace Angelix_Vasquez_P1_Ap1.Models;

public class Modelo
{
    [Key]
    public int ModeloId { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string? Nombre { get; set; }


}
