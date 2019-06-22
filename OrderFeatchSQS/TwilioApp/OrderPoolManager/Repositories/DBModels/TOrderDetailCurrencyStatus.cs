using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderDetailCurrencyStatus", Schema = "dbo")]
    public partial class TOrderDetailCurrencyStatus
    {
        public TOrderDetailCurrencyStatus()
        {
            TOrderDetailCurrency = new HashSet<TOrderDetailCurrency>();
        }

        [Key]
        [Column("OrderDetailCurrencyStatusID")]
        public byte OrderDetailCurrencyStatusId { get; set; }
        [Required]
        [StringLength(20)]
        public string OrderDetailCurrencyStatus { get; set; }

        [InverseProperty("OrderDetailCurrencyStatus")]
        public ICollection<TOrderDetailCurrency> TOrderDetailCurrency { get; set; }
    }
}
