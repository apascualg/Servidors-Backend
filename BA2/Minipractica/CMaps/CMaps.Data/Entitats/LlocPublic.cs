using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Minipractica.Entitats;

public class LlocPublic
{
    [Key]
    public int LlocId { get; set; }
    
    [StringLength(80, MinimumLength = 3)]
    public string Nom { get; set; }
    
    [StringLength(200)]
    public string Adreca { get; set;  }
    
    public TipusZona Tipus { get; set; }
    
    public bool EsGratuit { get; set; }
    
    [Range(0, 99.99)]
    public float Preu { get; set; }
    
    public bool Accesible { get; set; }
    
    public bool TeCanviador { get; set; }
    
    public bool Unisex { get; set; }
    
    public string Horari { get; set; }
    
    [DefaultValue(Estat.ACTIU)]
    public Estat Estat { get; set; }
    
    public string DataAlta { get; set; }
    
    public int ZonaId { get; set; }
    
    public int IdCreador { get; set; }
}