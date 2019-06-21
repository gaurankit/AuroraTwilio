using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tProviderCancelPolicyProviderCancelPolicyText", Schema = "dbo")]
    public partial class TProviderCancelPolicyProviderCancelPolicyText
    {
        [Key]
        [Column("ProviderCancelPolicyProviderCancelPolicyTextID")]
        public int ProviderCancelPolicyProviderCancelPolicyTextId { get; set; }
        [Column("ProviderCancelPolicyID")]
        public int ProviderCancelPolicyId { get; set; }
        [Column("ProviderCancelPolicyTextID")]
        public int ProviderCancelPolicyTextId { get; set; }

        [ForeignKey("ProviderCancelPolicyId")]
        [InverseProperty("TProviderCancelPolicyProviderCancelPolicyText")]
        public TProviderCancelPolicy ProviderCancelPolicy { get; set; }
        [ForeignKey("ProviderCancelPolicyTextId")]
        [InverseProperty("TProviderCancelPolicyProviderCancelPolicyText")]
        public TProviderCancelPolicyText ProviderCancelPolicyText { get; set; }
    }
}
