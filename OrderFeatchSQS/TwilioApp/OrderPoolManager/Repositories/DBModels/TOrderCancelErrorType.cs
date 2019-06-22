using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderCancelErrorType", Schema = "dbo")]
    public partial class TOrderCancelErrorType
    {
        public TOrderCancelErrorType()
        {
            TOrderCategoryCancelError = new HashSet<TOrderCategoryCancelError>();
        }

        [Key]
        [Column("OrderCancelErrorTypeID")]
        public int OrderCancelErrorTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string OrderCancelErrorType { get; set; }

        [InverseProperty("OrderCancelErrorType")]
        public ICollection<TOrderCategoryCancelError> TOrderCategoryCancelError { get; set; }
    }
}
