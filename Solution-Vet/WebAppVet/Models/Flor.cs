using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Flor 
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int IdEspecie { get; set; }
        public IList<Especie> Especies { get; set; }
    }

    [MetadataType(typeof(FlorMetadata))]
    public partial class Flor
    {
        public class FlorMetadata
        {
            [Key, Column(Order = 0)]
            public int Codigo { get; set; }
            [StringLength(100)]
            public String Nombre { get; set; }
            [Key, ForeignKey("Especies"), Column(Order = 1)]
            public int IdEspecie { get; set; }
            //[StringLength(10)]
            //public int Precio { get; set; }

        }

    }
}