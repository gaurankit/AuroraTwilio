using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderRefundFailureDetail", Schema = "dbo")]
    public partial class TOrderRefundFailureDetail
    {
        public int OrderRefundFailureId { get; set; }
        public int CategoryCancelDetailId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AttemptedOnDate { get; set; }

        [ForeignKey("CategoryCancelDetailId")]
        [InverseProperty("TOrderRefundFailureDetail")]
        public TCategoryCancelDetail CategoryCancelDetail { get; set; }
        [ForeignKey("OrderRefundFailureId")]
        [InverseProperty("TOrderRefundFailureDetail")]
        public TOrderRefundFailure OrderRefundFailure { get; set; }
    }
}
