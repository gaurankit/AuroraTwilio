using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tRuleGroupRegisterDetail", Schema = "dbo")]
    public partial class TRuleGroupRegisterDetail
    {
        [Key]
        [Column("RuleGroupRegisterDetailID")]
        public int RuleGroupRegisterDetailId { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("OrderParticipantID")]
        public int OrderParticipantId { get; set; }
        [Column("RuleGroupRegisterID")]
        public int RuleGroupRegisterId { get; set; }

        [ForeignKey("OrderDetailId")]
        [InverseProperty("TRuleGroupRegisterDetail")]
        public TOrderDetail OrderDetail { get; set; }
        [ForeignKey("OrderParticipantId")]
        [InverseProperty("TRuleGroupRegisterDetail")]
        public TOrderParticipant OrderParticipant { get; set; }
    }
}
