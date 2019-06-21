using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderStatusTypeCulture", Schema = "dbo")]
    public partial class TOrderStatusTypeCulture
    {
        [Key]
        [Column("OrderStatusTypeCultureID")]
        public int OrderStatusTypeCultureId { get; set; }
        [Column("OrderStatusTypeID")]
        public int OrderStatusTypeId { get; set; }
        [Column("LCID")]
        public int Lcid { get; set; }
        [StringLength(100)]
        public string OrderStatusTypeCultureDescription { get; set; }

        [ForeignKey("OrderStatusTypeId")]
        [InverseProperty("TOrderStatusTypeCulture")]
        public TOrderStatusType OrderStatusType { get; set; }
    }
}
