using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderError", Schema = "dbo")]
    public partial class TOrderError
    {
        [Key]
        [Column("OrderErrorID")]
        public int OrderErrorId { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [StringLength(50)]
        public string OrderErrorCode { get; set; }
        [StringLength(2000)]
        public string OrderErrorDescription { get; set; }
        [StringLength(50)]
        public string OrderErrorCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderErrorCreateDate { get; set; }

        [ForeignKey("OrderDetailId")]
        [InverseProperty("TOrderError")]
        public TOrderDetail OrderDetail { get; set; }
    }
}
