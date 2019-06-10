using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Venta 
    {
        public int NroPedido { get; set; }
        public int CodFlores { get; set; }
        public int Cantidad { get; set; }

        public IList<Pedido> Pedidos { get; set; }
        public IList<Flor> Flores { get; set; }
    }

    [MetadataType(typeof(VentaMetadata))]
    public partial class Venta
    {
        public class VentaMetadata
        {
            [Key, ForeignKey("Pedidos"), Column(Order = 0) ]
            public int NroPedido { get; set; }
            [Key, ForeignKey("Flores"), Column(Order = 1)]
            public int CodFlores { get; set; }
            
            public int Cantidad { get; set; }
        }
    }

}