using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderRefundFailure", Schema = "dbo")]
    public partial class TOrderRefundFailure
    {
        public TOrderRefundFailure()
        {
            TOrderRefundFailureDetail = new HashSet<TOrderRefundFailureDetail>();
        }

        [Key]
        [Column("OrderRefundFailureID")]
        public int OrderRefundFailureId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        public byte CurrencyTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public bool? IsActive { get; set; }

        [ForeignKey("CurrencyTypeId")]
        [InverseProperty("TOrderRefundFailure")]
        public TCurrencyType CurrencyType { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("TOrderRefundFailure")]
        public TOrder Order { get; set; }
        [InverseProperty("OrderRefundFailure")]
        public ICollection<TOrderRefundFailureDetail> TOrderRefundFailureDetail { get; set; }
    }
}
