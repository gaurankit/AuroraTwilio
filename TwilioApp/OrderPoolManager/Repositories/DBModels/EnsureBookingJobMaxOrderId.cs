using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("EnsureBookingJobMaxOrderID", Schema = "dbo")]
    public partial class EnsureBookingJobMaxOrderId
    {
        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Required]
        [StringLength(50)]
        public string OrderLocator { get; set; }
    }
}
