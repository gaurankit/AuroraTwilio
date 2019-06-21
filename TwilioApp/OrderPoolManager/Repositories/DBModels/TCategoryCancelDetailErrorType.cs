using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCategoryCancelDetailErrorType", Schema = "dbo")]
    public partial class TCategoryCancelDetailErrorType
    {
        public TCategoryCancelDetailErrorType()
        {
            TCategoryCancelDetailError = new HashSet<TCategoryCancelDetailError>();
        }

        [Key]
        [Column("CategoryCancelDetailErrorTypeID")]
        public int CategoryCancelDetailErrorTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string CategoryCancelDetailErrorType { get; set; }

        [InverseProperty("CategoryCancelDetailErrorType")]
        public ICollection<TCategoryCancelDetailError> TCategoryCancelDetailError { get; set; }
    }
}
