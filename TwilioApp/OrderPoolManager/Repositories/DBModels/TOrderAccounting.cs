using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderAccounting", Schema = "dbo")]
    public partial class TOrderAccounting
    {
        [Key]
        [Column("OrderAccountingID")]
        public int OrderAccountingId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [StringLength(20)]
        public string AccountingProgramCode { get; set; }
        public int? AccountingBranch { get; set; }
        [Column("AccountingPaymentHeaderID")]
        public int? AccountingPaymentHeaderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AccountingReportDate { get; set; }
        [StringLength(50)]
        public string ClientProvidedOrderCode { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("TOrderAccounting")]
        public TOrder Order { get; set; }
    }
}
