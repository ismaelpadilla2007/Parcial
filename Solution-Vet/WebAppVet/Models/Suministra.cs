using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Suministra 
    {
        public int CodigoPieza { get; set; }
        public int IdProveedor { get; set; }
        public int Precio { get; set; }

        public IList<Proveedor> Proveedores { get; set; }
        public IList<Pieza> Piezas { get; set; }
    }

    [MetadataType(typeof(SuministraMetadata))]
    public partial class Suministra
    {
        public class SuministraMetadata
        {
            [Key, ForeignKey("Piezas"), Column(Order = 0) ]
            public int CodigoPieza { get; set; }
            [Key, ForeignKey("Proveedores"), Column(Order = 1)]
            public int IdProveedor { get; set; }

        }
    }

}