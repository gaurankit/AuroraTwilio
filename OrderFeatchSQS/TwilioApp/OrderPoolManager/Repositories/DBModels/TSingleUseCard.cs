using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tSingleUseCard", Schema = "dbo")]
    public partial class TSingleUseCard
    {
        [Key]
        [Column("SingleUseCardID")]
        public int SingleUseCardId { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Required]
        [Column(TypeName = "char(16)")]
        public string SingleUseCard { get; set; }
        [Column(TypeName = "money")]
        public decimal SingleUseCardAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal SingleUseCardAmountForeignCurrency { get; set; }

        [ForeignKey("OrderDetailId")]
        [InverseProperty("TSingleUseCard")]
        public TOrderDetail OrderDetail { get; set; }
    }
}
