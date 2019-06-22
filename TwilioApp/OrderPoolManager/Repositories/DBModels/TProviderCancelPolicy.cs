using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tProviderCancelPolicy", Schema = "dbo")]
    public partial class TProviderCancelPolicy
    {
        public TProviderCancelPolicy()
        {
            TProviderCancelPolicyProviderCancelPolicyText = new HashSet<TProviderCancelPolicyProviderCancelPolicyText>();
        }

        [Key]
        [Column("ProviderCancelPolicyID")]
        public int ProviderCancelPolicyId { get; set; }
        [Column("ProviderID")]
        public int ProviderId { get; set; }
        [Column("OrderCategoryTypeID")]
        public int OrderCategoryTypeId { get; set; }
        public bool IsCancellable { get; set; }
        [Column(TypeName = "money")]
        public decimal CancelFee { get; set; }
        [Column(TypeName = "money")]
        public decimal CancelFeeForeignCurrency { get; set; }
        public int DaysPriorNoCancelFee { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PolicyStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PolicyEndDate { get; set; }

        [ForeignKey("ProviderId")]
        [InverseProperty("TProviderCancelPolicy")]
        public TProvider Provider { get; set; }
        [InverseProperty("ProviderCancelPolicy")]
        public ICollection<TProviderCancelPolicyProviderCancelPolicyText> TProviderCancelPolicyProviderCancelPolicyText { get; set; }
    }
}
