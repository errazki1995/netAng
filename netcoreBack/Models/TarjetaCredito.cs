using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


using System.Linq;
using System.Threading.Tasks;

namespace netcoreBack.Models
{
    public class TarjetaCredito
    { 
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName="varchar(255)")]
        public string Titular { get; set; }
    
        public string NumeroTarjeta { get; set; }





    }
}
