using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Minipractica.Entitats;

public class Zona
{
    [Key]
    public int ZonaId { get; set; }
    [StringLength(80)]
    public string Nom { get; set; }
    
    public TipusZona Tipus { get; set; }
    
    public int? IdZonaPare { get; set; }
    
    // Poner signo de interrogación después del tipo de valor indica que puede ser NULL
}
