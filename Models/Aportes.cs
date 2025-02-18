using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Angelix_Vasquez_P1_Ap1.Models;

public class Aportes
{
    [Key]

    public int AporteId { get; set; }

    [Required(ErrorMessage = "El Campo es obligatorio.")]
    public string? Persona {  get; set; }

    public DateTime Fecha { get; set; }

    [Required(ErrorMessage = "El Campo es obligatorio.")]
    public int Monto { get; set; }

    [Required(ErrorMessage = "El Campo es obligatorio.")]
    [RegularExpression(@"^[A-Z0-9\d{2}]+$", ErrorMessage = "Solo se permiten Numero")]

    public string? Observacion { get; set; }




}
