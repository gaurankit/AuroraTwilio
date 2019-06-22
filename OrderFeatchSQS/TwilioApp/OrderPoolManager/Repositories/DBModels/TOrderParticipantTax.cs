using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderParticipantTax", Schema = "dbo")]
    public partial class TOrderParticipantTax
    {
        [Key]
        [Column("OrderParticipantTaxID")]
        public int OrderParticipantTaxId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [StringLength(100)]
        public string ParticipantFirstName { get; set; }
        [StringLength(100)]
        public string ParticipantLastName { get; set; }
        [StringLength(200)]
        public string ParticipantAdd1 { get; set; }
        [StringLength(200)]
        public string ParticipantAdd2 { get; set; }
        [StringLength(100)]
        public string ParticipantCity { get; set; }
        [StringLength(100)]
        public string ParticipantState { get; set; }
        [StringLength(100)]
        public string ParticipantCountry { get; set; }
        [StringLength(50)]
        public string ParticipantPostalCode { get; set; }
        [StringLength(50)]
        public string ParticipantPhone { get; set; }
        [StringLength(100)]
        public string ParticipantEmail { get; set; }
        [Column("ParticipantTaxID")]
        [StringLength(100)]
        public string ParticipantTaxId { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("TOrderParticipantTax")]
        public TOrder Order { get; set; }
    }
}
