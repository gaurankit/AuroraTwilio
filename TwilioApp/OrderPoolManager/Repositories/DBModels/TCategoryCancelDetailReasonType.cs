using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCategoryCancelDetailReasonType", Schema = "dbo")]
    public partial class TCategoryCancelDetailReasonType
    {
        public TCategoryCancelDetailReasonType()
        {
            TCategoryCancelDetail = new HashSet<TCategoryCancelDetail>();
        }

        [Key]
        [Column("CategoryCancelDetailReasonTypeID")]
        public byte CategoryCancelDetailReasonTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string CategoryCancelDetailReasonType { get; set; }

        [InverseProperty("CategoryCancelDetailReasonType")]
        public ICollection<TCategoryCancelDetail> TCategoryCancelDetail { get; set; }
    }
}
