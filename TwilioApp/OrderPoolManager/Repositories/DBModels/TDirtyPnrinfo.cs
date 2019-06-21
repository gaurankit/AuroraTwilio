using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tDirtyPNRInfo", Schema = "dbo")]
    public partial class TDirtyPnrinfo
    {
        public long Id { get; set; }
        [Column(TypeName = "char(6)")]
        public string Locator { get; set; }
        [StringLength(32)]
        public string Airline { get; set; }
        [StringLength(18)]
        public string AirlinePhoneNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TravelDate { get; set; }
        [Column(TypeName = "char(6)")]
        public string AirlineLocator { get; set; }
        [StringLength(32)]
        public string ProgramId { get; set; }
        [Column("ProgramSCPhoneNumber")]
        [StringLength(18)]
        public string ProgramScphoneNumber { get; set; }
        [StringLength(24)]
        public string PhoneNumber { get; set; }
        [StringLength(24)]
        public string Template { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("SuperPNR")]
        [StringLength(32)]
        public string SuperPnr { get; set; }
        [Column("CANumber")]
        [StringLength(24)]
        public string Canumber { get; set; }
        [StringLength(16)]
        public string EmailStatus { get; set; }
        public bool? IsProcessed { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(64)]
        public string TransactionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProcessedDate { get; set; }
        public int? ClientId { get; set; }
        [StringLength(50)]
        public string ClientName { get; set; }
        [StringLength(255)]
        public string EmailId { get; set; }
        [StringLength(64)]
        public string ProgramName { get; set; }
    }
}
