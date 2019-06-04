using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Proveedor : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    [MetadataType(typeof(ProveedorMetadata))]
    public partial class Room
    {
        public class ProveedorMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(100)]
            public String Nombre { get; set; }
        }

    }
}