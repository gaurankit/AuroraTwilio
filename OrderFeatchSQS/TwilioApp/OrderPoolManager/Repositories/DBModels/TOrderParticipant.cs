using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderParticipant", Schema = "dbo")]
    public partial class TOrderParticipant
    {
        public TOrderParticipant()
        {
            TParticipantCustomClientField = new HashSet<TParticipantCustomClientField>();
            TRuleGroupRegisterDetail = new HashSet<TRuleGroupRegisterDetail>();
        }

        [Key]
        [Column("OrderParticipantID")]
        public int OrderParticipantId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [StringLength(100)]
        public string ParticipantCode { get; set; }
        [Column("ParticipantAdditionalID")]
        [StringLength(50)]
        public string ParticipantAdditionalId { get; set; }
        [StringLength(100)]
        public string ParticipantFirstName { get; set; }
        [StringLength(200)]
        public string ParticipantLastname { get; set; }
        [StringLength(100)]
        public string ParticipantEmail { get; set; }
        [Column("DynamicRuleXML", TypeName = "xml")]
        public string DynamicRuleXml { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("TOrderParticipant")]
        public TOrder Order { get; set; }
        [InverseProperty("OrderParticipant")]
        public ICollection<TParticipantCustomClientField> TParticipantCustomClientField { get; set; }
        [InverseProperty("OrderParticipant")]
        public ICollection<TRuleGroupRegisterDetail> TRuleGroupRegisterDetail { get; set; }
    }
}
