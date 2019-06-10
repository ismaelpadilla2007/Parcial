using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Especie
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
    }
    [MetadataType(typeof(EspecieMetadata))]
    public partial class Especie
    {
        public class EspecieMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(100)]
            public String Nombre { get; set; }
        }

    }

}