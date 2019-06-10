using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Telefono { get; set; }
        public String Email { get; set; }
    }
    [MetadataType(typeof(ClienteMetadata))]
    public partial class Cliente
    {
        public class ClienteMetadata
        {
            [Key]
            public int IdCliente { get; set; }
            [StringLength(100)]
            public String Nombre { get; set; }
            [StringLength(100)]
            public String Apellido { get; set; }
            [StringLength(100)]
            public String Email { get; set; }
            //[StringLength(12)]
            //public int Telefono { get; set; }
        }

    }

}