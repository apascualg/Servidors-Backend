using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Minipractica.Entitats;

    public class Usuari
    {
        [Key]
        public int IdUsuari { get; set; }
        
        [MinLength(3), StringLength(30, MinimumLength = 3)]
        // ¿Cómo hago que esto sea único?
        public string NomUsuari { get; set; }
        
        [EmailAddress, StringLength(100)]
        public string Email { get; set; }
        
        public string DataRegistre { get; set; }
        
        [DefaultValue(0)]
        public int Karma { get; set; }


        // Como es una relación 1-N, la parte del N tiene la <Castillo>.
        // Porque siempre apuntará a una misma entidad.
    }