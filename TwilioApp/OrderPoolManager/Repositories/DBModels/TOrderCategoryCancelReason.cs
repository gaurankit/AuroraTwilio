using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderCategoryCancelReason", Schema = "dbo")]
    public partial class TOrderCategoryCancelReason
    {
        public TOrderCategoryCancelReason()
        {
            TOrderCategoryCancel = new HashSet<TOrderCategoryCancel>();
        }

        [Key]
        [Column("OrderCategoryCancelReasonID")]
        public byte OrderCategoryCancelReasonId { get; set; }
        [Required]
        [StringLength(255)]
        public string OrderCategoryCancelReason { get; set; }

        [InverseProperty("OrderCategoryCancelReason")]
        public ICollection<TOrderCategoryCancel> TOrderCategoryCancel { get; set; }
    }
}
