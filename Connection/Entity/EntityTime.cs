using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Connection.Entity
{
    [Table("usuario")]
    public class Usuario
    {
        [Column("id")]
        public int Id {get; set; } 

        [Column("nome")]
        public string nome {get; set; } = string.Empty;

        [Column("email")]
        public string email {get; set; }  = string.Empty;

    }
}







