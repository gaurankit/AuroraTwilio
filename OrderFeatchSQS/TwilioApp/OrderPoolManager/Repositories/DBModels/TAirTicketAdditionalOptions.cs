using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tAirTicketAdditionalOptions", Schema = "dbo")]
    public partial class TAirTicketAdditionalOptions
    {
        [Column("AirTicketAdditionalOptionsID")]
        public int AirTicketAdditionalOptionsId { get; set; }
        [Key]
        [Column("AirTicketID")]
        public int AirTicketId { get; set; }
        public bool IsAirItineraryChanged { get; set; }
        public bool IsAirTicketRefundable { get; set; }
        [Column(TypeName = "money")]
        public decimal? InternalMarkup { get; set; }
        [Column(TypeName = "money")]
        public decimal? ClientMarkup { get; set; }
        [Column(TypeName = "money")]
        public decimal? FareQuoteAdjustmentAmount { get; set; }
        [StringLength(30)]
        public string FareQuoteAdjustmentType { get; set; }

        [ForeignKey("AirTicketId")]
        [InverseProperty("TAirTicketAdditionalOptions")]
        public TAirTicket AirTicket { get; set; }
    }
}
