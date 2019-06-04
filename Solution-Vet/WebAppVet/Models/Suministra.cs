using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Suministra : IEntity
    {
        public int Id { get; set; }
        public int CodigoPieza { get; set; }
        public int IdProveedor { get; set; }
        public int Precio { get; set; }
    }
    
}