using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCategoryCancelDetailError", Schema = "dbo")]
    public partial class TCategoryCancelDetailError
    {
        [Key]
        [Column("CategoryCancelDetailErrorID")]
        public int CategoryCancelDetailErrorId { get; set; }
        [Column("CategoryCancelDetailID")]
        public int CategoryCancelDetailId { get; set; }
        [Column("CategoryCancelDetailErrorTypeID")]
        public int CategoryCancelDetailErrorTypeId { get; set; }

        [ForeignKey("CategoryCancelDetailId")]
        [InverseProperty("TCategoryCancelDetailError")]
        public TCategoryCancelDetail CategoryCancelDetail { get; set; }
        [ForeignKey("CategoryCancelDetailErrorTypeId")]
        [InverseProperty("TCategoryCancelDetailError")]
        public TCategoryCancelDetailErrorType CategoryCancelDetailErrorType { get; set; }
    }
}
