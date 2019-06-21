using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderCategoryCancelError", Schema = "dbo")]
    public partial class TOrderCategoryCancelError
    {
        [Key]
        [Column("OrderCategoryCancelErrorID")]
        public int OrderCategoryCancelErrorId { get; set; }
        [Column("OrderCategoryCancelID")]
        public int OrderCategoryCancelId { get; set; }
        [Column("OrderCancelErrorTypeID")]
        public int OrderCancelErrorTypeId { get; set; }

        [ForeignKey("OrderCancelErrorTypeId")]
        [InverseProperty("TOrderCategoryCancelError")]
        public TOrderCancelErrorType OrderCancelErrorType { get; set; }
        [ForeignKey("OrderCategoryCancelId")]
        [InverseProperty("TOrderCategoryCancelError")]
        public TOrderCategoryCancel OrderCategoryCancel { get; set; }
    }
}
