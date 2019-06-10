using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Pedido
    {
        public int NroPedido { get; set; }
        public DateTime FecVenta { get; set; }
        public int IdCliente { get; set; }
        public IList<Cliente> Clientes { get; set; }
    }

    [MetadataType(typeof(PedidoMetadata))]
    public partial class Pedido
    {
        public class PedidoMetadata
        {
            [Key, Column(Order = 0)]
            public int NroPedido { get; set; }
            [Key, ForeignKey("Clientes"), Column(Order = 1)]
            public int IdCliente { get; set; }
            //[StringLength(100)]
            //public DateTime FecVenta { get; set; }
        }
    }
}