using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderAmountType", Schema = "dbo")]
    public partial class TOrderAmountType
    {
        public TOrderAmountType()
        {
            TOrderCurrency = new HashSet<TOrderCurrency>();
        }

        [Key]
        [Column("OrderAmountTypeID")]
        public byte OrderAmountTypeId { get; set; }
        [Required]
        [StringLength(20)]
        public string OrderAmountType { get; set; }

        [InverseProperty("OrderAmountType")]
        public ICollection<TOrderCurrency> TOrderCurrency { get; set; }
    }
}
