using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderType", Schema = "dbo")]
    public partial class TOrderType
    {
        public TOrderType()
        {
            TProvider = new HashSet<TProvider>();
        }

        [Key]
        [Column("OrderTypeID")]
        public byte OrderTypeId { get; set; }
        [Required]
        [StringLength(20)]
        public string OrderType { get; set; }

        [InverseProperty("OrderType")]
        public ICollection<TProvider> TProvider { get; set; }
    }
}
