using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderDetailAmountType", Schema = "dbo")]
    public partial class TOrderDetailAmountType
    {
        [Key]
        [Column("OrderDetailAmountTypeID")]
        public byte OrderDetailAmountTypeId { get; set; }
        [Required]
        [StringLength(100)]
        public string OrderDetailAmountType { get; set; }
    }
}
