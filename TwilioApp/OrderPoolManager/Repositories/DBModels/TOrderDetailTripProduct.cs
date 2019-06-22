using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderDetailTripProduct", Schema = "dbo")]
    public partial class TOrderDetailTripProduct
    {
        [Key]
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("TripProductID")]
        public Guid TripProductId { get; set; }

        [ForeignKey("OrderDetailId")]
        [InverseProperty("TOrderDetailTripProduct")]
        public TOrderDetail OrderDetail { get; set; }
    }
}
