using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tParticipantCustomClientField", Schema = "dbo")]
    public partial class TParticipantCustomClientField
    {
        [Key]
        [Column("ParticipantCustomClientFieldID")]
        public int ParticipantCustomClientFieldId { get; set; }
        [Column("OrderParticipantID")]
        public int? OrderParticipantId { get; set; }
        [StringLength(32)]
        public string ParticipantCustomFieldName { get; set; }
        [StringLength(400)]
        public string ParticipantCustomFieldValue { get; set; }
        public bool? ParticipantCustomFieldIsDisplayed { get; set; }

        [ForeignKey("OrderParticipantId")]
        [InverseProperty("TParticipantCustomClientField")]
        public TOrderParticipant OrderParticipant { get; set; }
    }
}
