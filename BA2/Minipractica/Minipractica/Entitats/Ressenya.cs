using System.ComponentModel.DataAnnotations;

namespace Minipractica.Entitats;

public class Ressenya
{
    [Key]
    public int IdRessenya { get; set; }
    [Required]
    public int LlocId { get; set; }
    [Required]
    public int UsuariId { get; set; }
    [Range(0,5)]
    public int Neteja { get; set; }
    [Range(0,5)]
    public int Olor { get; set; }
    [Range(0,5)]
    public int Privacitat { get; set; }
    [StringLength(500)]
    public string Comentari { get; set; }
    
    public string Data { get; set; }
    
    
    
}