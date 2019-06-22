using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tInsurance", Schema = "dbo")]
    public partial class TInsurance
    {
        [Key]
        [Column("InsuranceID")]
        public int InsuranceId { get; set; }
        [Column("ProviderID")]
        public int ProviderId { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("CreditReasonTypeID")]
        public int CreditReasonTypeId { get; set; }
        [Column("OrderStatusTypeID")]
        public int OrderStatusTypeId { get; set; }
        [StringLength(50)]
        public string InsuranceConfirmationCode { get; set; }
        [Column(TypeName = "money")]
        public decimal InsurancePolicyAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal InsurancePolicyAmountForeignCurrency { get; set; }

        [ForeignKey("CreditReasonTypeId")]
        [InverseProperty("TInsurance")]
        public TCreditReasonType CreditReasonType { get; set; }
        [ForeignKey("OrderDetailId")]
        [InverseProperty("TInsurance")]
        public TOrderDetail OrderDetail { get; set; }
        [ForeignKey("OrderStatusTypeId")]
        [InverseProperty("TInsurance")]
        public TOrderStatusType OrderStatusType { get; set; }
        [ForeignKey("ProviderId")]
        [InverseProperty("TInsurance")]
        public TProvider Provider { get; set; }
    }
}
