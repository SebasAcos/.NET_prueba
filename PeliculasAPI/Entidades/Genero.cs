using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
<<<<<<< Updated upstream
        public string Nombre { get; set; }

=======
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [StringLength(maximumLength: 50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        
>>>>>>> Stashed changes
    }
}
